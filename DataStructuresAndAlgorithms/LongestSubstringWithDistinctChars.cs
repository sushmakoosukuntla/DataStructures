using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    /*Given a string, find length of the longest substring with all distinct characters.  
     * For example, for input "abca", the output is 3 
     * as "abc" is the longest substring with all distinct characters.*/
    class LongestSubstringWithDistinctChars
    {
        public static string SubStringWithDistinctChars(string str)
        {
            if(str == null || str.Length == 1)
            {
                return str;
            }
            int i = 0;
            int j = 0;
            int max = 0;
            HashSet<char> set = new HashSet<char>();
            while(i < str.Length)
            {
                char c = str[i];
                while (set.Contains(c))
                {
                    set.Remove(str[j]);
                    j++;
                }
                set.Add(c);
                max = Math.Max(max, i - j + 1);
                i++;
            }
            return str.Substring(j, max);
        }
    }
}
