using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class CalculateTime
    {
        public void CalculateAndPrintSpeedup(long singleThreadedTime, long multiThreadedTime)
        {
            double speedup = (double)singleThreadedTime / multiThreadedTime;
            Console.WriteLine($"\nПрискорення: {speedup:F2} раза");
        }
    }
}
