using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomMathLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var equationService = new EquationSolveService();

            Console.Write("a = ");
            var aString = Console.ReadLine();

            int a = int.Parse(aString);

            Console.Write("b = ");
            var bString = Console.ReadLine();

            int b = int.Parse(bString);

            var sum = equationService.Sum(a, b);

            Console.WriteLine("a + b = {0}", sum);

            Console.ReadKey();
        }
    }
}
