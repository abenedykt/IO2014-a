using System;
using Lab2;
using NSubstitute;
using System.Linq;
using Xunit;

namespace Lab2TEST
{
    public class GeoImportTest
    {
        private const string FirstRecordData =
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

        private GeoRecord firstParsedRecord = new GeoRecord
            {
                NrDziałki = "1.1-800/128",
                X = 5544943.71,
                Y = 6532099.62,
                MinX = 5544907.94,
                MaxX = 5544975.70,
                MinY = 6532075.96,
                MaxY = 6532117.26
            };

        private const string SecondRecordData =
@"               1.1-1446/63
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
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7";

        private const string InvalidRecordData = 
@"               1.1-1446/63
        5545268.52        6531690.89        5545268.52        6531690.89 N  7
11
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7
              1-6989        5545322.96        6531678.09        5545322.96        6531678.09   0 N N  7
              1-6990        5545327.57        6531678.07        5545327.57        6531678.07   0 N N  7";

        private GeoRecord secondParsedRecord = new GeoRecord
            {
                NrDziałki = "1.1-1446/63",
                X = 5545268.52,
                Y = 6531690.89,
                MinX = 5545195.87,
                MaxX = 5545327.57,
                MinY = 6531672.15,
                MaxY = 6531712.12
            };

        private GeoImport SetUpImport(params string[] data)
        {
            var fileReader = Substitute.For<IGeoFileReader>();
            fileReader.GetRecords().Returns(data);

            var repository = Substitute.For<IGeoRepository>();

            return new GeoImport(fileReader, repository);
        }

        [Fact]
        public void ParseValidSingleRecord()
        {
            var import = SetUpImport(FirstRecordData);

            var result = import.ParseRecords().First();

            Assert.Equal(firstParsedRecord, result);
        }

        [Fact]
        public void ParseTwoValidRecords()
        {
            var import = SetUpImport(FirstRecordData, SecondRecordData);

            var firstResult = import.ParseRecords().ElementAt(0);
            var secondResult = import.ParseRecords().ElementAt(1);

            Assert.Equal(firstParsedRecord, firstResult);
            Assert.Equal(secondParsedRecord, secondResult);
        }

        [Fact]
        public void ParseInvalidSingleRecord()
        {
            var import = SetUpImport(InvalidRecordData);

            Assert.Throws<ArgumentException>(() => import.ParseRecords().ToList());
        }

    }
}
