using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAssignment
{
    class ContinguousSubArrayLargestSum
    {
        public static int SubArrayLargestSum(int[] nums)
        {
            var gSum = Int32.MinValue; ; //greatestSUm
            for (int i = 0; i < nums.Length; i++)
            {
                int esum = nums[i];
                if (esum > gSum)
                {
                    gSum = esum;
                }
                int isum = nums[i];
                for (int j = i; j < nums.Length; j++)
                {
                    isum += nums[j];
                    if (isum > gSum)
                    {
                        gSum = isum;
                    }
                }
            }
            return gSum;
        }
        public static int MaxSubArray(int[] nums)
        {
            int maxSoFar = nums.Max();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int currentSum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    currentSum += nums[j];
                    if (currentSum > maxSoFar)
                    {
                        maxSoFar = currentSum;
                    }

                }
            }
            return maxSoFar;
        }

        //1 . Write an efficient program to find the sum of contiguous subarray within a one-dimensional array of numbers which has the largest sum.
        public static int OrderOfNMaxSubArray(int[] nums)
        {
            //{ -2, -3, 4, -1, -2, 1, 5, -3 };
            int maxSum = nums[0];
            int current_sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (current_sum + nums[i] > nums[i])
                {
                    current_sum = current_sum + nums[i];
                    maxSum = current_sum;
                }
                else
                {
                    current_sum = nums[i];
                }
                maxSum = Math.Max(current_sum, maxSum);
            }
            return maxSum;
        }
    }
}
