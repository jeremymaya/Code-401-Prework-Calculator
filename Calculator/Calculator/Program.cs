using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");
            Console.WriteLine("");
            Console.Write("Choose an option: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Add();
                return true;
            }
            else if (result == "2")
            {
                Subtract();
                return true;
            }
            else if (result == "3")
            {
                Multiply();
                return true;
            }
            else if (result == "4")
            {
                Divide();
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void Add()
        {
            Console.Clear();
            Console.WriteLine("To add numbers, please enter two numbers below.");
            Console.WriteLine("");
            Console.Write("number a: ");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("number b: ");
            decimal b = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.ReadLine();
        }
        private static void Subtract()
        {
            Console.Clear();
            Console.WriteLine("To subtract numbers, please enter two numbers below.");
            Console.WriteLine("");
            Console.Write("number a: ");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("number b: ");
            decimal b = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.ReadLine();
        }
        private static void Multiply()
        {
            Console.Clear();
            Console.WriteLine("To multiply numbers, please enter two numbers below.");
            Console.WriteLine("");
            Console.Write("number a: ");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("number b: ");
            decimal b = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.ReadLine();
        }
        private static void Divide()
        {
            Console.Clear();
            Console.WriteLine("To divide numbers, please enter two numbers below.");
            Console.WriteLine("");
            Console.Write("number a: ");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("number b: ");
            decimal b = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.ReadLine();
        }
    }
}
