using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_By_value_And_Call_by_reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 40;
            callbyvalue1(i);
            callbyreference1(ref j);


            Console.WriteLine(i);
            Console.WriteLine(j);

        }
        public static void callbyvalue1(int j)
        {
            j = 20;
        }
        public static void callbyreference1(ref int j)
        {
            j = 30;
        }

    }
}
