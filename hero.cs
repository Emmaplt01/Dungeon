using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Hero : Character
{
    private int m_iStrength = 1;
    private HeroWeapons m_heroWeapons;
    private int index = 0;

    private int LifePoints;

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
    public Hero(string name, int lifePoints) : base(lifePoints)   // Appelle le constructeur de Character
    {
        Name = name;
        LifePoints = lifePoints;

    }

    public Weapon chooseWeapon(string p_sWeaponClassName)
    {
        selectWeaponFromArsenal(p_sWeaponClassName);
        return m_heroWeapons;
    }
    private void selectWeaponFromArsenal(string p_sWeaponClassName) //gestion des erreurs 
    {
        while (true)
        {
            foreach (var weapon in LHeroWeapons)
            {
                if (weapon.GetType().Name == p_sWeaponClassName) //Les noms des armes c'est des type plus que des strings
                {
                    m_heroWeapons = weapon;
                    Console.WriteLine($"Vous avez équipé : {p_sWeaponClassName}");
                    return;
                }
            }
            Console.WriteLine("Vous ne possédez pas cette armes. Voici les armes à votre disposition");
            foreach (Weapon weapon in LHeroWeapons)
            {
                Console.WriteLine(weapon);
            }
            Console.WriteLine("Veuillez sélectionner une amre valdie");
            p_sWeaponClassName = Console.ReadLine();
        }
    }


    public override void attack(Character p_TargetCharacter)
    {
        int baseDamage = m_heroWeapons.inflictDamage(p_TargetCharacter);
        int totalDamage = baseDamage * m_iStrength;
        p_TargetCharacter.receiveDamages(totalDamage);
    }


    public void discoverEnnemy(Monster p_Monster)
    {
        Console.WriteLine($"Attention un {p_Monster.name} est devant vous !");
    }

    public int getStrength()
    {
        return m_iStrength;
    }
    public void improveHealth(int p_iValue)
    {
        Console.WriteLine($"Vous avez gagner + {p_iValue} points de vie");
        LifePoints += p_iValue;
        Console.WriteLine($"Vous avez maintenant {LifePoints} points de vie");
    }

    public void improveStrength(int p_iValue)
    {
        Console.WriteLine($"Vous avez gagner en force +{p_iValue} ");
        m_iStrength += p_iValue;
    }

    public void searchForPotion(Searchable p_Searchable)
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
}