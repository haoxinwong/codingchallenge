using System;
using System.Collections.Generic;

namespace codingchallenge
{
    class DeadEnd
    {

        public static long[] DeadEnd(long i)
        {
            if (i <= 10)
            {
                return new long[] { 2, 1 };
            }
            long[] result = new long[2];
            List<long> deadend = new List<long>();
            deadend.Add(i);
            int count = 0;
            long total=0;
            while (count<2)
            {
                string si = i.ToString();
                //Console.WriteLine(si);
                for (int index = 0;index < si.Length; index++){
                    total += Int32.Parse(si[index].ToString());
                }
     
                if (i % total == 0)
                {
                    i = i / total;
                }
                else
                {
                    i = i * total;
                }
                deadend.Add(i);
                if (deadend.Count > 2)
                {
                    if(deadend[deadend.Count-1]== deadend[deadend.Count - 3])
                    {
                        count++;
                    }
                }
                total = 0;
            }
            result[0] = deadend.Count-2;
            result[1] = deadend[deadend.Count - 1];
            return result;
        }
        public static string tostring(long[]i)
        {
            string s = "";
            foreach(long num  in i)
            {
                s = s + num + " ";
            }
            return s;
        } 
        static void Main(string[] args)
        {

            Console.WriteLine(tostring(DeadEnd(58)));
            Console.WriteLine(tostring(DeadEnd(5)));
            Console.WriteLine(tostring(DeadEnd(11)));
            Console.WriteLine(tostring(DeadEnd(101)));
            Console.WriteLine(tostring(DeadEnd(123456789)));
        }


    }
}
