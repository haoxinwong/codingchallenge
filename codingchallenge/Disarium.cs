using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class Disarium
    {
        public static string isDisarium(int i)
        {
            double total = 0;
            string s = i.ToString();
            for (int n = 1; n <= s.Length; n++)
            {

                total += Math.Pow((s[n - 1] - '0'),n);
            }
            if (total == i)
            {
                return "true";
            }
            return "false";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isDisarium(75));
            Console.WriteLine(isDisarium(135));
            Console.WriteLine(isDisarium(518));
            Console.WriteLine(isDisarium(544));
            Console.WriteLine(isDisarium(8));
            Console.WriteLine(isDisarium(466));
        }
    }
}
