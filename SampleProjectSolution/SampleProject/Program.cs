using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("another line");
            Class1 c = new Class1();
            c.First();
            Class2 c1 = new Class2();
            c1.Second();
            Console.ReadKey();
        }
    }
}
