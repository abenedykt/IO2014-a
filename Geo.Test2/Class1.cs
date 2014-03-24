using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zadanie_GEO___Lab3;


namespace Geo.Test2
{
    public class Class1
    {
        public class GeoImportTest
        {

            private const string DaneTestowe =
    @"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";


            private const string DaneTestowe2 = @"
               1.1-1446/63
        5545268.52        6531690.89        5545268.52        6531690.89 N  7
11
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7
              1-7044        5545325.03        6531709.57        5545325.03        6531709.57   0 N N  7
              1-7048        5545324.77        6531712.12        5545324.77        6531712.12   0 N N  7
              1-7019        5545225.22        6531698.42        5545225.22        6531698.42   0 N N  7
              1-7013        5545195.87        6531695.18        5545195.87        6531695.18   0 N N  7
              1-6974        5545196.37        6531672.15        5545196.37        6531672.15   0 N N  7
              1-6985        5545225.92        6531677.48        5545225.92        6531677.48   0 N N  7
              1-6984        5545245.51        6531677.23        5545245.51        6531677.23   0 N N  7
              1-6988        5545295.94        6531677.62        5545295.94        6531677.62   0 N N  7
              1-6989        5545322.96        6531678.09        5545322.96        6531678.09   0 N N  7
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7
";
            private const string DaneTestowe3 = @"
               1.1-1446/63
        5545268.52        6531690.89        5545268.52        6531690.89 N  7
11
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7
              1-7044        5545325.03        6531709.57        5545325.03        6531709.57   0 N N  7
              1-7048        5545324.77        6531712.12        5545324.77        6531712.12   0 N N  7
              1-7019        5545225.22        6531698.42        5545225.22        6531698.42   0 N N  7
              1-7013        5545195.87        6531695.18        5545195.87        6531695.18   0 N N  7
              1-6974        5545196.37        6531672.15        5545196.37        6531672.15   0 N N  7
              1-6985        5545225.92        6531677.48        5545225.92        6531677.48   0 N N  7
              1-6984        5545245.51        6531677.23        5545245.51        6531677.23   0 N N  7
              1-6988        5545295.94        6531677.62        5545295.94        6531677.62   0 N N  7
              1-6989        5545322.96        6531678.09        5545322.96        6531678.09   0 N N  7
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7
";

            private const string DaneTestoweUszkodzone = @"
               1.1-1446/63
        5545268.52        6531690.89        5545268.52        6531690.89 N  7
11
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7
              1-7044        5545325.03        6531709.57        5545325.03        6531709.57   0 N N  7
              1-7048        5545324.77        6531712.12        5545324.77        6531712.12   0 N N  7
              1-7019        5545225.22        6531698.42        5545225.22        6531698.42   0 N N  7
              1-7013        5545195.87        6531695.18        5545195.87        6531695.18   0 N N  7
              1-6974        5545196.37        6531672.15        5545196.37        6531672.15   0 N N  7
              1-6985        5545225.92        6531677.48        6531677.48   0 N N  7
              1-6984        5545245.51        6531677.23        5545245.51        6531677.23   0 N N  7
              1-6988        5545295.94        6531677.62        5545295.94        6531677.62   0 N N  
";

            [Fact]
            public void CzyRekord()
            {
                var fileReader = Substitute.For<IGeoFileReader>();
                fileReader.GetRecords().Returns(new[] { DaneTestowe });

                var repository = Substitute.For<IGeoRepository>();

                var record = new Rekord
                {
                    NrDziałki = "1.1-800/128",
                    X = 5544943.71,
                    Y = 6532099.62,
                    MinX = 5544907.94,
                    MaxX = 5544975.70,
                    MinY = 6532075.96,
                    MaxY = 6532117.26
                };

                var import = new Import(fileReader, repository);
                var result = import.PobierzRekordy().First();

                Assert.Equal(record, result);
            }


            [Fact]
            public void TestRekorduDrugiego()
            {
                var fileReader = Substitute.For<IGeoFileReader>();
                fileReader.GetRecords().Returns(new[] { DaneTestowe2 });

                var repository = Substitute.For<IGeoRepository>();

                var record = new Rekord
                {
                    NrDziałki = "1.1-1446/63",
                    X = 5545268.52,
                    Y = 6531690.89,
                    MinX = 5545195.87,
                    MaxX = 5545327.57,
                    MinY = 6531672.15,
                    MaxY = 6531712.12
                };

                var import = new Import(fileReader, repository);
                var result = import.PobierzRekordy().First();

                Assert.Equal(record, result);
            }

            [Fact]
            public void TestRekorduUszkodzonego()
            {
                var fileReader = Substitute.For<IGeoFileReader>();
                fileReader.GetRecords().Returns(new[] { DaneTestoweUszkodzone });

                var repository = Substitute.For<IGeoRepository>();

                var import = new Import(fileReader, repository);

                Assert.Throws<ArgumentException>(() => import.PobierzRekordy().ToList());
            }
        }

    }
}
