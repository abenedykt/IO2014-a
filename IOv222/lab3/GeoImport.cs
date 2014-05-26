using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLab3;

namespace lab3
{
    public class GeoImport
    {
        public readonly IGeoFileReader fileReader;
        public readonly IGeoRepository repository;

        public GeoImport(IGeoFileReader file, IGeoRepository repository )
        {
            this.repository = repository;
            this.fileReader = fileReader;

        }

        public IEnumerable<GeoRecord> GetOutput();
        {
            return  
        }

        private GeoRecord processRecord(string record)
        {
            
        }
    }
}
