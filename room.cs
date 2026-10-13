class Room
{
    public int valeur;
    private static int i = 1;


    private Monster monster;
    private Item item;

    public Room(Monster Monster, Item Item)
    {
        monster = Monster;
        item = Item;
    }


    public Monster getMonster()
    {
        return monster;
    }

    public void enterRoom(Hero hero)
    {
        Console.WriteLine($"Vous entrez dans la salle N° {i}.");
        i++;
    }

    public Item search()
    {
        if (item != null)
        {
            Console.WriteLine($"Félicitation vous avez trouvé une potion de {item}");
        }
        else
        {
            Console.WriteLine("Vous n'avez rien trouvé ici :(");
        }
        return item;
    }
}