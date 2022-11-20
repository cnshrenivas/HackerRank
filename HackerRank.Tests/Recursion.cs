using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tests
{
    internal class Recursion
    {
        #region Staircase
        /// <summary>
        /// https://www.hackerrank.com/contests/bosscoder-academy-recursion/challenges/staircase
        /// </summary>
        /// <param name="n"></param>
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }
        #endregion

        #region Calculate the Nth term
        /// <summary>
        /// https://www.hackerrank.com/contests/bosscoder-academy-recursion/challenges/recursion-in-c/problem
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int find_nth_term(int n, int a, int b, int c)
        {
            int result = calculate_nth_term(n, a, b, c);
            return result;

        }
        static int calculate_nth_term(int n, int a, int b, int c)
        {
            if (n == 1)
                return a;
            else if (n == 2)
                return b;
            else if (n == 3)
                return c;
            else
                return calculate_nth_term(n - 1, a, b, c) + calculate_nth_term(n - 2, a, b, c) + calculate_nth_term(n - 3, a, b, c);
        }
        #endregion

        #region Fibonacci Numbers
        public static int Fibonacci(int n)
        {
            int result = calculate_fibonacci(n);
            return result;

        }
        static int calculate_fibonacci(int n)
        {
            if (n < 2)
                return 0;
            else if (n == 2)
                return 1;
            else
                return calculate_fibonacci(n - 1) + calculate_fibonacci(n - 2);
        }
        #endregion

        #region The Power Sum

        /// <summary>
        /// https://www.hackerrank.com/contests/bosscoder-academy-recursion/challenges/the-power-sum
        /// </summary>
        /// <param name="X"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        public static int powerSum(int X, int N)
        {
            return calculatePowerSum(X, N, 1);
        }
        public static int calculatePowerSum(int X, int N, int n)
        {
            int result = (int)Math.Pow(n, N);
            if (result == X)
            {
                return 1;
            }
            else if (result > X)
            {
                return 0;
            }
            else
            {
                return calculatePowerSum(X, N, n + 1) + calculatePowerSum(X - result, N, n + 1);
            }
        }
        #endregion
    }
}
