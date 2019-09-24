using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace are_they_same
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            comp(a, b);
        }

        static bool comp(int[] a, int[] b)
        {
            // your code
            if (a.Length > 0 && b.Length > 0)
            {
                int[] values = Array.ConvertAll(b, x => Convert.ToInt32(Math.Sqrt(x)));

                // bool equal = a.SequenceEqual(values);
                HashSet<int> int1 = new HashSet<int>(a);
                HashSet<int> int2 = new HashSet<int>(values);
                bool equal = int1.SetEquals(int2);
                WriteLine(equal);

                return equal;

            }
            else
            {
                return false;
            }

        }
    }
