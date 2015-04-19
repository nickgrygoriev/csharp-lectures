using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class ArrayExtend
    {
        public static void IncreaseSort(this int[] array)
        {
            for (int i = array.Length - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j+1] = tmp;
                    }
                }
            }
        }
    }
}
