using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class MajorityElementInArray
    {
        /*Given an array nums of size n, return t he majority element.
        The majority element is the element that appears more than ⌊n  / 2⌋ times. You may assume that the majority element 
        always exists in the array.
        Input: nums = [3,2,3]
        Output: 3

        Input: nums = [2,2,1,1,1,2,2]   
        Output: 2 */

        public static void Majorityelementcount(int[] nums)
        {
            //[2,2,1,1,1,2,2]
            var length = nums.Length;
            var d = new Dictionary<int, int>();
            for (int i = 0; i < length; i++)
            {
                if (d.ContainsKey(nums[i]))
                {
                    //in below line we are incrementing d[nums[i]] value
                    int x = d[nums[i]] + 1;
                    if (x > nums.Length / 2)
                    {
                        Console.WriteLine("Majority times repeated number is " + nums[i]);
                        return;
                    }
                    else
                    {
                        //updating the map
                        d[nums[i]] = x;
                    }
                }
                else
                {
                    d[nums[i]] = 1;
                }
            }
            Console.WriteLine(" No Majority repeated element found");
        }
    }
}
