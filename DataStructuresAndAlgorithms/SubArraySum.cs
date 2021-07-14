using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class SubArraySum
    {
        /*3.  
           Examples :

           Input: arr[] = {1, 4, 20, 3, 10, 5}, sum = 33
           Ouptut: Sum found between indexes 2 and 4

           Input: arr[] = {1, 4, 0, 0, 3, 10, 5}, sum = 7
           Ouptut: Sum found between indexes 1 and 4

           Input: arr[] = {1, 4}, sum = 0 
           Output: No subarray found*/
        public static void SubarraySum(int[] nums, int sum)
        {
            int sI = 0;
            int eI = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int esum = nums[i];
                if (esum == sum)
                {
                    sI = i;
                    for (int j = i + 1; j < nums.Length; j++)
                    {

                        if (nums[j] == 0)
                        {
                            eI = j;
                        }
                        else
                        {
                            if (eI == 0)
                            {
                                Console.WriteLine("Sum found at index : " + sI);
                            }
                            Console.WriteLine("Sum found at Index :" + sI + "and" + eI);
                        }
                    }
                }
                for (int k = i + 1; k < nums.Length; k++)
                {
                    esum += nums[k];
                    if (esum == sum)
                    {
                        sI = i;
                        eI = k;
                        for (int l = k + 1; l < nums.Length; l++)
                        {
                            if (nums[l] == 0)
                            {
                                eI = l;
                            }
                            else
                            {
                                if (eI == 0)
                                {
                                    Console.WriteLine("Sum found at index : " + sI);
                                }
                                Console.WriteLine("Sum found between Index " + sI + " and " + eI);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void OrderOfNSubarraySum(int[] nums, int sum)
        {
            bool found = false;
            int cs = 0;
            int head = 0;
            int tail = 0;
            if (sum == 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == sum)
                    {
                        Console.WriteLine("Sum found at Index: " + i);
                        found = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    cs += nums[i];
                    tail++;
                    while (cs > sum)
                    {
                        cs -= nums[head];
                        head++;
                    }
                    if (cs == sum)
                    {
                        found = true;
                        Console.WriteLine("Sum found between " + head + " and " + (tail - 1) + " Indexes");
                        break;
                    }
                }
            }
            if (found == false)
            {
                Console.WriteLine("SunArray of " + sum + " not found");
            }
        }
    }
}
