using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class KthSmallestNumber
    {
        /* 8. Given an array and a number k where k is smaller than size of array, 
        * we need to find the k’th smallest element in the given array. 
        * It is given that ll array elements are distinct. 
        * Examples:
           Input: arr[] = {7, 10, 4, 3, 20, 15}, k = 3
           Output: 7

           Input: arr[] = {7, 10, 4, 3, 20, 15}, k = 4
           Output: 10*/

        public static void ReturnKthSmallestNum(int[] nums, int k)
        {
            if (k < nums.Length)
            {
                Array.Sort(nums);
                Console.WriteLine("The Kth smallest numbers is: " + nums[k - 1]);
            }
            else
                Console.WriteLine("Array length is lesser than k");
        }

    }
}
