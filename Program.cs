namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();

            //Dominik






















            //Oliver

























            //John
            char startingLetter, endLetter;
            Console.Write("Enter a starting letter: ");
            startingLetter = char.Parse(Console.ReadLine());
            Console.Write("Enter a stopping letter: ");
            endLetter = char.Parse(Console.ReadLine());
            for (char round = startingLetter; round <= endLetter; round++)
            {
                for (char control = startingLetter; control <= round; control++)
                {
                    Console.Write($"{control}");
                }
                Console.WriteLine();
            }



















        }
    }
}
