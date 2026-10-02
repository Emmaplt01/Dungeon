class Room
{
    int Index = 1;
    public int valeur;
    Monster monster;
    List<Monster> monsters = new List<Monster>();
    //monsters.Add(new Zombie());
    //monsters.Add(new Sorcerer());
    //monsters.Add(new Barbarian());


    public Room(int index)
    {
        Index = index;
        monsters.Add(new Troll("Troll", 20, "arrow", 5));
        monsters.Add(new Thief("Thief", 30, "arrow", 10));

    }

    public Monster getMonster()
    {
        Random rnd = new Random();
        valeur = rnd.Next(0, 2); //max est exclus
        return monsters[valeur];
    }

    public void enterRoom(Hero Hero)
    {
        Console.WriteLine($"Vous entrez dans la salle N° {Index}.");
        Random rnd = new Random();
        valeur = rnd.Next(0, 2); //max est exclus
    }
}