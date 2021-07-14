using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class AttaoiImplementation
    {
       
        public static int atoi(string str)
        {
            
            int result = 0;   
            int i = 0;    
            int sign = 1;   //Check the sign of string (+ or -)
            if(str[i] == '-')
            {
                sign = -1;
                i++;
            }
            //Now traverse the entire string and convert it into integer
            while (i < str.Length)
            {
                //If any character is not an integer then just return -1
                if (!(str[i] - '0' >= 0 && str[i] - '0' <= 9))
                    return -1;
                //else just keep updating the result
                result = result * 10 + str[i] - '0';
                i++;
            }
            return result * sign;
        }
    }
}
