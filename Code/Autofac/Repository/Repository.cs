using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositoryC;

namespace RepositoryC
{
    public class Repository: IRepository
    {
        public IEnumerable<string> GetAll()
        {
            return new[] { "Jeden", "Dwa"};
        }
    }
}
