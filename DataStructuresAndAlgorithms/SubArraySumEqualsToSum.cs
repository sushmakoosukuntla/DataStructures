﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class SubArraySumEqualsToSum
    {
        /* 4. Given an unsorted array of integers, find a subarray which adds to a given number. 
        * If there are more than one subarrays with sum as the given number, print any of them.
        Examples:
       Input: arr[] = {1, 4, 20, 3, 10, 5}, sum = 33
       Ouptut: Sum found between indexes 2 and 4

       Input: arr[] = {10, 2, -2, -20, 10}, sum = -10
       Ouptut: Sum found between indexes 0 to 3

       Input: arr[] = {-10, 0, 2, -2, -20, 10}, sum = 20
       Ouptut: No subarray with given sum exists*/
        public static void subArraySum(int[] arr, int n, int sum)
        {
            //cur_sum to keep track of cummulative sum till that point 
            int cur_sum = 0;
            int start = 0;
            int end = -1;
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                cur_sum = cur_sum + arr[i];
                //check whether cur_sum - sum = 0, if 0 it means 
                //the sub array is starting from index 0- so stop 
                if (cur_sum - sum == 0)
                {
                    start = 0;
                    end = i;
                    break;
                }
                //if hashMap already has the value, means we already  
                // have subarray with the sum - so stop 
                if (hashMap.ContainsKey(cur_sum - sum))
                {
                    start = hashMap[cur_sum - sum] + 1;
                    end = i;
                    break;
                }
                //if value is not present then add to hashmap 
                hashMap[cur_sum] = i;

            }
            // if end is -1 : means we have reached end without the sum 
            if (end == -1)
            {
                Console.WriteLine("No subarray with given sum exists");
            }
            else
            {
                Console.WriteLine("Sum found between indexes " + start + " to " + end);
            }

        }
    }
}
