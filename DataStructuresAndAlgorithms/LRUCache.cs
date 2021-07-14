using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    class LRUCache
    {
        private Dictionary<int, Node> map;
        private int capacity, count;
        private Node head, tail;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            map = new Dictionary<int, Node>();
            head = new Node(0, 0);
            tail = new Node(0, 0);
            head.Next = tail;
            tail.Previous = head;
            head.Previous = null;
            tail.Next = null;
            count = 0;
        }

        public void DeleteNode(Node node)
        {
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
        }

        public void AddToHead(Node node)
        {
            node.Next = head.Next;
            node.Next.Previous = node;
            node.Previous = head;
            head.Next = node;
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
            {
                Node node = map[key];
                int result = node.Value;
                DeleteNode(node);
                AddToHead(node);
                Console.WriteLine("Got the value : " + result + " for the key: " + key);
                return result;
                               
            }
            Console.WriteLine("Did not get any value"  + " for the key: " + key);
            return -1;
        }

        public void Set(int key, int value)
        {
            if(!map.ContainsKey(key))
            {
                Node node = new Node(key, value);
                map.Add(key, node);
                if (count < capacity)
                {
                    count++;
                    AddToHead(node);
                }
                else
                {
                    map.Remove(tail.Previous.Key);
                    DeleteNode(tail.Previous);
                    AddToHead(node);
                }
            }
            else
            {
                Node node = map[key];
                node.Value = value;
                DeleteNode(node);
                AddToHead(node);
            }
        }
    }
}
