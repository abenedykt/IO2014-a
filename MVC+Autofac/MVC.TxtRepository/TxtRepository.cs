using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.IRepository;

namespace MVC.TxtRepository
{
    public class TxtRepository : IRepositoryY
    {
        public IEnumerable<string> GetAll()
        {

            return new[] {"asdasd asd ", "dasdasd "};
        }
    }
}
