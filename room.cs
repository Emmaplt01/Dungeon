class Room
{
    public int valeur;
    Monster monster;
    private static int i = 1;
    List<Monster> monsters = new List<Monster>()
    {
        new Troll("Troll", 20, "Sword", "Axe"), //Nom, lifepoint, weaponefficient, weapon use
        new Thief("Thief", 30, "Arrow", "Dagger"),
        new Sorcerer("Sorcerer", 100, "WaterFlask", "Lightning"),
        new Zombie("Zombie", 10, "FireArrow", "Bite"),
        new Barbarian("Barbarian", 50, "Spear", "Club"),

    };

    public Room()
    {

    }

    public Monster getMonster()
    {
        Random rnd = new Random();
        valeur = rnd.Next(0, 5); //max est exclus
        return monsters[valeur];
    }

    public void enterRoom(Hero p_Hero)
    {

        Console.WriteLine($"Vous entrez dans la salle N° {i}."); //changer Index
        i++;
    }
}