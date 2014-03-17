using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Geo
{
    public class GeoImport
    {
        private string valueString;

        public GeoImport(string value)
        {
            this.valueString = value;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        }

        public List<GeoRecord> ParseValueString()
        {
            var value = this.valueString
                        .Split(' ', '\n')
                        .Select(n => n.Trim())
                        .Where(n => !string.IsNullOrWhiteSpace(n))
                        .ToList();

            List<GeoRecord> result = new List<GeoRecord>();

            List<double> listaXTmp;
            List<double> listaYTmp;
            int i = 0;

            while (i < value.Count)
            {
                int j = i;
                listaXTmp = new List<double>();
                listaYTmp = new List<double>();
                int jump = (Convert.ToInt32(value[i + 7]) * 9) + 8;

                while ((j + 9) < (i + jump))
                {
                    listaXTmp.Add(Convert.ToDouble(value[j + 9]));
                    listaYTmp.Add(Convert.ToDouble(value[j + 10]));
                    j += 9;
                }

                result.Add(new GeoRecord
                {
                    NrDziałki = value[i],
                    X = Convert.ToDouble(value[i + 1]),
                    Y = Convert.ToDouble(value[i + 2]),
                    MinX = listaXTmp.Min(),
                    MinY = listaYTmp.Min(),
                    MaxX = listaXTmp.Max(),
                    MaxY = listaYTmp.Max()
                });

                i += jump;
            }

            return result;
        }
    }
}
