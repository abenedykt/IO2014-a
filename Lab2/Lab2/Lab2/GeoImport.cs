using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class GeoImport
    {
        private readonly IGeoFileReader fileReader;
        private readonly IGeoRepository repository;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;
        }

        public IEnumerable<GeoRecord> GetOutput()
        {
            return fileReader.GetRecords().Select(ProcessRecord);
        }

        private GeoRecord ProcessRecord(string record)
        {
            var values = record.Split(' ', '\n').Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            string nrDziałki = values[0];
            double x = double.Parse(values[1]);
            double y = double.Parse(values[2]);

            int numberOfPoints = int.Parse(values[7]);

            var result = ParsePoints(values.Skip(7));

            return new GeoRecord()
            {
                NrDziałki = nrDziałki,
                X = x,
                Y = y,
                MinX = result.Item1,
                MinY = result.Item2,
                MaxX = result.Item3,
                MaxY = result.Item4
            };
        }

        private Tuple<double, double, double, double> ParsePoints(IEnumerable<string> values)
        {
            var list = values.ToList();

            var lines = Partition(list, 7);

            var x = lines.Select(line => line[1]).Select(s => double.Parse(s));
            var y = lines.Select(line => line[2]).Select(s => double.Parse(s));

            return Tuple.Create(x.Min(), x.Max(), y.Min(), y.Max());
        }

        public static IEnumerable<List<T>> Partition<T>(List<T> source, int size)
        {
            for (int i = 0; i < Math.Ceiling(source.Count / (Double)size); i++)
                yield return new List<T>(source.Skip(size * i).Take(size));
        }
    }
}
