using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementSelectionSortWithArray
{
    public class SelectionSort
    {
        int[] array;

        public SelectionSort(int[] inputArray)
        {
            array = new int[inputArray.Length];
            array = inputArray;
        }

        public void Sort()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The array is empty!");
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[minIndex] > array[j])
                        {
                            minIndex = j;
                        }
                    }

                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public bool IsEmpty()
        {
            if (array.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
