using System;

namespace Teste12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            
            

            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);
            Book book3 = new Book();

            Console.WriteLine(book2.title);
           
           

        }
    }
}
