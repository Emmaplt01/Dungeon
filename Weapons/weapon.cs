public class Weapon
{
    protected int m_iAttackPoints;
    public string Name;

    public Weapon(string name, int attackPoint)
    {
        Name = name;
        m_iAttackPoints = attackPoint;
    }

    public virtual int inflictDamage(Character p_TargetCharacter)
    {
        return m_iAttackPoints;
    }

    public int getAttackPoint()
    {
        return m_iAttackPoints;
    }

}
