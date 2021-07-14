using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class SpiralForm2DArray
    {
        /* 9. Given a 2D array, print it in spiral form. See the following examples.
         Examples:

        Input:
        1    2   3   4
        5    6   7   8
        9   10  11  12
        13  14  15  16
        Output:
        1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10 */

        public static void PrintInSpiralForm(int[,] arr)
        {
            int rS = 0; //rowstart
            int cS = 0; //columnstart
            int rE = arr.GetLength(0) - 1; //rowend
            int cE = arr.GetLength(1) - 1; //columnend
            while (rS < rE && cS < cE)
            {
                for (int i = cS; i <= cE; i++)
                {
                    Console.Write(arr[rS, i] + " , ");
                }

                for (int i = rS + 1; i <= rE; i++)
                {
                    Console.Write(arr[i, cE] + " , ");
                }
                for (int i = cE - 1; i >= cS; i--)
                {
                    Console.Write(arr[rE, i] + " , ");
                }
                for (int i = rE - 1; i > rS; i--)
                {
                    Console.Write(arr[i, cS] + " , ");
                }
                rS++;
                cS++;
                rE--;
                cE--;
            }
        }
    }
}
