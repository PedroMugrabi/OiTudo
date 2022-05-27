using System;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            SayHi("Pedro Mugrabi", 21);
            string color, pluralNoun, celebrity;

            Console.WriteLine("Enter a color");
            color = Console.ReadLine();
            Console.WriteLine("Enter a plural noun");
            pluralNoun = Console.ReadLine();
            Console.WriteLine("Enter a celebrity");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();

        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ". You are "+age+" years old");
        }
    }
}
