using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace DataStructuresAssignment
{
    public class FirstNonRepeatingChar
    {
        /*Given an input stream of n characters consisting only of small case alphabets the task is to find the first non repeating 
         * character each time a character is inserted to the stream. If no non repeating element is found print -1.
        Example
        Flow in stream : a, a, b, c
        a goes to stream : 1st non repeating element a (a)
        a goes to stream : no non repeating element -1 (a, a)
        b goes to stream : 1st non repeating element is b (a, a, b)
        c goes to stream : 1st non repeating element is b (a, a, b, c)*/
        public static void NonRepeatingChar(char[] chars)
        {
            LinkedList<char> list = new LinkedList<char>();
            Dictionary<char, LinkedListNode<char>> dict = new Dictionary<char, LinkedListNode<char>>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (!dict.ContainsKey(chars[i]))
                {
                    LinkedListNode<char> node = new LinkedListNode<char>(chars[i]);
                    dict.Add(chars[i], node);
                    list.AddLast(node);
                }
                else
                {
                    list.Remove(dict[chars[i]]);

                }
                if(list.Count == 0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(list.First.Value);
                }

            }
        }

        
    }
}
