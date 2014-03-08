using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Lab_01
{
    public class ReturnType
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }
    public class FissBass
    {
        
        public int N { get; set; }

        public FissBass()
        {

        }

        public FissBass(string[] args)
        {
            N = Convert.ToInt32(args[0]);
        }

        public IEnumerable<ReturnType> ReturnCollection()
        {
            var tempCollection = new List<ReturnType>();
            for (int i = 0; i < N; i++)
            {
                tempCollection.Add(new ReturnType{ ID = i+1, Value = Play(i+1).ToString()});
            }
            return tempCollection;
        } 

        public object Play(int p)
        {
            switch (p % 15)
            {
                case 0: return "FissBass";
                case 3: return "Fiss";
                case 6: return "Fiss";
                case 5: return "Bass";
                case 10: return "Bass";
                case 9: return "Fiss";
                case 12: return "Fiss";
                default: return p;
            }
            #region naIF
            //if (p % 15 == 0)
            //{
            //    return "FissBass";
            //}
            //if (p % 3 == 0)
            //{
            //    return "Fiss";
            //}
            //if (p % 5 == 0)
            //{
            //    return "Bass";
            //}

            //return p;
            #endregion
        }
    }
}
