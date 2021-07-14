using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    //2. Implement a Queue using 2 stackss1 and s2 .
    public class Queue
    {
        public Stack<int> Stack1 = new Stack<int>();
        public Stack<int> Stack2 = new Stack<int>();

      
        public void EnQueue(int x)
        {
            Stack1.Push(x);
        }

        public int DeQueue()
        {
            if(Stack1.Count == 0 && Stack2.Count == 0)
            {
                throw new NotSupportedException("DeQueue cannot be performed on empty Stack");
            }
            if(Stack2.Count == 0)
            {
                while(Stack1.Count != 0)
                {
                    Stack2.Push(Stack1.Pop());
                }
            }
            var x = Stack2.Pop();
            return x;   
        } 
    }
}
