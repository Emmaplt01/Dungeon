class Dungeon
{
    public Dungeon()
    {

    }

    /*public Room getRoom(int RoomIndex)
    { Pas utile pour le moment je pense
    }*/

    public void greetHeros(Hero hero)
    {
        Console.WriteLine($"Bonjour bonjour, bienvue {hero.Name}");
        Console.ReadLine();
    }


}