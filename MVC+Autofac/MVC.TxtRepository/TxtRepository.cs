using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.TxtRepository
{
    public class TxtRepository
    {
        public IEnumerable<string> GetAll()
        {
            var sr = new StreamReader("done.txt");
            var tmpList = new List<string>();

        }
    }
}
