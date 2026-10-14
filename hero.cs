using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Hero : Character
{
    private int m_iStrength = 1;
    private HeroWeapons m_heroWeapons;
    private int index = 0;

    private int LifePoints;
    public string Name;

    private List<HeroWeapons> m_Arsenal = new List<HeroWeapons>()
    {
        new Arrow(),
        new WaterFlask(),
        new Sword(),
        new Spear(),
        new FireArrow(),
    };
    public Hero(string name, int lifePoints, string weapon) : base(lifePoints, weapon)   // Appelle le constructeur de Character
    {
        Name = name;
        LifePoints = lifePoints;

    }

    public Weapon weaponChoose(string p_sWeaponClassName)
    {
        selectWeaponFromArsenal(p_sWeaponClassName);
        return m_heroWeapons;
    }
    private void selectWeaponFromArsenal(string p_sWeaponClassName) //gestion des erreurs 
    {
        while (true)
        {
            foreach (var weapon in m_Arsenal)
            {
                if (weapon.GetType().Name == p_sWeaponClassName)
                {
                    m_heroWeapons = weapon;
                    return;
                }
            }
            m_heroWeapons = null;
            return;
        }
    }


    public override void attack(Character target)
    {
        m_heroWeapons.inflictDamage(target, m_iStrength);
    }

    public void discoverEnnemy(Monster p_Monster)
    {
        Console.WriteLine($"Un {p_Monster.name} vous attaque !");
    }

    public void setStrength(int p_iStrength)
    {
        m_iStrength = p_iStrength;
    }
    public int getStrength()
    {
        return m_iStrength;
    }
    public void improveHealth(int p_iValue)
    {
        Console.WriteLine($"Vous avez gagner + {p_iValue} points de vie");
        LifePoints += p_iValue;
        Console.WriteLine($"Il vous reste {LifePoints} points de vie");
    }

    public void improveStrength(int p_iValue)
    {
        Console.WriteLine($"Vous avez gagner en force +{p_iValue} ");
        m_iStrength += p_iValue;
    }

    public void searchForPotion(Searchable p_Searchable)
    {
        Item item = p_Searchable.search(); //fouille du monstre
        if (item != null)
        {
            item.applyEffect(this);
        }
    }

}