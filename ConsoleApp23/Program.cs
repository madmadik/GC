using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            int generation = GC.GetGeneration(test);
            Console.WriteLine("поколение = " + generation);

            GC.Collect(generation);
            int generation2 = GC.GetGeneration(test);
            Console.WriteLine("поколение = " + generation2);

            Console.ReadLine();
        }
    }
}
