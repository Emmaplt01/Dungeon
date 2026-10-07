public class Character
{
    protected int m_iLifePoints;
    public string name;

    public Character(int pts)
    {
        m_iLifePoints = pts;
    }

    public virtual void attack(Character p_TargetCharacter)
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
