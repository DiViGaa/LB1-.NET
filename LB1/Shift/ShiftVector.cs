using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shift
{
    public class VectorShift
    {
        public static void ShiftLeft(int[] array, int positions)
        {
            int length = array.Length;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                int newPosition = (i - positions + length) % length;
                result[newPosition] = array[i];
            }
        }

        public static void ShiftLeftParallel(int[] array, int positions, int numThreads)
        {
            int length = array.Length;
            int[] result = new int[length];

            Parallel.For(numThreads, length, i =>
            {
                int newPosition = (i - positions + length) % length;
                result[newPosition] = array[i];
            });
        }
    }
}
