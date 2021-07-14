using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class SortingArray012
    {
        /*5. Write a program to sort an array of 0's,1's and 2's in ascending order.*/

        public static void SortingArrayOf0s1s2s(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;
            int holdValue = 0;
            while (mid <= right)
            {

                if (nums[mid] == 0)
                {
                    holdValue = nums[left];
                    nums[left] = nums[mid];
                    nums[mid] = holdValue;
                    left++;
                    mid++;

                }
                else if (nums[mid] == 1)
                {
                    mid++;

                }
                else
                {
                    holdValue = nums[mid];
                    nums[mid] = nums[right];
                    nums[right] = holdValue;
                    right--;

                }

            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);

            }

        }
    }
}
