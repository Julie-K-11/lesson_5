using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson_5.Task1
{
    public class Sailor : Human
    {
        protected string Job;
        protected string ShipName;

        public Sailor(string name, int age, string job, string shipName) : base(name, age)
        {
            Job = job;
            ShipName = shipName;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{Name} is {Job}.");
            Console.WriteLine($"Ship Name: {ShipName}");
        }
    }
}
