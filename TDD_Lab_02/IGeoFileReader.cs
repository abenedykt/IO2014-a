using System.Collections.Generic;

namespace TDD_Lab_02
{
    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }
}