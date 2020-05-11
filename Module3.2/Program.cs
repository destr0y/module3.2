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
            var parse = int.TryParse(input, out result);
            if (parse && result >= 0)
                return true;
            else return false;

        }

        public int[] GetFibonacciSequence(int n)
        {
            if (n == 0) return new int[0];
            if (n == 1) return new int[] { 0 };
            
            var output = new List<int> { 0, 1 };
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
            var output = new string(Math.Abs(sourceNumber).ToString().Reverse().ToArray());
            if (sourceNumber > 0) return Convert.ToInt32(output);
            else return -Convert.ToInt32(output);
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
                return new int[0];
            else return new int[size];
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
                return new int[0];
            else return new int[size];
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
            int num = 1;
            int[,] result = new int[size, size];

            int i = 0, j = 0;          

            while (size != 0)
            {
                int k = 0;
                do 
                { 
                    result[i, j++] = num++;
                } while (++k < size - 1);

                for (k = 0; k < size - 1; k++) 
                    result[i++, j] = num++;

                for (k = 0; k < size - 1; k++) 
                    result[i, j--] = num++;

                for (k = 0; k < size - 1; k++) 
                    result[i--, j] = num++;
               
                ++i; ++j;
                size = size < 2 ? 0 : size - 2;
            }
            return result;
        }
    }
}