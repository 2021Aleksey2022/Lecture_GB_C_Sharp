using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example001_HelloWorld.Example003_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1, 10);
            Console.WriteLine(numberA);
            int numberB = new Random().Next(0, 20);
            Console.WriteLine(numberB);
            int result = numberA + numberB;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
