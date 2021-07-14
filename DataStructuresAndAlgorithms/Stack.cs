using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    //3.Implement a Stack using 2 queue q1 and q2 .
    public class Stack
    {
        public Queue<int> Queue1 = new Queue<int>();
        public Queue<int> Queue2 = new Queue<int>();


        public void Push(int x)
        {
            if (Queue1.Count != 0)
            {
                Queue1.Enqueue(x);
            }
            else
                Queue2.Enqueue(x);
        
        }

        public int Pop()
        { 
            if(Queue1.Count == 0 && Queue2.Count == 0)
            {
                throw new NotSupportedException("Queues shouldnt be empty");
            }
            int latest = 0;
            while (Queue1.Count != 0)
            {
                latest = Queue1.Dequeue();
                if (Queue1.Count == 0)
                {
                    return latest;
                }
                Queue2.Enqueue(latest);
            } 

            while (Queue2.Count != 0)
            {
                latest = Queue2.Dequeue();
                if (Queue2.Count == 0)
                {
                    return latest;
                }
                Queue1.Enqueue(latest);
            }
            return latest;
            

        }
    }

            
        
    
}

       
            
