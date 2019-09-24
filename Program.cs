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
            // int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] a = new int[] { 2, 2, 3 };
            int[] b = new int[] { 4, 9, 9 };

            // int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            comp(a, b);
        }

        static bool comp(int[] a, int[] b)
        {
            // your code

            if ((a == null) || (b == null))
            {
                return false;
            }

            int[] copy = a.Select(x => x * x).ToArray();
            Array.Sort(copy);
            Array.Sort(b);
            return copy.SequenceEqual(b);
        }

        }
    }
