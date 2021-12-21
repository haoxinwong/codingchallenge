using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingchallenge
{
    class MagicSquare
    {

        public static bool IsMagicSquare(int[,] square)
        {
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < square.GetLength(1); i++)
            {
                sum1 = sum1 + square[i, i];
            }
            for (int i = 0; i < square.GetLength(1); i++)
            {
                sum2 = sum2 + square[i, square.GetLength(1) - 1 - i];
            }
            if (sum1 != sum2)
            {
                return false;
            }
            for (int i = 0; i < square.GetLength(1); i++)
            {
                int colSum = 0;
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    colSum += square[j, i];
                }
                if (sum1 != colSum)
                {
                    return false;
                }
            }
            for (int i = 0; i < square.GetLength(1); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < square.GetLength(1); j++)
                {
                    rowSum += square[i, j];
                }
                if (sum1 != rowSum)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(IsMagicSquare(
            new int[,] {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
            }));

            Console.WriteLine(IsMagicSquare(new int[,] {
            { 16, 3, 2, 13 },
            { 5, 10, 11, 8 },
            { 9, 6, 7, 12 },
            { 4, 15, 14, 1 }
            }));
            Console.WriteLine(IsMagicSquare(new int[,] {
            { 1, 14, 14, 4 },
            { 11, 7, 6, 9 },
            { 8, 11, 10, 5 },
            { 13, 2, 3, 15 }
            }));




        }
    }
}
