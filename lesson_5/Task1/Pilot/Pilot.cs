using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson_5.Task1
{
    public class Pilot : Human
    {
        protected string Job;
        protected string PlaneName;
        public Pilot(string name, int age, string job, string planeName) : base(name, age)
        {
            Job = job;
            PlaneName = planeName;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{Name} is {Job}.");
            Console.WriteLine($"Plane: {PlaneName}");
        }
    }
}
