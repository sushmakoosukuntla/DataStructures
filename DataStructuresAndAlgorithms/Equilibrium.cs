using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class Equilibrium
    {
        /* 6. Equilibrium index of an array is an index such that the sum of elements at 
         * lower indexes is equal to the sum of elements at higher indexes. For example, in an array A: 
         Example :
            Input : A[] = {-7, 1, 5, 2, -4, 3, 0}
            Output : 3
            3 is an equilibrium index, because:
            A[0] + A[1] + A[2]  =  A[4] + A[5] + A[6]
        Write a function int equilibrium(int[] arr, int n); that given a sequence arr[] of size n, 
        returns an equilibrium index (if any) or -1 if no equilibrium indexes exist.*/

        public static int EquilibriumIndex(int[] nums, int n)
        {
            int eqI = 1;
            int ls = nums[0];
            int rs = 0;
            for (int i = 2; i < n; i++)
            {
                rs += nums[i];
            }
            for (int i = 1; i < n - 2; i++)
            {
                if (ls == rs)
                {
                    return eqI;
                }
                else
                {
                    ls += nums[eqI];
                    eqI++;
                    rs -= nums[eqI];
                }
            }
            return -1;
        }
    }
}
