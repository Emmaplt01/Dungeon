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
    public int strength;
    string name;

    public Monster(string Iname, int IlifePoints, string IeffectiveWeaponType, int Istrength) : base(IlifePoints)   // Appelle le constructeur de Character
    {
        effectiveWeaponType = IeffectiveWeaponType;
        strength = Istrength;
        name = Iname;
        lifepoints = IlifePoints;
    }

    public string getEffectiveWeaponType()
    {
        return effectiveWeaponType;
    }

    public void attack(Character TargetCharacter, int Damages)
    {
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