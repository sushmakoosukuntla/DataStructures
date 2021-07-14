using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class compositeNumbers
    {
        public static void PrintCompositeNumbers(int n)
        {
            bool isComposite = false;
            for (int i = 3; i <= n; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isComposite = true;
                        break;
                    }
                }
                if (isComposite)
                {
                    Console.WriteLine("composite:" + i);
                }
                isComposite = false;
            }
        }
    }
}
