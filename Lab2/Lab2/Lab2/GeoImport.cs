using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            return fileReader.GetRecords().Select(ProcessRecord);
        }

        private GeoRecord ProcessRecord(string record)
        {
            var values = record
                .Split(' ', '\n')
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToList();

            var header = ProcessHeader(values);
            var areaBoundaries = ProcessPoints(values.Skip(8).ToList());

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

        private Tuple<string, double, double> ProcessHeader(List<string> values)
        {
            var nrDziałki = values[0];
            var x = values[1].ToDouble();
            var y = values[2].ToDouble();

            return Tuple.Create(nrDziałki, x, y);
        }

        private Tuple<double, double, double, double> ProcessPoints(List<string> values)
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
