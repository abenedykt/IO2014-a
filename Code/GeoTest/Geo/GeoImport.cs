using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geo
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

    }
}
