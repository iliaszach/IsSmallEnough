using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSmallEnough
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallEnough(new int[] { 101, 45, 75, 105, 99, 107 }, 107));
        }

        public static bool SmallEnough1(int[] a, int limit)
        {
            return Array.TrueForAll(a, x => x <= limit);
        }
        public static bool SmallEnough(int[] a, int limit)
        {
            bool valid = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }   

}
