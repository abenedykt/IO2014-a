using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_NSubstitude_Lab3
{
    class GeoImport
    {
        private IGeoFileReader reader;
        private IGeoRepository repository;

        public GeoImport(IGeoFileReader fileReader, IGeoRepository repo)
        {
            this.reader = fileReader;
            this.repository = repo;
        }
    }
}
