using System.Drawing;

namespace MethodsExercise
{
     
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Minus(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Mod(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var something = Multiply(60, 2, 4);
            var divide = Divide(144, 12);
            var Subtract = Minus(9, 3);
            var Modulus = Mod(5, 2);

            // --------------Exercise 1--------------
            //Name: Kendall
            //Your Favorite Color
            //Your Favorite Animal
            //Your Favorite Band

            Console.WriteLine("Hello, What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}, What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"Wow,{color} is a beautiful color. Will you tell me your favorite animal as well?");
            var animal = Console.ReadLine();

            Console.WriteLine("Can you also tell me your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}, please see your profile below!");
            Console.WriteLine("=======================");

            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"favorite Band: {band}");

            // --------------Exercise 2--------------


        }
    }
}
