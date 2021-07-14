using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class AdjacentDuplicates
    {
        /*Given a string, recursively remove adjacent duplicate characters from string. The output string should not have any adjacent duplicates. 
         * See following examples.
            Input:  azxxzy
            Output: ay
            First "azxxzy" is reduced to "azzy". The string "azzy" contains duplicates, so it is further reduced to "ay". 

            Input: caaabbbaacdddd
            Output: Empty String 

            Input: acaaabbbacdddd
            Output: acac*/
        public static string RemoveAdjacentDuplicates(string a)
        {
            var count = 1;
            var l = 0;
            var r = 1;
            if(a.Length == 1 || a.Length == 0)
            {
                return a;
            }
            if(a.Length == 2 && a[l] != a[r])
            {
                return a;
            }
            while (r< a.Length && a[l] != a[r])
            {
                l++;
                r++;
            }
            if(r == a.Length)
            {
                return a;
            }
            while(r < a.Length && a[l] == a[r])
            {
                r++;
                count++;
            }
            a = a.Remove(l, count);
            return RemoveAdjacentDuplicates(a);
        }
    }
}
