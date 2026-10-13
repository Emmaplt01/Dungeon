using System.Reflection.PortableExecutable;

public class Monster : Character
{
    public string m_sEffectiveWeaponType;
    public static int s_iNbZombieInstances = 0;
    public static int s_iNbThiefInstances = 0;
    public static int s_iNbSorcererInstances = 0;
    public static int s_iNbBarbarianInstances = 0;
    public static int s_iNbTrollInstances = 0;
    private bool m_bSearchDone = false;

    public string name;

    private List<MonsterWeapon> LMonsterWeapons = new List<MonsterWeapon>()
    {
        new Dagger(),
        new Bite(),
        new Axe(),
        new Lightning(),
        new Club(),
    };
    private MonsterWeapon m_MonsterWeapon;

    public Monster(string Iname, int IlifePoints, string IeffectiveWeaponType, string weaponClassName, Item item) : base(IlifePoints)   // Appelle le constructeur de Character
    {

        m_sEffectiveWeaponType = IeffectiveWeaponType;
        name = Iname;

        foreach (var weapon in LMonsterWeapons)
        {
            if (weapon.GetType().Name == weaponClassName) //pour transformer la string en weapon (pr faire le rapprochement)
            {
                m_MonsterWeapon = weapon;
                return;
            }
        }
    }

    public string getEffectiveWeaponType()
    {
        return m_sEffectiveWeaponType;
    }

    public override void attack(Character p_TargetCharacter)
    {
        m_MonsterWeapon.inflictDamage(p_TargetCharacter);


    }

    public bool isWeaponEfficient(Weapon p_Weapon)
    {
        if (m_sEffectiveWeaponType == p_Weapon.Name)
        {
            return true;
        }
        return false;
    }

    public void SearchDone()
    {
        m_bSearchDone = true;
    }
    public bool isSearchDone()
    {
        return m_bSearchDone;
    }

    public static Item search(Hero hero)
    {
        Random rnd = new Random();
        int valeur = rnd.Next(0, 30);

        if (valeur <= 10)
        {
            Item potion = new StrengthPotion(valeur);
            hero.Inventory.Add(potion);
            Console.WriteLine($"Vous avez trouver une potion de force");
            return potion;
        }
        if (valeur <= 20)
        {
            Item potion = new HealthPotion(valeur);
            hero.Inventory.Add(potion);
            Console.WriteLine($"Vous avez trouver une potion de vie");
            return potion;
        }
        Console.WriteLine("Vous n'avez rien trouvé");
        return null;
    }
}