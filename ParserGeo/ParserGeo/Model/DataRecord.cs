using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserGeo.Model
{
    public class DataRecord
    {
        public string Name { get; set; }
        public Position Position { get; set; }
        public Position Maximum { get; set; }
        public Position Minimum { get; set; }

        public static bool operator ==(DataRecord data1, DataRecord data2)
        {
            return (data1.Name == data2.Name &&
                    data1.Position == data2.Position &&
                    data1.Maximum == data2.Maximum &&
                    data1.Minimum == data2.Minimum);
        }

        public static bool operator !=(DataRecord data1, DataRecord data2)
        {
            return !(data1 == data2);
        }

        public override bool Equals(object obj)
        {
            return (this == (DataRecord) obj);
        }
    }
}
