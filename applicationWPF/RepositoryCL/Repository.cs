using IRepositoryCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCL
{
    public class Repository : IRepository
    {
        public IEnumerable<string> GetAll()
        {
            return new List<string>()
            {
                "    dfgdgd",
                "fdgbdgfd   ",
                "gvdgfdgfd"
            };
        }
    }
}
