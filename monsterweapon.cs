class MonsterWeapon : Weapon
{
    public List<MonsterWeapon> LHeroWeapons = new List<MonsterWeapon>();
    public string Name;
    public int AttackPoints;
    public MonsterWeapon(string name, int IAttackPoint) : base(IAttackPoint)
    {
        Name = name;
        AttackPoints = IAttackPoint;
    }

    public void inflictDamage(Character targetCharacter)
    {
        targetCharacter.receiveDamages(AttackPoints);
    }
}