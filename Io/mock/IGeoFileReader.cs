using System;
namespace mock
{
    public interface IGeoFileReader
    {
        System.Collections.Generic.IEnumerable<string> GetRecords();
    }
}
