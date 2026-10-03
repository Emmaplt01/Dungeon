using System.Reflection.PortableExecutable;

class Monster : Character
{
    public string EffectiveWeaponType;
    public static int NbZombieInstances;
    public int NbThiefInstances;
    public int NbSorcerInstance;
    public int NbBarbrianInstances;
    public int NbTrollnstances;
    private bool SearchDone;

    public int lifepoints;
    public string effectiveWeaponType;
    string name;
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
        lifepoints = IlifePoints;

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

    public void attack(Character TargetCharacter)
    {
        int Damages = m_MonsterWeapon.AttackPoint;
        Console.WriteLine($"Vous vous faites attaqué par un {name} vous perdez {Damages} points");
        Console.WriteLine($"Il vous reste {TargetCharacter.LifePoints - Damages} points");
        TargetCharacter.receiveDamages(Damages); //a changer
    }

    public bool isWeaponEfficient(MonsterWeapon monsterWeapon)
    {
        if (EffectiveWeaponType == monsterWeapon.Name)
        {
            return true;
        }
        return false;
    }
}