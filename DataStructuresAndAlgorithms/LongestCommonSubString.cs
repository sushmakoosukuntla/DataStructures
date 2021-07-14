using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class LongestCommonSubString
    {
        public static int longestCommonSubstring(char[] str1, char[] str2)
        {
            
            int[,] T = new int[str1.Length + 1 , str2.Length + 1];

            int max = 0;
            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        T[i, j] = T[i - 1, j - 1] + 1;
                        if (max < T[i, j])
                        {
                            max = T[i, j]; 
                        }
                    }
                }
            }
            return max;
        }
    }
}
