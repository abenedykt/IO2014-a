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

        private List<String> GetValues()
        {
            var values = this.valueString
                       .Split(' ', '\n')
                       .Select(n => n.Trim())
                       .Where(n => !string.IsNullOrWhiteSpace(n))
                       .ToList();

            CheckValues(values);

            return values;
        }

        private void CheckValues(List<string> values)
        {
            if (values.Count == 0)
            {
                throw new ArgumentNullException();
            }

            int k = 0;
            for (; k < values.Count; )
            {
                try
                {
                    k += (Convert.ToInt32(values[k + 7]) * 9) + 8;
                }
                catch (FormatException)
                {
                    throw;
                }
            }

            if (k != values.Count)
            {
                throw new ArgumentException();
            }
        }

        public List<GeoRecord> ParseValueString()
        {
            var values = GetValues();

            List<GeoRecord> result = new List<GeoRecord>();

            List<double> listaXTmp;
            List<double> listaYTmp;
            int i = 0;

            try
            {
                while (i < values.Count)
                {
                    int j = i;
                    listaXTmp = new List<double>();
                    listaYTmp = new List<double>();
                    int jump = (Convert.ToInt32(values[i + 7]) * 9) + 8;

                    while ((j + 9) < (i + jump))
                    {
                        listaXTmp.Add(Convert.ToDouble(values[j + 9]));
                        listaYTmp.Add(Convert.ToDouble(values[j + 10]));
                        j += 9;
                    }

                    result.Add(new GeoRecord
                    {
                        NrDziałki = values[i],
                        X = Convert.ToDouble(values[i + 1]),
                        Y = Convert.ToDouble(values[i + 2]),
                        MinX = listaXTmp.Min(),
                        MinY = listaYTmp.Min(),
                        MaxX = listaXTmp.Max(),
                        MaxY = listaYTmp.Max()
                    });

                    i += jump;
                }
            }
            catch (FormatException)
            {
                throw;
            }

            return result;
        }
    }
}
