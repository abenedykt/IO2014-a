using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace DataStorage
{
    public class DataStorageClass : IRepository
    {
        public IEnumerable<string> GetAll()
        {
            return new[] { "lorem ipsum ", "lorem " };
        }
    }
}
