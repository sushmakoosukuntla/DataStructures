using NHibernate.Util;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class IndexAndFrequencyBasedSorting
    {
        /* 10.Print the elements of an array in the decreasing frequency if 2 numbers have same frequency then print the one which came first
         * Examples:
            Input:  arr[] = {2, 5, 2, 8, 5, 6, 8, 8}
            Output: arr[] = {8, 8, 8, 2, 2, 5, 5, 6}

            Input: arr[] = {2, 5, 2, 6, -1, 9999999, 5, 8, 8, 8 }
            Output: arr[] = {8, 8, 8, 2, 2, 5, 5, 6, -1, 9999999} */

        public static int[] SortingBasedOnIndexAndFrequesncy(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            Array.Sort(nums, (num1, num2) =>
            {
                int freq1 = dict[num1];
                int freq2 = dict[num2];

                if (freq1 != freq2)
                {
                    return freq2 - freq1;
                }
                return Array.IndexOf(nums, num1) - Array.IndexOf(nums, num2);
            });
            return nums;


        }

    }
}
