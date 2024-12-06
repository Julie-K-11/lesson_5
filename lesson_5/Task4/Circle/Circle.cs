using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task4
{
    public class Circle : Figure
    {
        protected double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Show()
        {
            Console.Write(
            "   *   \n" +
            " *   * \n" +
            "*     *\n" +
            "*     *\n" +
            "*     *\n" +
            " *   * \n" +
            "   *   \n");
        }
    }
}
