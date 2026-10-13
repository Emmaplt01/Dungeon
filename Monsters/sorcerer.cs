class Sorcerer : Monster
{
    Weapon Weapon;
    string name;

    public Sorcerer(string Iname, int IlifePoints, string IeffectiveWeaponType, string IweaponClassName, Item item) : base(Iname, IlifePoints, IeffectiveWeaponType, IweaponClassName, item)
    {
        name = Iname;
        s_iNbSorcererInstances++;
        //Weapon = weapon; A implémenter après
    }

    public void attack(Character TargetCharacter) //plus utiliser passe pas par là
    {
        TargetCharacter.getNbLifePoints();
        TargetCharacter.receiveDamages(10);
    }
}