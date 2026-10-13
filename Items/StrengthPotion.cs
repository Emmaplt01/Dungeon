class StrengthPotion : Item
{
    public StrengthPotion(int value) : base(value)
    {

    }

    public override void applyEffect(Hero p_hero)
    {
        p_hero.improveStrength(10);
    }
}