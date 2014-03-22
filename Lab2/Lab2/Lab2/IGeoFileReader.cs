using System.Collections.Generic;

namespace Lab2
{
    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }
}
