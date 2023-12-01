using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lecture_2.Example001_CycleFor
{
    class CycleFor
    {
        static void Main(string[] args)
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            int[] arr = { 1, 3, 5, -2, 54, 98 };
            int max = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] > max)
                {
                    max = arr[i + 1];
                }
            }            
            Console.WriteLine($"{max}");
            Console.WriteLine(clock.ElapsedMilliseconds);
            clock.Stop();
            Console.ReadLine();
        }
    }
}
