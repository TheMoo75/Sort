using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /// <summary>
    /// 
    /// </summary>
    class Bubblesort
    {
        /// <summary>
        /// A version of Bubblesort sourced from http://en.wikipedia.org/wiki/Bubble_sort#Pseudocode_implementation
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public int[] Sort(int[] elements)
        {
            Bubble_Sort(elements);
            return elements;
        }

        private void Bubble_Sort(int[] elements)
        {
            bool swapped;

            do
            {
                swapped = false;
                for (int count = 1; count < elements.Count(); count++)
                {
                    if (elements[count - 1] > elements[count])
                    {
                        int temp = elements[count - 1];
                        elements[count - 1] = elements[count];
                        elements[count] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
