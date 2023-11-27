using System;
using System.Diagnostics;
using System.Threading.Tasks;
using PrintClass;
using Shift;
using Calculate;
using System.Linq;

class Program
{
    static void Main()
    {
        int size = 100000;
        int[] vector = new int[size];
        for (int i = 0; i < size; i++)
        {
            vector.SetValue(i, i);
        }

        int shiftPositions = 50000;
        CalculateTime calculateTime = new CalculateTime();

        var singleThreadedStopwatch = new Stopwatch();
        singleThreadedStopwatch.Start();
        VectorShift.ShiftLeft(vector, shiftPositions);
        singleThreadedStopwatch.Stop();
        Console.WriteLine($"\nРезультат 1 потока: {singleThreadedStopwatch.ElapsedTicks} мс");

        for (int i = 2; i < 5; i++)
        {
            var threadedStopwatch = new Stopwatch();
            threadedStopwatch.Start();
            VectorShift.ShiftLeftParallel(vector.ToArray(), shiftPositions, i);
            threadedStopwatch.Stop();
            Console.WriteLine($"\nРезультат {i} потокiв: {threadedStopwatch.ElapsedTicks} мс");
            calculateTime.CalculateAndPrintSpeedup(singleThreadedStopwatch.ElapsedTicks, threadedStopwatch.ElapsedTicks);
        }


    }
}
