class HealthPotion : Item
{
    int m_value;
    public HealthPotion(int value) : base(value)
    {
        m_value = value;
    }

    public void applyEffect(Hero hero)
    {
        hero.LifePoints += m_value;
    }
}