public class Weapon
{
    protected int m_iAttackPoints;
    public string Name;

    public Weapon(string name, int attackPoint)
    {
        Name = name;
        m_iAttackPoints = attackPoint;
    }

    public virtual void inflictDamage(Character p_TargetCharacter)
    {
    }

    public int getAttackPoint()
    {
        return m_iAttackPoints;
    }

}
