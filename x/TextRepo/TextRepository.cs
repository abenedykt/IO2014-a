using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepo;

namespace TextRepo
{
    public class TextRepository : IRepository
    {
        private string[] array;

        public TextRepository()
        {
            array = new string[] { "ITAD", "DWO" };
        }

        public TextRepository(string[] array)
        {
            this.array = array;
        }

        public IEnumerable<string> GetAll()
        {
            return array;
        }
    }
}
