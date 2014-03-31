using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserGeo.Services
{
    public interface IFileReader
    {
        IEnumerable<string> GetRecords();
        string GetNextRecord();
    }
}
