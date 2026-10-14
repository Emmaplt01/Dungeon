class Room : Searchable
{
    public int valeur;
    private static int i = 1;


    private Monster m_RoomMonster;
    private Item m_Items;
    private Hero p_Hero;

    public Room(Monster Monster, Item Item)
    {
        m_RoomMonster = Monster;
        m_Items = Item;

    }


    public Monster getMonster()
    {
        return m_RoomMonster;
    }

    public void enterRoom(Hero hero)
    {
        Console.WriteLine($"Vous entrez dans la salle N° {i}.");
        p_Hero = hero;
        i++;
    }

    public Item search()
    {
        if (m_Items != null)
        {
            Console.WriteLine($"Félicitation vous avez trouvé une potion de {m_Items}");
            m_Items.applyEffect(p_Hero);
        }
        else
        {
            Console.WriteLine("Vous n'avez rien trouvé ici :(");
        }
        return m_Items;
    }
}