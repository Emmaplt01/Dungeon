public class MonsterWeapon : Weapon
{
    private int CriticalCount = 0;
    private int MaxRoundBeforeCritical = 3;
    public string Name;

    public MonsterWeapon(string name, int attackPoints) : base(attackPoints)
    {
        Name = name;
    }

    public override int inflictDamage(Character p_TargetCharacter)
    {
        CriticalCount++;

        int baseDamage = m_iAttackPoints; // hérité de Weapon

        if (CriticalCount >= MaxRoundBeforeCritical)
        {
            CriticalCount = 0;
            Console.WriteLine("Coup critique !");
            return baseDamage * 2;
        }

        return baseDamage;
    }
}
