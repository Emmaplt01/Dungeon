class Barbarian : Monster
{
    Weapon Weapon;
    string name;

    public Barbarian(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName, Item item) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName, item)
    {
        name = Iname;
        s_iNbBarbarianInstances++;

    }

    public void attack(Character TargetCharacter)
    {
        TargetCharacter.receiveDamages(10);
    }
}