using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Helper
    {

        //OptimizedBubbleSort
        public static void OptimizedBubbleSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                         
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}
