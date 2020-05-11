using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
    }

    public class Task4
    {
        /// <summary>
        /// Use this method to parse and validate user input
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool TryParseNaturalNumber(string input, out int result)
        {
            var parse = Int32.TryParse(input, out result);
            if (!parse || result < 0)
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
                return false;
            }

            return true;
        }

        public int[] GetFibonacciSequence(int n)
        {
            var output = new List<int> {0,1};
            while (output.Count != n)
            {
                output.Add(output.TakeLast(2).Sum());
            }

            return output.ToArray();
        }
    }

    public class Task5
    {
        public int ReverseNumber(int sourceNumber)
        {
            return Convert.ToInt32(sourceNumber.ToString().Reverse());
        }
    }

    public class Task6
    {
        /// <summary>
        /// Use this method to generate array. It shouldn't throws exception.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] GenerateArray(int size)
        {
            if (size <= 0)
                return new int[] {};
            
            var output = new List<int>();
            for (int i = 0; i < size; i++)
            {
                output.Add(new Random().Next(-20, 20));
            }

            return output.ToArray();
        }

        public int[] UpdateElementToOppositeSign(int[] source)
        {
            return source.Select(x => -x).ToArray();
        }
    }

    public class Task7
    {
        /// <summary>
        /// Use this method to generate array. It shouldn't throws exception.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] GenerateArray(int size)
        {
            if (size <= 0)
                return new int[] {};
            
            var output = new List<int>();
            for (int i = 0; i < size; i++)
            {
                output.Add(new Random().Next(-20, 20));
            }

            return output.ToArray();
        }

        public List<int> FindElementGreaterThenPrevious(int[] source)
        {
            var output = new List<int>();
            for (int i = 0; i < source.Length - 1; i++)
            {
                if (source[i] < source[i+1]) 
                    output.Add(source[i+1]);
            }

            return output;
        }
    }

    public class Task8
    {
        public int[,] FillArrayInSpiral(int size)
        {
            int[,] matrix = new int[size, size];

            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;
            int visits = size;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                if (--visits == 0)
                {
                    visits = size * (dirChanges % 2) + size * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
            return matrix;
        }
    }
}
