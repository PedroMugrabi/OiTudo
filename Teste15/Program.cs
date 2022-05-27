using System;

namespace Teste15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());
        }
    }
}
