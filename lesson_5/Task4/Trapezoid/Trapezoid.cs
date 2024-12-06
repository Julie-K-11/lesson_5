using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task4
{
    public class Trapezoid : Figure
    {
        protected double Base1;
        protected double Base2;
        protected double Height;

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public override void Show()
        {
            Console.Write(
            "   *  *  * \n" +
            "  *       *\n" +
            " *         * \n" +
            "* * * * * * * \n");
        }
    }
}
