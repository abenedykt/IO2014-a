using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

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

            //dirty fix for double format parsing
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        public IEnumerable<GeoRecord> ParseRecords()
        {
            return fileReader.GetRecords().Select(ParseRecord);
        }

        private GeoRecord ParseRecord(string record)
        {
            const int headerLength = 7;

            var values = record
                .Split(' ', '\n')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            var header = ParseHeader(values);
            var areaBoundaries = ParsePoints(values.Skip(headerLength));

            return new GeoRecord
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
            var pointCount = values.First().ToInt();
            var pointsData = values.Skip(1);

            var lines = pointsData
                .Partition(9)
                .Select(seq => seq.ToList())
                .ToList();

            Func<int, List<double>> getColumnOfIndex =
                i =>
                {
                    var column = lines
                        .Select(line => line[i])
                        .Select(double.Parse)
                        .ToList();

                    if (column.Count != pointCount)
                        throw new ArgumentException();

                    return column;
                };


            var x = getColumnOfIndex(1);
            var y = getColumnOfIndex(2);

            return Tuple.Create(x.Min(), x.Max(), y.Min(), y.Max());
        }
    }
}
