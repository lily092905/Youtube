using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandparentMethod(int position)
        {
            return ParentMethond(position);
        }
        public int ParentMethond(int position)
        {
            return GetNumber(position);
        }
        public int GetNumber(int position)
        {
            int output = 0;
            //try
            //{
                int[] numbers = new int[] { 1, 3, 5, 7 };
                output = numbers[position];
                if(output == 3)
                {
                    throw new Exception("test");
                }
            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            return output;
        }
    }
}
