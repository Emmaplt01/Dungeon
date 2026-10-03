class Zombie : Monster
{
    Weapon Weapon;
    string name;
    public Zombie(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName)
    {
        name = Iname;
        //Weapon = weapon; A implémenter après
    }

    public void attack(Character TargetCharacter) //plus utiliser passe pas par là
    {
        TargetCharacter.getNbLifePoints();
        TargetCharacter.receiveDamages(10);
    }
}