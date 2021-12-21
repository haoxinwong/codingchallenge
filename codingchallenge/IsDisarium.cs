using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class IsDisarium
    {
        public static bool isDisarium(int i)
        {
            bool result = false;
            string str = i.ToString();
            int tempNumber = 0;
            for(int j = 0; j < str.Length; j++)
            {
                tempNumber += (int)Math.Pow(Int32.Parse(str[j].ToString())*1.0 , (j+1) * 1.0);
            }
            if (tempNumber == i)
            {
                result = true;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isDisarium(75));
            Console.WriteLine(isDisarium(135));
            Console.WriteLine(isDisarium(544));
            Console.WriteLine(isDisarium(518));
            Console.WriteLine(isDisarium(466));
            Console.WriteLine(isDisarium(8));
        }
    }
}
