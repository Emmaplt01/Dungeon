class Thief : Monster
{
    Weapon Weapon;
    string name;
    public Thief(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName)
    {
        name = Iname;
        s_iNbThiefInstances++;
    }

    public void attack(Character TargetCharacter) //plus utilisé passe pas par là
    {
        TargetCharacter.getNbLifePoints();
        TargetCharacter.receiveDamages(10);
    }
}