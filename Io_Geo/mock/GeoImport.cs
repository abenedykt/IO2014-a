using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace mock
{
    public class GeoImport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;
        }

        public IEnumerable<IEnumerable<string>> Parse()
        {
            string dataToParse = string.Concat(fileReader.GetRecords());
            return Parse(dataToParse);
        }

        public IEnumerable<IEnumerable<string>> Parse(string dataToParse)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string[] sections = dataToParse.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<List<string>> ieRows = new List<List<string>>();
            foreach (string item1 in sections)
            {
                string[] rowsWithHeader = item1.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                string[] rowsWithoutHeader = new string[rowsWithHeader.Length - 3];
                Array.Copy(rowsWithHeader, 3, rowsWithoutHeader, 0, rowsWithHeader.Length - 3);
                List<string> ieRow = new List<string>();
                List<double> xy = new List<double>();
                List<double> yy = new List<double>();
                string[] row2 = rowsWithHeader[1].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                ieRow.AddRange(new string[] { rowsWithHeader[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Single(),
                    row2[0], row2[1] });
                foreach (string item2 in rowsWithoutHeader)
                {
                    string[] dataRow = item2.Split(new char[] { ' ', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    xy.Add(double.Parse(dataRow[1]));
                    yy.Add(double.Parse(dataRow[2]));
                }
                double minx = xy.Min();
                double miny = yy.Min();
                double maxx = xy.Max();
                double maxy = yy.Max();
                ieRow.AddRange(new string[] { minx.ToString(), miny.ToString(), maxx.ToString(), maxy.ToString() });
                ieRows.Add(ieRow);
            }
            return ieRows;
        }
    }
}
