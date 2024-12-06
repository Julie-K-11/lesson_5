using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task3
{
    public class Kangaroo : Animal
    {
        public Kangaroo(string name, string characteristic) : base(name, characteristic) { }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Chortle");
        }
    }

}
