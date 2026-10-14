public class MonsterWeapon : Weapon
{
    private int m_iCriticalCount = 0;
    private static readonly int s_iMaxRoundBeforeCritical = 4;
    public string Name;

    public MonsterWeapon(string name, int attackPoints) : base(name, attackPoints)
    {
        Name = name;
    }

    public override void inflictDamage(Character p_TargetCharacter, int strength)
    {
        m_iCriticalCount++;

        int baseDamage = m_iAttackPoints; // hérité de Weapon

        if (m_iCriticalCount % s_iMaxRoundBeforeCritical == 0)
        {
            m_iCriticalCount = 0;
            Console.WriteLine("Coup critique. Dégats x2 !");
            p_TargetCharacter.receiveDamages(baseDamage * 2);
            return;
        }
        else
        {
            p_TargetCharacter.receiveDamages(baseDamage);
        }
        Console.WriteLine($"Vous perdez {baseDamage} points");
        Console.WriteLine($"Il vous reste {p_TargetCharacter.getNbLifePoints() - baseDamage} points de vie");
        return;
    }
}
