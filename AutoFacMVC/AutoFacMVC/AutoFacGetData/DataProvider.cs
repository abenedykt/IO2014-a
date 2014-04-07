using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace AutoFacGetData
{
    public class DataProvider
    {
        string path = @"~/dane.txt";
        public IEnumerable<string> GetAll(string path)
        {
            var sr = new StreamReader(@path);
            return null;
        }
        
        
    }
}
