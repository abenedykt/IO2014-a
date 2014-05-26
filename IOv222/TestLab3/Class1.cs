using Xunit;
using NSubstitute;

namespace TestLab3
{
    public class Class1
    {
        [Fact]
        public void Test()
        {
            var fileReader =Substitute.For<IGeoFileReader>();
            var repository =Substitute.For<IGeoRepository>();
            //var import = new IGeoFileReader(fileReader,repository);

           

        }
    }
}
