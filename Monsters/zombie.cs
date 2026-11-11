class Zombie : Monster
{
    Weapon Weapon;
    string name;
    public Zombie(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName, Item item) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName, item)
    {
        name = Iname;
        s_iNbZombieInstances++;
    }

    public void attack(Character TargetCharacter)
    {
        TargetCharacter.getNbLifePoints();
        TargetCharacter.receiveDamages(10);
    }
}