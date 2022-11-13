using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tests
{
    internal class BitManipulation
    {
        public int SingleNumber(List<int> a)
        {
            int result = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                result = result ^ a[i];
            }
            return result;
        }

        /// <summary>
        /// Return Maximum XOR between l & r
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int maximizingXor(int l, int r)
        {
            //int result = 0;
            //#region Brute Force Approach
            //for (int i = l; i < r; i++)
            //{
            //    for (int j = r; j > l; j--)
            //    {
            //        if (i >= j)
            //            break;

            //        result = Math.Max(result, i ^ j);
            //    }                
            //}
            //#endregion

            //return result;

            var result = 0;
            for (var counter1 = l; counter1 <= r; counter1++)
            {
                for (var counter2 = counter1; counter2 <= r; counter2++)
                {
                    result = Math.Max(result, counter1 ^ counter2);
                }
            }
            return result;

        }


        /// <summary>
        /// Find all integers between 0 to n such that
        /// x => x+n = x^n;
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long sumXor(long n)
        {
            //long count = 0;
            //for (int i = 0; i <= n; i++)
            //{
            //    ulong sum = (ulong)(i + n);
            //    ulong xorval = (ulong)(i ^ n);

            //    if (sum == xorval)
            //        count++;
            //}
            //return count;

            long c = 0;
            while (n > 0)
            {
                if ((n & 1) == 0)
                    c++;
                n = n >> 1;
            }
            return (long)Math.Pow(2, c);
        }

        /// <summary>
        /// Return XOR of all possible subset's XOR
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int sansaXor(List<int> arr)
        {
            #region BruteForce Approach - Generate All SubArrays calculate XOR on them and add to a result array;XOR the result array
            //List<int> resultXor = new List<int>();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    for (int j = i; j < arr.Count; j++)
            //    {
            //        var range = j - i + 1;
            //        var sublist = arr.GetRange(i, j - i + 1);
            //        resultXor.Add(CalculateXOR(sublist));
            //    }
            //}
            //return CalculateXOR(resultXor);
            #endregion

            #region Optimized Approach - Using Dictionary
            int result = 0;
            if (arr.Count() % 2 == 0) return 0;
            for (int i = 0; i < arr.Count(); i += 2)
                result ^= arr[i];
            return result;
            #endregion
        }

        private int CalculateXOR(List<int> list)
        {
            int result = 0;
            for (int i = 0; i < list.Count; i++)
            {
                result = result ^ list[i];
            }
            return result;
        }

    }
}
