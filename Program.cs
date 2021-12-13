using System;

namespace LB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal n1 = new Animal("Джейран", "А", "Азiя  ", 30000);
            Animal n2 = new Animal("Гну    ", "В", "Африка", 560000);
            Animal n3 = new Animal("Бейза  ", "Н", "Африка", 2500);
            Console.WriteLine("Назва       Група      Житло      Численнiсть популяцiї");
            Console.WriteLine(n1.Details());
            Console.WriteLine(n2.Details());
            Console.WriteLine(n3.Details());
        }
    }

    class Animal
    {
        public string n { get; set; }

        public string g { get; set; }

        public string h { get; set; }

        public double p { get; set; }

        public Animal(Animal previousAnimal)
        {
            n = previousAnimal.n;
            g = previousAnimal.g;
            h = previousAnimal.h;
            p = previousAnimal.p;
        }

        public Animal(string N, string G, string H, double P)
        {
            n = N;
            g = G;
            h = H;
            p = P;
        }

        public string Details()
        {
            return n + "       " + g + "        " + h.ToString() + "              " + p.ToString();
        }
    }
}
