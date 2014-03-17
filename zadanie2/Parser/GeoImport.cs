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
            this.GeoFileReader = geoFileReader;
            this.GeoRepository = geoRepository;
        }

        public IEnumerable<GeoRecord> Parse()
        {
            return this.GeoFileReader.GetRecords().Select(ProcessRecord);
        }

        public GeoRecord ProcessRecord(string record)
        {
            var records = record.Split('\n').Select();
        }
    }
}
