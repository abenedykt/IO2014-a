using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;

namespace TDD_Lab_02
{
    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }
    public interface IGeoRepository
    {
        void Add(int nrDzialki, double x, double y, double minX, double minY, double maxX, double maxY);
    }

    class GeoImport
    {
        public GeoImport(IGeoFileReader fileReader, IGeoRepository repository)
        {
            
        }
    }
    class GeoFileReader : IGeoFileReader
    {
        public IEnumerable<string> GetRecords()
        {
            var sr = new StreamReader("geo.txt");
            var tmpList = new List<string>();

            string line;
            while ((line = sr.ReadLine()) != null)
            {
               tmpList.Add(line);
            }
            var tmpStrings = new string[10];
            foreach (var item in tmpList)
            {
                foreach (var s in item.Split(tmpStrings, StringSplitOptions.RemoveEmptyEntries))
                {
                    
                }
            }

        }
    }
    public class Class1
    {
        [Fact]
        public void Test()
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            var repository = Substitute.For<IGeoRepository>();
            var import = new GeoImport(fileReader, repository);

            fileReader.GetRecords();
        }
    }
}
