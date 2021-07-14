using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class Leader
    {
        /* 7. Write a program to print all the LEADERS in the array.
         * An element is leader if it is greater than all the elements to its right side.
         * And the rightmost element is always a leader.For example int the array 
         * { 16, 17, 4, 3, 5, 2}, leaders are 17, 5 and 2.*/
        public static void printLeaders(int[] arr,
                      int size)
        {
            bool found = true;
            for (int i = 0; i < size; i++)
            {

                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    Console.Write(arr[i] + " ");
            }
        }

        public static void LeadersInArrayOrderOfN(int[] nums)
        {
            int leader = nums[nums.Length - 1];
            Console.WriteLine(leader);
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (leader < nums[i])
                {
                    leader = nums[i];
                    Console.WriteLine(leader);
                }
            }
        }

    }
}
