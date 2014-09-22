using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0].StartsWith("/"))
            {
                string sortMethod = args[0].Substring(1, args[0].Length - 1).ToLower();
                switch (sortMethod)
                {
                    case "help":
                        Help();
                        break;
                    case "quicksort":       
                        Sort(Convert.ToInt32(args[1]), sortMethod);
                        break;
                    case "bubblesort":
                        Sort(Convert.ToInt32(args[1]), sortMethod);
                        break;
                    default:
                        // unknown parameter
                        break;
                }
            }
            else
            {
                Help();
            }
        }

        static void Help()
        {
            Console.WriteLine();
            Console.WriteLine("Examples of various sort routines");
            Console.WriteLine();
            Console.ReadLine();
        }

        static int[] RandomArray(int amountNumbers)
        {
            int[] randomNumbers = new int[amountNumbers];
            Random rand = new Random();
            
            for (int count = 0; count < amountNumbers; count++)
            {
                randomNumbers[count] = rand.Next(0, amountNumbers);
            }

            return randomNumbers;
        }


        static void Sort(int amountNumbers,string sortMethod)
        {
            Quicksort quicksort = new Quicksort();
            Bubblesort bubblesort = new Bubblesort();
            int[] sorted = {};

            int[] unsorted = RandomArray(amountNumbers);

            Console.WriteLine("Unsorted");
            Console.WriteLine();

            for (int count = 0; count < unsorted.Count(); count++)
            {
                Console.Write(unsorted[count] + " ");
            }
            Console.WriteLine();

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            switch (sortMethod)
            {
                case "quicksort":
                    sorted = quicksort.Sort(unsorted);
                    break;
                case "bubblesort":
                    sorted = bubblesort.Sort(unsorted);
                    break;
            }
            
            stopWatch.Stop();

            Console.WriteLine();
            Console.WriteLine("Sorted using the " + sortMethod + " algorithm");
            Console.WriteLine();

            for (int count = 0; count < sorted.Count(); count++)
            {
                Console.Write(unsorted[count] + " ");
            }
            Console.WriteLine();

            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine("RunTime " + stopWatch.Elapsed);
            Console.WriteLine();
            Console.WriteLine("Press return to continue");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
