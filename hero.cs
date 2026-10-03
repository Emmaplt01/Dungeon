using System.Reflection.PortableExecutable;

public class Hero : Character
{
    private int Strength;
    private HeroWeapons m_heroWeapons;

    private List<HeroWeapons> LHeroWeapons = new List<HeroWeapons>()
    {
        new Arrow(),
        new WaterFlask(),
        new Sword(),
        new Spear(),
        new FireArrow(),
    };

    public string Name;
    public Hero(string name, int lifePoints, int strength) : base(lifePoints)   // Appelle le constructeur de Character
    {
        Name = name;
        LifePoints = lifePoints;
        Strength = strength;

    }

    public void SelectWeaponFromArsenal(string weaponClassName) //gestion des erreurs 
    {
        foreach (var weapon in LHeroWeapons)
        {
            if (weapon.GetType().Name == weaponClassName) //Les noms des armes c'est des type plus que des strings
            {
                m_heroWeapons = weapon;
                Console.WriteLine($"Vous avez équipé : {weaponClassName}");
                return;
            }
        }

        Console.WriteLine("Cette arme n'existe pas dans votre arsenal.");
    }


    public void attack(Character TargetCharacter)
    {
        m_heroWeapons.inflictDamage(TargetCharacter); //target == monster oui
    }

    /*public discoverEnnemy(Monster monster) A voir après elle est pas dans le document
    {
        Console.WriteLine($"Attention un {monster.name} est devant vous !");
    }*/

    public void setSrength(int newSrength) //juste pour reset le truc en mode maintenant c'est plus 10 c'est 35 remplace l'existant
    {
        Strength = newSrength;
    }

    public void improveHealth(int Value)
    {

        LifePoints += Value;
    }

    public void improveStrength(int Value) //en mode potion tu à fait *2 ajout à l'existant
    {
        Strength += Value;
    }

    public void searchForPotion(Searchable Searchable)
    {
        Item found = Searchable.search(); //appel la futur fonction pour faire un random pour savoir si il a trouver une potion
        if (found == null)
        {
            Console.WriteLine("Vous n'avez pas trouver de potion");
            return;
        }

        Console.WriteLine($"Vous avez trouvez une potion de {found}"); //préciser quel type de potion
        //Est-ce que il faudrait pas le rentrer quelque part le fait qu'on à trouver une potion
    }

    /*public void tryPower(Dungeon Dungeon) pas encore faite
    {
        //a faire avec le dungeon
    }*/
}