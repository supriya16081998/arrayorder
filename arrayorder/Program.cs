using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayorder
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted Array in Ascending Order:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Reverse(arr);
            Console.WriteLine("Sorted Array in Descending Order:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();

        }
    }
}
