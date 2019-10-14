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
        // This methods takes two input value and calls the selected method
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter two numbers you would like to work with below.");
            Console.Write("Number One: ");
            decimal a = Decimal.Parse(Console.ReadLine());
            Console.Write("Number Two: ");
            decimal b = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Clear();
            Console.WriteLine("You entered {0} and {1}.", a, b);
            Console.WriteLine("");

            Console.WriteLine("Choose which function to run:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("");
            Console.Write("Function: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Console.Clear();
                Console.WriteLine("{0} + {1} = {2}", a, b, Add(a, b));
                Console.WriteLine("");
                Console.WriteLine("Press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else if (result == "2")
            {
                Console.Clear();
                Console.WriteLine("{0} - {1} = {2}", a, b, Subtract(a, b));
                Console.WriteLine("");
                Console.WriteLine("Please press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else if (result == "3")
            {
                Console.Clear();
                Console.WriteLine("{0} * {1} = {2}", a, b, Multiply(a, b));
                Console.WriteLine("");
                Console.WriteLine("Press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else if (result == "4")
            {
                Console.Clear();
                Console.WriteLine("{0} / {1} = {2}", a, b, Divide(a, b));
                Console.WriteLine("");
                Console.WriteLine("Press 'Enter' to end the calculator.");
                Console.ReadLine();
                return false;
            }
            else
            {
                return false;
            }
        }
        // This methods adds two parameters and returns a decimal value
        private static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        // This methods substracts two parameters and returns a decimal value
        private static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }
        // This methods multiplies two parameters and returns a decimal value
        private static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }
        // This methods divides two parameters and returns a decimal value
        private static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
    }
}
