using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class HappyNumber
    {
        public static  bool isHappyNumber(int i)
        {
            bool result = false;
            string str = i.ToString();
            bool loopstart = true;
            int tempNumber = 0;
            while (loopstart)
            {
                foreach (char c in str)
                {
                    tempNumber += (Int32.Parse(c.ToString())* Int32.Parse(c.ToString()));
                }
                if (tempNumber == 1)
                {
                    loopstart = false;
                    result = true;
                }
                if (tempNumber == 4)
                {
                    loopstart = false;
                    
                }
                i = tempNumber;
                str = i.ToString();
                tempNumber = 0;
            }
            
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isHappyNumber(2));
            Console.WriteLine(isHappyNumber(203));
            Console.WriteLine(isHappyNumber(11));
            Console.WriteLine(isHappyNumber(107));
        }
    }
}
