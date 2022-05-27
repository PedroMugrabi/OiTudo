using System;

namespace Teste14
{
     class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrej = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(avengers.Rating);


        }
    }
}
