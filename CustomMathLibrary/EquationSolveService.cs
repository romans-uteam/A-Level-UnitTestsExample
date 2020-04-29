using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMathLibrary
{
    // Equation 
    public class EquationSolveService : IDisposable
    {
        public int Sum(int a, int b)
        {
            if (a == int.MaxValue || b == int.MaxValue)
                return 0;

            return a + b;
        }

        public double Divide(double a, double b)
        {
            if (b == double.MinValue)
                throw new ArgumentException("b can't be double.MinValue");

            if (b == 0)
            {
                return 0;
            }

            return a / b;
        }

        public void Dispose()
        {
            // we are disposing it
        }

        public int GetRandom(int min = 0, int max = 100)
        {
            return new Random().Next(min, max);
        }
    }
}
