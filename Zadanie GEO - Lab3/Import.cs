using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_GEO___Lab3
{
    public class Import
    {
        private readonly IGeoFileReader fileReader;
        private readonly IGeoRepository repository;

        public Import(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        public IEnumerable<Rekord> PobierzRekordy()
        {
            return fileReader.GetRecords().Select(ParseRecord);
        }

        private Rekord ParseRecord(string record)
        {
            var values = record
                .Split(' ', '\n')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            var header = ParseHeader(values);
            var areaBoundaries = ParsePoints(values.Skip(8));

            return new Rekord
            {
                NrDziałki = header.Item1,
                X = header.Item2,
                Y = header.Item3,
                MinX = areaBoundaries.Item1,
                MaxX = areaBoundaries.Item2,
                MinY = areaBoundaries.Item3,
                MaxY = areaBoundaries.Item4
            };
        }

        private Tuple<string, double, double> ParseHeader(List<string> values)
        {
            var nrDziałki = values[0];
            var x = values[1].ToDouble();
            var y = values[2].ToDouble();

            return Tuple.Create(nrDziałki, x, y);
        }

        private Tuple<double, double, double, double> ParsePoints(IEnumerable<string> values)
        {
            var lines = values
                .Partition(9)
                .Select(seq => seq.ToList())
                .ToList();

            Func<int, List<double>> getColumnOfIndex =
                i => lines
                    .Select(line => line[i])
                    .Select(double.Parse)
                    .ToList();

            var x = getColumnOfIndex(1);
            var y = getColumnOfIndex(2);

            return Tuple.Create(x.Min(), x.Max(), y.Min(), y.Max());
        }
    }
}
