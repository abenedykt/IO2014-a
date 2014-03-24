using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class GeoImport
    {
        public IGeoFileReader GeoFileReader { get; set; }
        public IGeoRepository GeoRepository { get; set; }

        public GeoImport(IGeoFileReader geoFileReader, IGeoRepository geoRepository)
        {
            this.GeoFileReader = geoFileReader;
            this.GeoRepository = geoRepository;
        }

        public IEnumerable<GeoRecord> Parse()
        {
            return this.GeoFileReader.GetRecords().Select(ProcessRecord);
        }

        public GeoRecord ProcessRecord(string record)
        {
            var records = record.Split('\n')
                .Select(n => n.Trim())
                .Where(n => !string.IsNullOrWhiteSpace((n)))
                .ToList();



            var columnX = CoordsColumns(records.Skip(3), 0);
            var columnY = CoordsColumns(records.Skip(3), 1);
            var minMaxX = GeoMinMax(columnX);
            var minMaxY = GeoMinMax(columnY);

            var singleRecord = new GeoRecord(
                records[0],
                GeoCoords(records[1]).Item1,
                GeoCoords(records[1]).Item2,
                minMaxX.Item1,
                minMaxX.Item2,
                minMaxY.Item1,
                minMaxY.Item2
                );

            return singleRecord;
        }

        private Tuple<double, double> GeoCoords(string line)
        {
            var tmp = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Take(2).ToArray();

            return new Tuple<double, double>(double.Parse(tmp[0]), double.Parse(tmp[1]));
        }

        private IEnumerable<string> CoordsColumns(IEnumerable<string> linesWithAllProperties, int count)
        {
            var columns = linesWithAllProperties.Select(
                n => n.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Skip(1 + count).First()
                );

            return columns.ToList();
        }

        private Tuple<double, double> GeoMinMax(IEnumerable<string> lines)
        {
            var max = lines.Max(n => double.Parse((n)));
            var min = lines.Min(n => double.Parse(n));

            return new Tuple<double, double>(min,max);
        }
    }
}

// test na pusty rekord
// test na uszkodzony rekord
// test na literke przy ??
// pusty string
// nieprawidłowe dane
// coś tam brakujące
// co parser powinien zrobić przy błędzie? exception czy pusty rekord?
// nie zwracać nulla, bo wprowadza syf :p nullable object?
// upchnąć do repozytorium