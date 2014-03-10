using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad2Dzialki
{
    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords(IEnumerable<string> records);
    }
}
