class Sorcerer : Monster
{
    Weapon Weapon;
    string name;

    public Sorcerer(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName, Item item) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName, item)
    {
        name = Iname;
        s_iNbSorcererInstances++;
    }

    public void attack(Character TargetCharacter)
    {
        TargetCharacter.getNbLifePoints();
        TargetCharacter.receiveDamages(10);
    }
}