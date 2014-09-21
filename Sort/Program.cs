using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Quicksort quicksort = new Quicksort(); 

            int[] unsorted = {5, 3, 1, 2, 10, 7, 6, 4, 9, 8};

            Console.WriteLine("Unsorted");
            Console.WriteLine();

            for (int count = 0; count < unsorted.Count(); count++)
            {
                Console.WriteLine(unsorted[count]);
            }

            int[] sorted = quicksort.Sort(unsorted);

            Console.WriteLine();
            Console.WriteLine("Sorted");
            Console.WriteLine();

            for (int count = 0; count < sorted.Count(); count++)
            {
                Console.WriteLine(unsorted[count]);
            }
            Console.ReadLine();
        }
    }
}