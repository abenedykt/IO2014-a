using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NSubstitute;
using ParserGeo.Model;
using ParserGeo.Services;
using Xunit;

namespace ParserGeo.Tests
{
    public class Class1
    {
        private readonly string TestRecord = @"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";

        [Fact]
        public void TestParseRecord()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            var parser = new Parser();

            var fileReader = Substitute.For<IFileReader>();
            fileReader.GetNextRecord().Returns(TestRecord);

            var record = parser.ParseSingleRecord(fileReader.GetNextRecord());

            var expectedRecord = new DataRecord()
            {
                Name = "1.1-800/128",
                Position = new Position()
                {
                    X = 5544943.71,
                    Y = 6532099.62
                },
                Minimum = new Position()
                {
                    X = 5544907.94,
                    Y = 6532075.96
                },
                Maximum = new Position()
                {
                    X = 5544975.70,
                    Y = 6532117.26
                }
            };

            Assert.True(record.Equals(expectedRecord));
        }

        [Fact]
        public void TestImport()
        {
            
        }
    }
}
