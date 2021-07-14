using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class MissingNumber
    {
        /* 2. You are given a list of n-1 integers and these integers are in the range of 1 to n. 
         * There are no duplicates in list. One of the integers is missing in the list. 
         * Write an efficient code to find the missing integer.*/
        public static int OrderOfNMissingNumber(int[] nums, int n)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int nNoSum = n * (n + 1) / 2;
            int missingNumber = nNoSum - sum;
            return missingNumber;
        }

    }
}
