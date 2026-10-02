class StrengthPotion : Item
{
    int m_value;
    public StrengthPotion(int value) : base(value)
    {
        m_value = value;
    }

    public void applyEffect(Hero hero)
    {
        hero.setSrength(10);
    }
}