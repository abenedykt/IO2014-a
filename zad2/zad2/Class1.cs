using System.Collections.Generic;
using NSubstitute;
using Xunit;

namespace zad2
{
    public class Class1
    {

        [Fact]
        public void Test1()
        {
             var fileReader = Substitute.For<IGeoFileReader>();
             var repository = Substitute.For<IGeoRepository>();
             var imput = new GeoImput(fileReader, repository);
             
        }
    }

    public class GeoImput
    {
        public IGeoFileReader FileReader { get; set; }
        public IGeoRepository Repository { get; set; }
        public GeoImput(IGeoFileReader fileReader, IGeoRepository repository)
        {
            FileReader = fileReader;
            Repository = repository;
        }
    }


    public interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }

    public interface IGeoRepository
    {
        [Fact]
        void Add(string nrDzialki, int x, int y, int maxx, int maxy, int minx, int miny);
    }


}
