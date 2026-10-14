using System.Reflection.PortableExecutable;

public class Monster : Character, Searchable
{
    public string m_sEffectiveWeaponType;
    public static int s_iNbZombieInstances = 0;
    public static int s_iNbThiefInstances = 0;
    public static int s_iNbSorcererInstances = 0;
    public static int s_iNbBarbarianInstances = 0;
    public static int s_iNbTrollInstances = 0;
    private bool m_bSearchDone = false;

    protected Item m_Item;

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

    public Monster(string Iname, int IlifePoints, string IeffectiveWeaponType, string WeaponUse, Item item) : base(IlifePoints, WeaponUse)   // Appelle le constructeur de Character
    {

        m_sEffectiveWeaponType = IeffectiveWeaponType;
        name = Iname;
        m_Item = item;

        foreach (var weapon in LMonsterWeapons)
        {
            if (weapon.GetType().Name == WeaponUse) //pour transformer la string en weapon (pr faire le rapprochement)
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
        m_MonsterWeapon.inflictDamage(p_TargetCharacter, 1);
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

    public Item search()
    {
        if (m_Item != null)
        {
            Console.WriteLine($"Félicitation vous avez trouvé une potion de {m_Item}");
        }
        else
        {
            Console.WriteLine("Vous n'avez rien trouvé ici :(");
        }
        return m_Item;
    }
}