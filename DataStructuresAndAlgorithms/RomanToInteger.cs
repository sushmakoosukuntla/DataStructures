using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class RomanToInteger
    {
        public static int getValue(char ch)
        {
           switch (ch)
            {
                case  'I':
                    return 1;
                case  'V':
                    return 5;
                case  'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
            }
            return -1;
            
           
                
        }
        public static int RomanToIntegerConversion(string str)
        {
            int sum = 0;
            int count = 1;
            for(int i = 0; i < str.Length; i++)
            {
                var s1 = getValue(str[i]);
                if(s1 == -1)
                {
                    return -1;
                }
                if(i + 1 < str.Length)
                {
                    var s2 = getValue(str[i + 1]);
                    if(s2 == -1)
                    {
                        return -1;
                    }
                    if (s1 > s2)
                    {
                        sum += s1;
                        count = 0;
                    }
                    else if (s1 < s2) 
                    {
                        sum -= s1;
                        count = 0;
                    }
                    else
                    {
                        sum += s1;
                        count += 1;
                        if(count > 3)
                        {
                            Console.WriteLine("Invalid string");
                        }
                    }                                                         
                }
                else
                {
                    sum += s1;                   
                }               
            }
            return sum;
        }
    }
}
