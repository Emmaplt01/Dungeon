class Dungeon
{
    private Room[] Rooms;

    public Dungeon()
    {
        Rooms = new Room[]
        {
        new Room(),
        new Room(),
        new Room(),
        new Room(),
        new Room(),
        };
    }


    public Room getRoom(int p_iRoomIndex)
    {
        return Rooms[p_iRoomIndex];
    }

    public void greetHeros(Hero p_Hero)
    {
        Console.WriteLine($"Bonjour bonjour, bienvue {p_Hero.Name}");
        Console.ReadLine();
    }


}