using System.Drawing;

namespace MethodsExercise
{
    public class Program
       
    {
        static void Main(string[] args)
        {
            
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


        }
    }
}
