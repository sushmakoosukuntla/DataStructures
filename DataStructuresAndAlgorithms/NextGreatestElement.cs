using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class NextGreatestElement
    {
        /*Given an array, print the Next Greater Element (NGE) for every element. 
         * The Next greater Element for an element x is the first greater element on the right side of x in array. 
         *  Elements for which no greater element exist, consider next greater element as -1.
        Examples:
        a) For any array, rightmost element always has next greater element as -1.
        b) For an array which is sorted in decreasing order, all elements have next greater element as -1.
        c) For the input array[4, 5, 2, 25}, the next greater elements for each element are as follows. 
         Element     NGE
         4      -->   5
         5      -->   25
         2      -->   25
         25     -->   -1

        d) For the input array[13, 7, 6, 12}, the next greater elements for each element are as follows.
        Element        NGE
        13      -->    -1
        7       -->     12
        6       -->     12
        12     -->     -1 */
        public static void NextGreatestElementInArray(int[] nums) // TC - O(n*2) and SC - O(n)
        {
            var found = false;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        Console.WriteLine(nums[i] + " NGE is " + nums[j]);
                        found = true;
                        break;
                    }                 
                }
                if(found == false || i == nums.Length - 1)
                {
                    Console.WriteLine(nums[i] + " NGE is " + -1);
                }
            }
            
        }

        public static void NGE1(int[] array) // TC = O(n) and SC = O(n)
        {
            var s = new Stack<int>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                while(s.Count != 0)
                {
                    if(array[i] < s.Peek())
                    {
                        Console.WriteLine(array[i] + " NGE is" + s.Peek());
                        s.Push(array[i]);
                        break;
                    }
                    else
                    {
                        s.Pop();
                    }                    
                }
                if (s.Count == 0)
                {
                    Console.WriteLine(array[i] + " NGE is -1");
                    s.Push(array[i]); 
                }
            }

        }


    }
}
