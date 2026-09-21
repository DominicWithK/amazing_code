using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();

            //Dominik
            int mult;
            Console.Write("Multiplication tables: Insert a number to see multiples: ");
            mult = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[20];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = (i + 1) * mult;
                Console.WriteLine($"{i + 1} x {mult} = {num[i]}");
            }
            Console.ReadLine();












            //Oliver

            int age, days, hours;
            string temp;

            Console.WriteLine("How many years old are you?");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);
            days = age * 365;
            hours = days * 24;
            Console.WriteLine("You have lived for at least " + days + " days and " + hours + " hours");
            Console.ReadLine();














            //John































        }
    }
}
