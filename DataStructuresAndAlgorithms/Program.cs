using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresAssignment
{
    class Program
    {
        //int[] array = new int[] { 4, 5, 2, 25 };
        //int equilibriumIndex = EquilibriumIndex(array, array.Length);
        //subArraySum(array, 6, -10);
        //Console.WriteLine(equilibriumIndex);
        //ReturnKthSmallestNum(array, 2);
        //var sortedArray = SortingBasedOnIndexAndFrequesncy(array);
        //foreach (var item in sortedArray)
        //{
        //    Console.Write(item.ToString() + " , ");
        //}
        //NextGreatestElement.NGE1(array);
        //var s = new Stack();
        //s.Push(1);
        //s.Push(2);
        //s.Push(3);
        //Console.WriteLine(s.Pop());
        //s.Push(4);         
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.Pop());
        //Console.WriteLine(s.Pop());
        static void Main(string[] args)
        {
            //LRUCache cache = new LRUCache(2);
            //cache.Set(1, 10);
            //cache.Set(2, 20);
            //cache.Set(3, 30);
            //cache.Get(1);
            //cache.Get(3);

            //char[] c = new char[]  { 'a', 'b', 'c', 'b', 'b', 'a', 'c', 'd' };
            //var result = FirstNonRepeatingChar.NonRepeatingChar(c);
            //Console.WriteLine(result);
            int[] arr = { 5, 3, 2, 1, 5, 3, 2, 8, 5 };
            //int middIndex = arr.Length / 2;
            //Console.WriteLine(arr[middIndex]);
            /*var pal = LongestPalindromeInString.LongestPalindrome("babad");
            foreach (char items in pal)
            Console.WriteLine(items);*/

            //FizzBizz.FizzBizzGame(100);
            /*var a = RemoveDuplicatesInArray.DuplicatesInArray1(arr);
            for(int i =0; i<= a.Length; i++)
            {
                if (a[i] == 0)
                    break;
                else
                {
                    Console.WriteLine(a[i]);
                }
            }*/
            //compositeNumbers.PrintCompositeNumbers(15);
            //PrimeNumbers.PrintPrimeNumbers(10);
            var a = "amazon";
            var b = "zaomna";
            /*var d = AdjacentDuplicates.RemoveAdjacentDuplicates(a);
            //a.Remove(2);
            if (d.Length == 0)
            {
                Console.WriteLine("empty ");
            }
            Console.WriteLine(d);  */
            /*var t = ObtainingStringByRotatingOther.RotationgString(a, b);
            {
                if (t == true)
                {
                    Console.WriteLine(a + " can be obtained by rotating " + b);
                }
                else
                {
                    Console.WriteLine(a +" cannot be obtained by rotating " + b);
                }
            }*/
            /*var val =RomanToInteger.RomanToIntegerConversion("XIVk");
            if (val == -1)
            {
                Console.WriteLine("Invalid Roman");
            }
            Console.WriteLine(val);*/

            /*var max = LongestCommonSubString.longestCommonSubstring(new char[]{ 'a', 'b', 'c', 'd', 'x', 'y', 'z' } , new char[]{ 'x', 'y', 'z', 'a', 'b', 'c', 'd'});
             Console.WriteLine(max);*/
            var str = "1234";
            /*var s = LongestSubstringWithDistinctChars.SubStringWithDistinctChars(str);
            Console.WriteLine(s);*/

            /*var s = AttaoiImplementation.ImplementingAttoi(str);
            Console.WriteLine(s); */
            string[] input = {"geeksforgeeks", "geeks","geek", "geezer"};
            var k = LongestCommonPrefix.longestCommonPrefix(input);
            Console.WriteLine(k); 


        }   
    }
}
