class StrengthPotion : Item
{
    int m_value;
    public StrengthPotion(int value) : base(value)
    {
        m_value = value;
    }

    public override void applyEffect(Hero hero)
    {
        hero.improveStrength(10);
    }
}