using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class LongestCommonPrefix
    {
        /*Given a array of Nstrings, find the longest common prefix among all strings present in the array.
         Input: apple ape April
         Output: ap*/

        public static string longestCommonPrefix(String[] str)
        {
            int length = str.Length;
            if (length == 0)
                return "";
            if (length == 1)
                return str[0];

            /* sort the array of strings */
            Array.Sort(str);

            /* find the minimum length from first
            and last string */
            int min = Math.Min(str[0].Length,
                                str[length - 1].Length);

            /* find the common prefix between the
            first and last string */
            int i = 0;
            while (i < min && str[0][i] == str[length - 1][i])
                i++;

            string pre = str[0].Substring(0, i);
            return pre;
        }
    }
}
