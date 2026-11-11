using System.Net.NetworkInformation;

class Dungeon
{
    public int maxRoom;

    public Dungeon(int number)
    {
        maxRoom = number;
    }

    public Room getRoom(int p_iRoomIndex)
    {
        if (p_iRoomIndex % 7 == 0 && p_iRoomIndex % 4 == 0)
        {
            //Je donne les 2 dans Hero.searchForPotion pour ne pas avoir à faire de liste
            new Room(p_iRoomIndex, new HealthPotion());
        }
        else if (p_iRoomIndex % 7 == 0)
        {
            new Room(p_iRoomIndex, new HealthPotion());
        }
        else if (p_iRoomIndex % 4 == 0)
        {
            new Room(p_iRoomIndex, new StrengthPotion());
        }
        return new Room(p_iRoomIndex, null);
    }

    public void greetHeros(Hero p_Hero)
    {
        Console.WriteLine($"Bonjour bonjour, bienvue {p_Hero.Name}");
        Console.ReadLine();
    }
}