using System;

namespace Day1_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter text:");
            Console.WriteLine(Console.ReadLine());

            Console.WriteLine("Please enter a number:");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine($"{++ num}");

            Console.WriteLine("Please enter another number:");
            double dec = double.Parse(Console.ReadLine());
            Console.WriteLine($"{dec +.5}");

            Console.WriteLine("Lets add two numbers, what is your first number?");
            double firstAdd = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your second number?");
            double secondAdd = double.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {firstAdd} and {secondAdd} is {firstAdd + secondAdd}.");

            Console.WriteLine("Now lets multiply two numbers! Please enter your first number:");
            double firstMult = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your second number?");
            double secondMult = double.Parse(Console.ReadLine());
            Console.WriteLine($"The product of {firstMult} and {secondMult} is {firstMult * secondMult}.");

            Console.WriteLine("Thank you for playing!");
        }
    }
}
