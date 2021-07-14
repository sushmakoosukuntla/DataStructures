using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    public class RemoveDuplicatesInArray
    {
        public static void DuplicatesInAnArray(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);

                    Console.WriteLine(arr[i]);
                }
            }
        }
        
        public static int[] DuplicatesInArray1(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] array = new int[arr.Length];
            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);
                    array[count] = arr[i];
                    count += 1;
                }

            }

            return array;
        }
    }

    


}
    
                
                   
           
    


