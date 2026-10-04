using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Hero : Character
{
    private int Strength;
    private HeroWeapons m_heroWeapons;
    private int index = 0;

    private List<HeroWeapons> LHeroWeapons = new List<HeroWeapons>()
    {
        new Arrow(),
        new WaterFlask(),
        new Sword(),
        new Spear(),
        new FireArrow(),
    };

    public string Name;

    public List<Item> Inventory = new List<Item>();
    public Hero(string name, int lifePoints, int strength) : base(lifePoints)   // Appelle le constructeur de Character
    {
        Name = name;
        LifePoints = lifePoints;
        Strength = strength;

    }

    public void SelectWeaponFromArsenal(string weaponClassName) //gestion des erreurs 
    {
        while (true)
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
            Console.WriteLine("Vous ne possédez pas cette armes. Voici les armes à votre disposition");
            foreach (Weapon weapon in LHeroWeapons)
            {
                Console.WriteLine(weapon);
            }
            Console.WriteLine("Veuillez sélectionner une amre valdie");
            weaponClassName = Console.ReadLine();
        }
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
        Console.WriteLine($"Vous avez gagner + {Value} points de vie");
        LifePoints += Value;
        Console.WriteLine($"Vous avez maintenant {LifePoints} points de vie");
    }

    public void improveStrength(int Value)
    {
        Console.WriteLine($"Vous avez gagner en force +{Value} ");
        Strength += Value;
    }

    public void searchForPotion(Searchable Searchable)
    {
        Searchable.search(this); //appel la futur fonction pour faire un random pour savoir si il a trouver une potion
        //Est-ce que il faudrait pas le rentrer quelque part le fait qu'on à trouver une potion
    }

    public void showInventory()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("L'Inventaire est vide.");
            return;
        }

        foreach (Item item in Inventory)
        {
            Console.WriteLine($"[{index}] {item}");
            index++;
        }
        Console.WriteLine("Voulez vous utiliser un potion ?");
        string respons = Console.ReadLine();
        if (respons == "oui" || respons == "Oui")
        {
            Console.WriteLine($"Tapez le numéro de la potion de 1 à {index}");
            int choose = Convert.ToInt32(Console.ReadLine());
            Inventory[choose].applyEffect(this);
            return;
        }

    }

    /*public void tryPower(Dungeon Dungeon) pas encore faite
    {
        //a faire avec le dungeon
    }*/
}