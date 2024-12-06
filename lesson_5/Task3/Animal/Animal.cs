using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5.Task3
{
    public class Animal
    {
        protected string Name;
        protected string Characteristic;

        public Animal(string name, string characteristic)
        {
            Name = name;
            Characteristic = characteristic;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Animal: {Name}");
            Console.WriteLine($"Characteristic :{Characteristic}.");
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
}
