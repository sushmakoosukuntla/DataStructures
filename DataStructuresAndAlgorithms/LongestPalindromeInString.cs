using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    /*Given a string S, find the longest palindromic substring in S.
        Input: "babad"
        Output: "bab"
        Note: "aba" is also a valid answer.*/
    class LongestPalindromeInString
    {
        public static void LongestPalindrome1(String s)
        {
            bool palindrome = false;
            string longestPal = s[0].ToString();
            for(int i = 0; i<s.Length; i++)
            {
                string current = s[i].ToString();
                for(int j = i+1; j< s.Length; j++)
                {
                    current += s[j].ToString();
                    palindrome = IsAPalindrome1(current);
                    if (palindrome == true && current.Length > longestPal.Length)
                    {
                        longestPal = current;
                    }
                }

            }
            Console.WriteLine(longestPal);                          
        } 
        public static bool IsAPalindrome1(string p)
        {
            int i = 0;
            int j = p.Length - 1;
            for (int k = 0; k < p.Length / 2; k++)
            {
                if (p[i] == p[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static int resultStart;
        static  int resultLength = 0;
        public static string LongestPalindrome(string s)
        {
            int length = s.Length;
            if(length < 2)
            {
                return s;
            }
            for(int i =0; i <s.Length; i++)
            {
                IsPalindrome(s, i, i);
                IsPalindrome(s, i, i + 1);
            }
            return s.Substring(resultStart, resultLength + resultStart);
        }

        private static void IsPalindrome(string s, int start, int end)
        {
            while(start >=0 && end < s.Length && s[start] == s[end])
            {
                start--;
                end++;
            } 
            if(resultLength < end - start - 1)
            {
                resultStart = start + 1;
                 resultLength = end - start - 1;
            }
        }
    }
}
