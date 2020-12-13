using System;

namespace WhoIsYourFather
{
    class Lebron
    {
        public string firstName = "Lebron";
        public string lastName = "James";
    }
    class Kobe
    {
        public string firstName = "Kobe";
        public string lastName = "Bryant";
    }
    class Bronny : Lebron
    {
        public new string firstName = "Bronny";
    }
    class Bryce : Lebron
    {
        public new string firstName = "Bryce";
    }
    class Gianna : Kobe
    {
        public new string firstName = "Gianna";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<Who's your father?>");
            Console.WriteLine("What's your name?");
            Console.WriteLine("1> Bronny");
            Console.WriteLine("2> Brynce");
            Console.WriteLine("3> Gianna");
            Console.Write("Please input your first name: ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Bronny bronny = new Bronny();
                    Console.WriteLine("Your last name is {0}", bronny.lastName);
                    break;
                case "2":
                    Bryce bryce = new Bryce();
                    Console.WriteLine("Your last name is {0}", bryce.lastName);
                    break;
                case "3":
                    Gianna gianna = new Gianna();
                    Console.WriteLine("Your last name is {0}", gianna.lastName);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
