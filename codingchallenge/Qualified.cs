using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class Qualified
    {

        public static string isQualified(int[]i)
        {
            if (i.Length < 8||i.Sum()>120)
            {
                return "Disqualified";
            }
            int count = 0;
            int ini = 5;
            foreach(int num in i)
            {
                if (num > ini)
                {
                    return "Disqualified";
                }
                count++;
                if (count == 2)
                {
                    ini += 5;
                    count = 0;
                }
            }
            return "Qualified";

        }
        static void Main(string[] args)
        {
            Console.WriteLine(isQualified(new int []{5,5,10,10,15,15,20,20}));
            Console.WriteLine(isQualified(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }));
            Console.WriteLine(isQualified(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }));
            Console.WriteLine(isQualified(new int[] { 5, 5, 10, 10, 15, 15, 20 }));
            Console.WriteLine(isQualified(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }));
        }
    }
}
