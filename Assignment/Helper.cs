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




        // Range<T> Class
        public class Range<T> where T : IComparable<T>
        {
            public T Minimum { get; }
            public T Maximum { get; }

            public Range(T minimum, T maximum)
            {
                if (minimum.CompareTo(maximum) > 0)
                {
                    throw new ArgumentException("Minimum value cannot be greater than maximum value.");
                }

                Minimum = minimum;
                Maximum = maximum;
            }

            public bool IsInRange(T value)
            {
                return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
            }

            public dynamic Length()
            {
                if (typeof(T) == typeof(int))
                {
                    return (int)(object)Maximum - (int)(object)Minimum;
                }
                else if (typeof(T) == typeof(double))
                {
                    return (double)(object)Maximum - (double)(object)Minimum;
                }
                else if (typeof(T) == typeof(decimal))
                {
                    return (decimal)(object)Maximum - (decimal)(object)Minimum;
                }
                else
                {
                    throw new NotSupportedException("Length calculation is not supported for the given type.");
                }
            }
        }
    }
}
