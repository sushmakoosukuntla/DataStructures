using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class PrimeNumbers
    {
        public static void PrintPrimeNumbers(int n)
        {
            bool isPrime = true;
            Console.WriteLine("prime:" + 1);
            for (int i = 2; i <= n; i++)
            {

                for (int j = 2; j <= n; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("prime:" + i);
                }
                isPrime = true;

            }  
        }
    }
}
