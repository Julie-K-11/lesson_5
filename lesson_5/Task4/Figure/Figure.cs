using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson_5.Task4
{
    public abstract class Figure
    {
        protected double Size;

        public abstract void Show();

        public abstract double CalculateArea();
    }
}
