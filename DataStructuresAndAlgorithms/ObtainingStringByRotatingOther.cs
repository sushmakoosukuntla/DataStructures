using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class ObtainingStringByRotatingOther
    {
        public static bool RotationgString(String str1, string str2)
        {
            if (str1.Equals(str2))
            {
                return true;
            }
            else if (str1.Length == 1 && str2.Length == 1)
            {
                return true;
            }
            else if (str1.Length == str2.Length)
            {

                var s = str2.Substring(0, 2);
                var t = str2.Substring(2, str2.Length - 2);
                var s1 = str2.Substring(str2.Length - 2, 2);
                var t1 = str2.Substring(0, str2.Length - 2);
                //clockwise
                if ((t + s).Equals(str1))
                {
                    return true;
                }
                //Anticlockwise
                if ((s1 + t1).Equals(str1))
                {
                    return true;
                }
                return false;

            }
            else
            {
                return false;
            }
        }
        

    }
}
