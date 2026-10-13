class Thief : Monster
{
    Weapon Weapon;
    string name;
    public Thief(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName, Item item) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName, item)
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