using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputString = Console.ReadLine();
            Problem1 prob1 = new Problem1();
            int total = prob1.stringCount(InputString);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
