using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    public class Node
    {
        public int Key;
        public int Value;
        public Node Previous;
        public Node Next;

        public Node(int key, int value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
