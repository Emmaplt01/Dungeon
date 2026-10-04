class Troll : Monster
{
    Weapon Weapon;
    string name;

    public Troll(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName)
    {
        name = Iname;
        s_iNbTrollInstances++;
    }

    public void attack(Character TargetCharacter) //plus utiliser passe pas par là
    {
        TargetCharacter.getNbLifePoints();
        TargetCharacter.receiveDamages(10);
    }
}