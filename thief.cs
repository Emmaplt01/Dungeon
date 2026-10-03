class Thief : Monster
{
    int Strength;
    Weapon Weapon;
    string name;
    public Thief(string Iname, int IlifePoints, string IeffectiveWeaponType, int strength, string IweaponClassName) : base(Iname, IlifePoints, IeffectiveWeaponType, strength, IweaponClassName)
    {
        name = Iname;
        Strength = strength;
        //Weapon = weapon; A implémenter après
    }

    public void attack(Character TargetCharacter) //plus utilisé passe pas par là
    {
        TargetCharacter.getNbLifePoints();
        TargetCharacter.receiveDamages(10);
    }
}