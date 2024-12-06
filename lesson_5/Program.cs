using lesson_5.Task1;
using lesson_5.Task2;
using lesson_5.Task3;
using lesson_5.Task4;

namespace lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________________1______________________________________");

            Human builder = new Builder("Vlad", 25, "Builder", "Build everything");
            Human sailor = new Sailor("Mark", 37, "Sailor", "Victory");
            Human pilot = new Pilot("Alice", 30, "Pilot", "Boeng");

            Task1(builder); Console.WriteLine();
            Task1(sailor); Console.WriteLine();
            Task1(pilot); Console.WriteLine();

            Console.WriteLine("______________________________________2______________________________________");

            Passport passport = new Passport("Vlad Plovotar", "Ukraine", "11/04/2024", "11/04/2034", "UA123456");
            ForeignPassport foreignPassport = new ForeignPassport("Anna Koval", "Ukraine", "21/03/2024", "21/03/2034", "FP987654", "UKR", "UKRAINE");

            Task2(passport); Console.WriteLine();
            Task2(foreignPassport); Console.WriteLine();

            Console.WriteLine("______________________________________3______________________________________");

            Animal tiger = new Tiger("Bengal Tiger", "Strong and agile");
            Animal crocodile = new Crocodile("Saltwater crocodile", "Aquatic and powerful");
            Animal kangaroo = new Kangaroo("Macropus genus", "Excellent jumper and pouch carrier");

            Task3(tiger); Console.WriteLine();
            Task3(crocodile); Console.WriteLine();
            Task3(kangaroo); Console.WriteLine();

            Console.WriteLine("______________________________________4______________________________________");

            Figure[] figures = new Figure[]
            {
                new Rectangle(3, 5),
                new Circle(4),
                new RightTriangle(4, 7),
                new Trapezoid(3, 4, 6)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Area: {figure.CalculateArea()}");
                figure.Show();
                Console.WriteLine();
            }
        }

        public static void Task1(Human human)
        {
            human.DisplayInfo();
        }

        public static void Task2(Passport passport)
        {
            passport.DisplayInfo();
        }

        public static void Task3(Animal animal)
        {
            animal.DisplayInfo();
        }
    }
}
