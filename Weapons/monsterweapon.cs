public class MonsterWeapon : Weapon
{
    private int m_iCriticalCount = 0;
    private static readonly int s_iMaxRoundBeforeCritical = 4;

    public MonsterWeapon(string name, int attackPoints) : base(name, attackPoints)
    {
    }

    public override void inflictDamage(Character p_TargetCharacter, int strength)
    {
        m_iCriticalCount++;

        int baseDamage = m_iAttackPoints;

        if (m_iCriticalCount % s_iMaxRoundBeforeCritical == 0)
        {
            m_iCriticalCount = 0;
            Console.WriteLine(Messages.CriticalHit);
            p_TargetCharacter.receiveDamages(baseDamage * 2);
            return;
        }
        else
        {
            p_TargetCharacter.receiveDamages(baseDamage);
        }
        Console.WriteLine(Messages.MonsterAttacks(baseDamage, p_TargetCharacter.getNbLifePoints()));
        return;
    }
}
