using System;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component composite = new SongCollection("Hip hop", "Hip hop collection");

            Component song1 = new Song("Ghetto Superstar", "Pras");
            Component song2 = new Song("Meet me half way", "Black Eyed Peas");
            Component kanye = new SongCollection("Kanye West", "Kanye West's collection");

            Component song3 = new Song("Selfish", "With Slum Village");
            Component song4 = new Song("Heard 'Em Say", "With Adam Levine");

            composite.SetItem(song1);
            composite.SetItem(song2);

            kanye.SetItem(song3);
            kanye.SetItem(song4);

            composite.SetItem(kanye);

            composite.Print();

            Console.ReadLine();
        }
    }
}
