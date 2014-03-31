using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserGeo.Model;

namespace ParserGeo.Services
{
    public interface IParser
    {
        DataRecord ParseSingleRecord(string record);
        IEnumerable<DataRecord> ParseAllRecords(string records);
    }

    public class Parser : IParser
    {
        public DataRecord ParseSingleRecord(string record)
        {
            var lines = getColumns(record, '\n');

            var geoPosition = getColumns(lines[1], ' ');

            var positions = lines.Skip(3).Select(n => getColumns(n, ' '));

            var dataRecord = new DataRecord()
            {
                Name = lines[0],
                Position = new Position()
                {
                    X = double.Parse(geoPosition[0]), 
                    Y = double.Parse(geoPosition[1])
                },
                Maximum = new Position()
                {
                    X = double.Parse(positions.Select(n => n[1]).Max()),
                    Y = double.Parse(positions.Select(n => n[2]).Max())
                },
                Minimum = new Position()
                {
                    X = double.Parse(positions.Select(n => n[1]).Min()),
                    Y = double.Parse(positions.Select(n => n[2]).Min())
                }
            };

            return dataRecord;
        }

        public IEnumerable<DataRecord> ParseAllRecords(string records)
        {
            throw new NotImplementedException();
        }

        private string[] getColumns(string text, char seperator)
        {
            return
                text.Split(new char[] {seperator}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => n.Trim())
                    .ToArray();
        }
    }

}
