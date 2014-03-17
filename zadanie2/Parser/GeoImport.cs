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



            GeoRecord singleRecord = new GeoRecord(
                records[0],
                GeoCoords(records[1]).Item1,
                GeoCoords(records[1]).Item2,
                );
        }

        private Tuple<double, double> GeoCoords(string line)
        {
            var tmp = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Take(2).ToArray();

            return new Tuple<double, double>(double.Parse(tmp[0]), double.Parse(tmp[1]));
        }

        private 

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