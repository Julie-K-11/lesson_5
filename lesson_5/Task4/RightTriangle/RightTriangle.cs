using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task4
{
    public class RightTriangle : Figure
    {
        protected double Base;
        protected double Height;

        public RightTriangle(double b, double height)
        {
            Base = b;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override void Show()
        {
            for (int i = 1; i <= (int)Height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
