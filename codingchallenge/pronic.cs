using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class pronic
    {
        public static bool isHeteromecic(int i)
        {
            bool result = false;
            int sqrt = (int)Math.Sqrt(i);
            if (sqrt * (sqrt + 1) == i)
            {
                result = true;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isHeteromecic(0));
            Console.WriteLine(isHeteromecic(2));
            Console.WriteLine(isHeteromecic(7));
            Console.WriteLine(isHeteromecic(110));
            Console.WriteLine(isHeteromecic(136));
            Console.WriteLine(isHeteromecic(156));
        }
    }
}
