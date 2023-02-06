using ExceptionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoCode demo = new DemoCode();
            int[] testcase = new int[] { 0, 2, 1, 4, 1 };
            for(int i =0; i<testcase.Length; i++)
            {
                try
                {
                    int result = demo.GrandparentMethod(testcase[i]);
                    Console.WriteLine($"The value at the given position is {result}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.ReadLine();
        }
    }
}
