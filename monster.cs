using System.Reflection.PortableExecutable;

public class Monster : Character
{
    public string m_sEffectiveWeaponType;
    public static int s_iNbZombieInstances = 0;
    public static int s_iNbThiefInstances = 0;
    public static int s_iNbSorcererInstances = 0;
    public static int s_iNbBarbarianInstances = 0;
    public static int s_iNbTrollInstances = 0;

    public string effectiveWeaponType;
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

    public Monster(string Iname, int IlifePoints, string IeffectiveWeaponType, string weaponClassName) : base(IlifePoints)   // Appelle le constructeur de Character
    {
        effectiveWeaponType = IeffectiveWeaponType;
        name = Iname;

        foreach (var weapon in LMonsterWeapons)
        {
            if (weapon.GetType().Name == weaponClassName) //Les noms des armes c'est des type plus que des strings
            {
                m_MonsterWeapon = weapon;
                return;
            }
        }
    }

    public string getEffectiveWeaponType()
    {
        return effectiveWeaponType;
    }

    public void attack(Character p_TargetCharacter)
    {
        int Damages = m_MonsterWeapon.inflictDamage(p_TargetCharacter);
        Console.WriteLine($"Vous vous faites attaqué par le {name} vous perdez {Damages} points");
        Console.WriteLine($"Il vous reste {p_TargetCharacter.getNbLifePoints() - Damages} points");
        p_TargetCharacter.receiveDamages(Damages);

    }


    public bool isWeaponEfficient(MonsterWeapon p_Weapon)
    {
        if (m_sEffectiveWeaponType == p_Weapon.Name)
        {
            return true;
        }
        return false;
    }
}