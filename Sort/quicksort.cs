using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    /// <summary>
    /// A version of Quicksort sourced from Introduction to Algorithms (Third Edition)
    /// chapter 7.1 Description of quicksort, page 171.
    /// </summary>
    class Quicksort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public int[] Sort(int[] elements)
        {
            Quick_Sort(elements, 0, elements.Count() - 1);
            return elements;
        }

        private void Quick_Sort(int[] elements, int left, int right)
        {
            int partition;
            if (left < right)
            {
                partition = Partition(elements, left, right);
                Quick_Sort(elements, left, partition - 1);
                Quick_Sort(elements, partition + 1, right);
            }
        }

        private int Partition(int[] elements, int left, int right)
        {
            int pivot = elements[right];
            int index = left - 1;
            // The book suggests using: for (int count = left; count < right - 1; count++)
            // but this produces an incomplete sort.
            for (int count = left; count < right; count++)
            {
                if (elements[count] < pivot)
                {
                    index++;
                    Swap(elements, index, count);
                }
            }
            Swap(elements, index + 1, right);
            return index + 1;
        }

        private void Swap(int[] elements, int left, int right)
        { 
            int temp = elements[left];
            elements[left] = elements[right];
            elements[right] = temp;
        }
    }
}
