using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubstitute_Projekt
{

    interface IGeoRepository
    {
        void Add(string naDzialki, double x, double y, double minX, double minY, double maxX, double maxY);
    }

    interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }

    class GeoInport
    {
        private IGeoFileReader fileReader;
        private IGeoRepository repository;

        public GeoInport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            this.fileReader = fileReader;
            this.repository = repository;
        }
    }    
}
