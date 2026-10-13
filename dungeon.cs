using System.Net.NetworkInformation;

class Dungeon
{
    private Room[] m_RoomsArray;

    private int barbarianCount = 0;
    private int thiefCount = 0;
    private int trollCount = 0;
    private int sorcererCount = 0;
    private int zombieCount = 0;
    private Item item;


    public Dungeon(int number)
    {
        m_RoomsArray = new Room[number];
        generateRooms(number);
    }

    public void generateRooms(int nbRooms)
    {
        for (int i = 0; i < nbRooms; i++)
        {
            item = new StrengthPotion(20);
            if (i % 4 == 0 && i % 3 == 0)
            {
                barbarianCount++;
                if (barbarianCount % 2 == 0)
                {
                    item = new HealthPotion(10);
                }
                m_RoomsArray[i] = new Room(new Barbarian("Barbarian", 50, "Sword", "Axe", item), itemsRooms(i));
            }
            else if (i % 4 == 0)
            {
                thiefCount++;
                if (thiefCount % 6 == 1)
                {
                    item = new HealthPotion(10);
                }

                m_RoomsArray[i] = new Room(new Thief("Thief", 30, "Arrow", "Dagger", item), itemsRooms(i));
            }
            else if (i % 3 == 0)
            {
                trollCount++;
                if (trollCount % 4 != 3)
                {
                    item = new HealthPotion(10);
                }

                m_RoomsArray[i] = new Room(new Troll("Troll", 20, "Spear", "Club", item), itemsRooms(i));
            }
            else if (IsPrime(i) && i > 3)
            {
                sorcererCount++;
                if (sorcererCount % 3 == 0)
                {
                    item = new HealthPotion(10);
                }

                m_RoomsArray[i] = new Room(new Sorcerer("Sorcerer", 100, "WaterFlask", "Lightning", item), itemsRooms(i));
            }
            else
            {
                zombieCount++;
                if (zombieCount % 5 != 1)
                {
                    item = new HealthPotion(10);
                }

                m_RoomsArray[i] = new Room(new Zombie("Zombie", 10, "FireArrow", "Bite", item), itemsRooms(i));
            }

        }
    }

    private Item itemsRooms(int index)
    {
        if (index % 7 == 0 && index % 4 == 0)
        {
            return new HealthPotion(10); //normalement doit renvoyer les 2 en même temps
        }
        else if (index % 7 == 0)
        {
            return new HealthPotion(10);
        }
        else if (index % 4 == 0)
        {
            return new StrengthPotion(20);
        }
        return null;
    }
    public Room getRoom(int p_iRoomIndex)
    {
        return m_RoomsArray[p_iRoomIndex];
    }

    public void greetHeros(Hero p_Hero)
    {
        Console.WriteLine($"Bonjour bonjour, bienvue {p_Hero.Name}");
        Console.ReadLine();
    }

    private bool IsPrime(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;

        return true;
    }



}