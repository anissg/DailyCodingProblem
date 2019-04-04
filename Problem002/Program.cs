using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem002;

namespace Problem002
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            List<int> output = multiply(input);
            Console.WriteLine(output.ToString2());

            input = new List<int> { 3, 2, 1 };
            output = multiply(input);
            Console.WriteLine(output.ToString2());
        }

        static List<int> multiply(List<int> input)
        {
            List<int> output = new List<int>();

            int prod = 1;
            List<int> tmp = new List<int>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                tmp.Add(prod);
                prod *= input[i];
            }
            prod = 1;
            for (int i = 0; i < input.Count; i++)
            {
                output.Add( tmp[input.Count - 1 - i] * prod);
                prod *= input[i];
            }

            return output;
        }
    }

    public static class ListExt
    {
        public static string ToString2(this List<int> list)
        {
            string output = "";
            foreach (int item in list)
            {
                output += item.ToString() + " ";
            }
            return output;
        }
    }
}
