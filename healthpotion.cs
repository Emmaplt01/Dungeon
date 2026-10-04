class HealthPotion : Item
{
    int m_value;
    public HealthPotion(int value) : base(value)
    {
        m_value = value;
    }

    public override void applyEffect(Hero hero)
    {
        hero.improveHealth(m_value);
    }
}