using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(Class1.matrix(a));
        }
    }
}
