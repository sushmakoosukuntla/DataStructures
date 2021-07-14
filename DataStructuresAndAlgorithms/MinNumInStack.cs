using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    // 4.Implement a Stack in which you can get min element in O(1) time and O(1) space.
    public class MinNumInStack
    {        
        int min = 0;
        Stack<int> MinStack;

        public MinNumInStack()
        {
            MinStack = new Stack<int>();
        }

        public void Push(int x)
        {
            if(MinStack.Count == 0)
            {
                MinStack.Push(0);
                min = x;
            }
            else
            {
                //Storing the difference between current value(x) and min
                //If the popped value is less than zero, it means it is minimum for the stack at that point.
                MinStack.Push(x - min);
                if (x < min)
                    min = x;
            }
        }

        public int Pop()
        {
            int pop = MinStack.Pop();
            //If the popped value is less than zero, it means it is minimum for the stack at that point.
            if (pop < 0)
            {
                int hold = min;
                min = min - pop; 
                return hold;
            }
            //Returning the original element by adding min back
            return min + pop;
        }

        public int GetMin()
        {
            return min;
        }
    }
}
