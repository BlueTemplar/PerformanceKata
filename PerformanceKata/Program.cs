using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorials;
namespace Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();
            var factorials = new Factorials.Factorials();
           
            // Begin timer
            stopWatch.Start();

            var sum = factorials.CalculateSum();

            // End timer
            stopWatch.Stop();

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Elapsed Milliseconds: " + stopWatch.ElapsedMilliseconds);
            Console.ReadKey();
            
        }
    }
}
