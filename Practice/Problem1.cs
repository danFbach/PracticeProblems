using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Problem1
    {
        public int countTotal;                          

        public int stringCount(string InputString)
        {                                   

            foreach (char c in InputString)
            {
                countTotal++;
            }

            return countTotal;
        }


        //List<string> InputString = new List<string>();
        //public int ListCount(List<String> InputString)
        //{                                           
        //    foreach(string s in InputString)
        //    {
        //        countTotal++;
        //    }
        //    return countTotal;
        //}

          
    }
}
