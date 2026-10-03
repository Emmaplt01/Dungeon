class Room
{
    int Index = 1;
    public int valeur;
    Monster monster;
    List<Monster> monsters = new List<Monster>()
    {
        new Troll("Troll", 20, "Sword", "Axe"), //Nom, lifepoint, weaponefficient, weapon use
        new Thief("Thief", 30, "Arrow", "Dagger"),
        new Sorcerer("Sorcerer", 100, "WaterFlask", "Lightning"),
        new Zombie("Zombie", 10, "FireArrow", "Bite"),
        new Barbarian("Barbarian", 50, "Spear", "Club"),

    };

    public Room(int index)
    {
        Index = index;

    }

    public Monster getMonster()
    {
        Random rnd = new Random();
        valeur = rnd.Next(0, 5); //max est exclus
        return monsters[valeur];
    }

    public void enterRoom(Hero Hero)
    {
        Console.WriteLine($"Vous entrez dans la salle N° {Index}.");
    }
}