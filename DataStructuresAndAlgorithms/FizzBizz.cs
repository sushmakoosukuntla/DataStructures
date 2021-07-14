using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class FizzBizz
    {
        public static void FizzBizzGame(int n)
        {
            if (n > 0)
            {
                for (int i =0; i<= n; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Fizz Bizz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("FIZZ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("BIZZ");
                    }

                    else
                    {
                        Console.WriteLine(i);
                    }

                }

            }
            else
            {
                Console.WriteLine("Please enter a number greater than 0");
            }
        }
    }
}
