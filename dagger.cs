class Dagger : MonsterWeapon
{
    public int AttackPoints;
    public Dagger() : base("Dagger", 5) // créé aussi un heroweapon avec ces infos
    {
    }

    public int getAttackPoints()
    {
        return AttackPoints;
    }

}