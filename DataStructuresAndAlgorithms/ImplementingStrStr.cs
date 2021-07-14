using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class ImplementingStrStr
    {
        /*Your task  is to implement the function strstr. The function takes two strings as arguments(s,x) 
         * and  locates the occurrence of the string x in the string s. The function returns and integer 
         * denoting  the first occurrence of the string*/
        public static int StrStr(string s , string x)
        {
            int index = 0;
            for(int i =0; i<s.Length; i++)
            {
                if(s[i] == x[0])
                {
                    index = i;
                    for(int j = 0; j<x.Length; j++)
                    {
                        if(s[i] == x[j])
                        {
                            i++;
                        }                        
                    } 
                    return index;
                }
            }
            return -1;
        }
    }
}
