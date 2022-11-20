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
    }
}
