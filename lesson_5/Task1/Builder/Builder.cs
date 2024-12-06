using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task1
{
    public class Builder : Human
    {
        protected string Job;
        protected string CompanyName;

        public Builder(string name, int age, string job, string companyName) : base(name, age)
        {
            Job = job;
            CompanyName = companyName;
            CompanyName = companyName;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{Name} is {Job}.");
            Console.WriteLine($"Company name: {CompanyName}");
        }
    }
}
