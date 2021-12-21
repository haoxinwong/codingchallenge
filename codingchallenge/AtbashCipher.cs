using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class AtbashCipher
    {
        public static string atbashCipher(string s)
        {
            string result = "";
            int i = 0;
            foreach(char c in s)
            {
                i = c;
                if (i > 96 && i <= 109)
                {
                    i = 122 - (i - 97);
                }else if(i>109 && i <= 122)
                {
                    i = 97 + (122 - i);
                }else if(i > 64 && i <= 77)
                {
                    i = 90 - (i - 65);
                }
                else if(i > 77 && i <= 90)
                {
                    i = 65 + (90 - i);
                }
                result = result + (char)i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(atbashCipher("apple"));
            Console.WriteLine(atbashCipher("Hello world!"));
            Console.WriteLine(atbashCipher("Christmas is the 25th of December"));
        }
    }
}
