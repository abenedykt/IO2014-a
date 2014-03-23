using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_GEO___Lab3
{
    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }
}
