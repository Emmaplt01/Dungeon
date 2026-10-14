public class Character
{
    protected int m_iLifePoints;
    public string name;

    protected String m_Weapon;

    public Character(int pts, String weapon)
    {
        m_iLifePoints = pts;
        m_Weapon = weapon;
    }

    public virtual void attack(Character p_TargetCharactern)
    {

    }


    public int getNbLifePoints()
    {
        return m_iLifePoints;
    }

    public void receiveDamages(int p_iDamages)
    {
        m_iLifePoints -= p_iDamages;
        getNbLifePoints();
    }

    public bool isalive()
    {
        return m_iLifePoints > 0;
    }
}
