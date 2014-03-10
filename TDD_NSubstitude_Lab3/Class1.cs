﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using Xunit;


namespace TDD_NSubstitude_Lab3
{
    interface IGeoRepository
    {
        void Add(double nrDzialki, double x, double y, double minX, double minY, double maxX, double maxY);
    }

    interface IGeoFileReader
    {
        IEnumerable<string> GetRecords();
    }

    class GeoFileReader : IGeoFileReader
    {
        public IEnumerable<string> GetRecords()
        {
            string rekord = @" 1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7
              1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7
              1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7";

            var fr = new StreamReader(rekord);
            var tmpList = new List<string>();
            string line = fr.ReadLine();
            string[] tab = new string[]{ " " };

            while (line != null)
            {
                tmpList.Add(line);
                var zm = line.Split(tab, StringSplitOptions.RemoveEmptyEntries);
            }

            
            foreach (var item in tmpList)
            {
                foreach (var s in item.Split())
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
