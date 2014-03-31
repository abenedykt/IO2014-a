using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TxtRepository : IRepositoryC
    {
        public IEnumerable<string> GetAll()
        {
            return new[] { "First", "Second" };
        }
    }
}
