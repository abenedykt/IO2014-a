using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    public class GeoImport
    {

        public IGeoFileReader GeoFileReader { get; set; }
        public IGeoRepository GeoRepository { get; set; }

        public GeoImport(IGeoFileReader geoFileReader, IGeoRepository geoRepository)
        {
            GeoFileReader = geoFileReader;
            GeoRepository = geoRepository;
        }




        public IEnumerable<GeoRecord> Parse()
        {
           // return GeoFileReader.GetRecords().SelectMany(n=>new GeoRecord(n.Split('\n').)
        }
    }
}
