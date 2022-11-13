using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tests
{
    internal class SearchingAndSorting
    {
        #region Find the Median
        /// <summary>
        /// https://www.hackerrank.com/contests/bosscoder-searchsort/challenges/find-the-median
        /// Length of Array is always odd
        /// Array is not sorted always
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            int mid = arr.Count/ 2;
            return arr[mid];
        }
        #endregion

        #region Ice Cream Parlor
        /// <summary>
        /// https://www.hackerrank.com/contests/bosscoder-searchsort/challenges/icecream-parlor
        /// </summary>
        /// <param name="m"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            #region BruteForce Approach
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i+1; j < arr.Count; j++)
                {
                    if (arr[i] + arr[j] == m)
                    {
                        result.Add(i + 1);
                        result.Add(j + 1);
                        result.Sort();
                        return result;
                    }

                }
            }
            return null;
            #endregion
            //List<int> result = new List<int>();
            //Dictionary<int, int> arrayIdxDict = new Dictionary<int, int>();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (arrayIdxDict.ContainsKey(arr[i]))
            //        arrayIdxDict[arr[i]]++;
            //    else
            //        arrayIdxDict.Add(arr[i], 1);
            //}

            //arr.Sort();
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    int num1 = arr[i];
            //    int num2 = Math.Abs(m - arr[i]);
            //    if (FindNumber(arr, num2))
            //    {
            //        result.Add(arrayIdxDict[num1]);
            //        result.Add(arrayIdxDict[num2]);
            //        break;
            //    }
            //}
            //return result;
        }
        private static bool FindNumber(List<int> arr, int target)
        {
            int left = 0;
            int right = arr.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;


                if (arr[mid] == target)
                    return true;
                else if (arr[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return false;
        }
        #endregion

        #region Missing Numbers
        /// <summary>
        /// https://www.hackerrank.com/contests/bosscoder-searchsort/challenges/missing-numbers
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="brr"></param>
        /// <returns></returns>
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            List<int> missingNumbers = new List<int>();
            Dictionary<int, int> arrFreqDict = new Dictionary<int, int>();
            Dictionary<int, int> brrFreqDict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arrFreqDict.ContainsKey(arr[i]))
                    arrFreqDict[arr[i]]++;
                else
                    arrFreqDict.Add(arr[i], 1);
            }
            for (int i = 0; i < brr.Count; i++)
            {
                if (brrFreqDict.ContainsKey(brr[i]))
                    brrFreqDict[brr[i]]++;
                else
                    brrFreqDict.Add(brr[i], 1);
            }
            for (int i = 0; i < arrFreqDict.Count; i++)
            {
                int key = arrFreqDict.ElementAt(i).Key;
                if (brrFreqDict.TryGetValue(key, out int brrFreqVal))
                {
                    if (brrFreqVal == arrFreqDict[key])
                    {
                        brrFreqDict.Remove(key);
                    }
                }
            }
            for (int i = 0; i < brrFreqDict.Count; i++)
            {
                missingNumbers.Add(brrFreqDict.ElementAt(i).Key);
            }
            missingNumbers.Sort();
            return missingNumbers;
        }
        #endregion

        #region Sherlock and Array
        /// <summary>
        /// https://www.hackerrank.com/contests/bosscoder-searchsort/challenges/sherlock-and-array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string balancedSums(List<int> arr)
        {
            int totalSum = 0;
            int runningSum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                totalSum += arr[i];
            }
            for (int i = 0; i < arr.Count; i++)
            {
                totalSum -= arr[i];
                if (runningSum == totalSum)
                    return "YES";
                runningSum += arr[i];
            }
            return "NO";
        }
        #endregion
    }
}
