using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Geo;

namespace GeoTest
{
    public class GeoTest
    {
        private const string ProperTestData =
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


        private const string InvalidArgumentTestData =
@"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7";

        private const string EmptyTestData = "";

        private const string InvalidFormatTestData =
@"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        aaaa              6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";

        [Fact]
        public void SuccessfulTest()
        {
            var record = new GeoRecord
            {
                NrDziałki = "1.1-800/128",
                X = 5544943.71,
                Y = 6532099.62,
                MinX = 5544907.94,
                MaxX = 5544975.70,
                MinY = 6532075.96,
                MaxY = 6532117.26
            };

            var result = new GeoImport(ProperTestData).ParseValueString().First();

            Assert.Equal(record, result);   
        }

        [Fact]
        public void ArgumentExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new GeoImport(InvalidArgumentTestData).ParseValueString().First()); 
        }

        [Fact]
        public void NullExceptionTest()
        {
            Assert.Throws<ArgumentNullException>(() => new GeoImport(EmptyTestData).ParseValueString().First());
        }

        [Fact]
        public void NumberFormatExceptionTest()
        {
            Assert.Throws<FormatException>(() => new GeoImport(InvalidFormatTestData).ParseValueString().First());
        }
    }
}
