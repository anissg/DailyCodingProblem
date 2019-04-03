using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 10, 15, 3, 7 };
            int k = 17;

            Console.WriteLine(UpToK(input, k));

            input = new int[] { 5, 12, 33, 2, 11, 48, 15, 3, 9 };
            k = 22;

            Console.WriteLine(UpToK(input, k));
        }

        private static bool UpToK(int[] input, int k)
        {
            HashSet<int> rest = new HashSet<int>();
            foreach (int n in input)
            {
                if (rest.Contains(k - n))
                    return true;
                rest.Add(n);
            }
            return false;
        }
    }
}
