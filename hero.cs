using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Hero : Character
{
    private int m_iStrength = 0;
    private HeroWeapons Weapons = null;
    public HeroWeapons m_heroWeapon;
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
    public Hero(string name, int lifePoints, string weapon) : base(lifePoints, weapon)
    {
        Name = name;
        LifePoints = lifePoints;
        m_heroWeapon = Weapons;

    }
    private void selectWeaponFromArsenal(string p_sWeaponClassName)
    {
        while (true)
        {
            foreach (var weapon in m_Arsenal)
            {
                if (weapon.GetType().Name == p_sWeaponClassName)
                {
                    m_heroWeapon = weapon;
                    return;
                }
            }
            m_heroWeapon = null;
            return;
        }
    }

    public override void attack(Character target)
    {
        Console.WriteLine(Messages.WeaponChoose);
        string weaponName = Console.ReadLine();

        selectWeaponFromArsenal(weaponName);

        Monster monster = (Monster)target;

        if (monster.isWeaponEfficient(m_heroWeapon))
        {
            m_heroWeapon.inflictDamage(target, m_iStrength);
            return;
        }
        else if (m_heroWeapon == null)
        {
            Console.WriteLine(Messages.MissedAttack);
            return;
        }
        else
        {
            Console.WriteLine(Messages.NotEffectiveWeapon(monster.name));
            return;
        }
    }

    public void discoverEnnemy(Monster p_Monster)
    {
        Console.WriteLine(Messages.EnemyInRoom(p_Monster.name));
    }

    public void setStrength(int p_iStrength)
    {
        m_iStrength = p_iStrength;
    }

    public void improveHealth(int p_iValue)
    {
        Console.WriteLine(Messages.HealthGained(p_iValue));
        LifePoints += p_iValue;
    }

    public void improveStrength(int p_iValue)
    {
        Console.WriteLine(Messages.StrengthGained(p_iValue));
        m_iStrength += p_iValue;
    }

    public void searchForPotion(Searchable p_Searchable)
    {
        if (p_Searchable is Room r)
        {
            if (r.roomNumber % 7 == 0 && r.roomNumber % 4 == 0)
            {
                Console.WriteLine(Messages.BothPotionsFound);
                HealthPotion healthPotion = new HealthPotion();
                healthPotion.applyEffect(this);
                StrengthPotion strengthPotion = new StrengthPotion();
                strengthPotion.applyEffect(this);
                return;
            }

        }

        Item item = p_Searchable.search();

        if (item != null)
        {
            item.applyEffect(this);
        }
    }

}