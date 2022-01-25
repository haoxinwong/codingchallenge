using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class SquarePrint
    {
        public static string squarePrint(int i)
        {
            string result = "";
            for (int j = 0; j < i; j++)
            {
                for (int t = 0; t < i; t++)
                {
                    result += " /\\ ";
                }
                result += "\n";
                for (int m = 0; m < i; m++)
                {
                    result += "<  >";
                }
                result += "\n";
                for (int b = 0; b < i; b++)
                {
                    result += " \\/ ";
                }
                result += "\n";
            }
            return result;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine(squarePrint(1));
            Console.WriteLine(squarePrint(2));
            Console.WriteLine(squarePrint(3));

        }
    }
}
