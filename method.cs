using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            int res = Add(a, b);

            int res2 = Sub(a, b);

            Console.WriteLine(res);
            Console.WriteLine(res2);
        }

        private static int Sub(int a, int b)
        {
            int c = b - a;
            return c;
        }

        private static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
