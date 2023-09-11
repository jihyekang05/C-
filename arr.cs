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
            int[] score = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            Console.WriteLine(sum);
        }
    }
}
