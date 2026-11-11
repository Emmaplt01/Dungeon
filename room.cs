class Room : Searchable
{
    public int valeur;
    private static int i = 0;


    private Monster m_RoomMonster;
    private Item m_Items;
    private Hero p_Hero;
    private int barbarianCount = 0;
    private int thiefCount = 0;
    private int trollCount = 0;
    private int sorcererCount = 0;
    private int zombieCount = 0;
    public int roomNumber;
    private Item item = new StrengthPotion();

    public Room(int number, Item Item)
    {
        roomNumber = number;
        m_Items = Item;

    }

    public Monster getMonster()
    {
        if (roomNumber % 4 == 0 && roomNumber % 3 == 0)
        {
            barbarianCount++;
            if (barbarianCount % 2 == 0)
            {
                item = new HealthPotion();
            }
            return new Barbarian("Barbarian", 50, "Sword", "Axe", item);
        }
        else if (roomNumber % 4 == 0)
        {
            thiefCount++;
            if (thiefCount % 6 == 1)
            {
                item = new HealthPotion();
            }

            return new Thief("Thief", 30, "Arrow", "Dagger", item);
        }
        else if (roomNumber % 3 == 0)
        {
            trollCount++;
            if (trollCount % 4 != 3)
            {
                item = new HealthPotion();
            }

            return new Troll("Troll", 20, "Spear", "Club", item);
        }
        else if (IsPrime(roomNumber) && roomNumber > 3)
        {
            sorcererCount++;
            if (sorcererCount % 3 == 0)
            {
                item = new HealthPotion();
            }

            return new Sorcerer("Sorcerer", 100, "WaterFlask", "Lightning", item);
        }
        else
        {
            zombieCount++;
            if (zombieCount % 5 != 1)
            {
                item = new HealthPotion();
            }

            return new Zombie("Zombie", 10, "FireArrow", "Bite", item);
        }
        return m_RoomMonster;
    }

    public void enterRoom(Hero hero)
    {
        Console.WriteLine(Messages.RoomEnter(i));
        p_Hero = hero;
        i++;
    }

    public Item search()
    {
        if (m_Items != null)
        {
            Console.WriteLine(Messages.PotionFound(m_Items));
            m_Items.applyEffect(p_Hero);
        }
        else
        {
            Console.WriteLine(Messages.NotFound);
        }
        return m_Items;
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