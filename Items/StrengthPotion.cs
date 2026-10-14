class StrengthPotion : Item
{
    public override void applyEffect(Hero p_hero)
    {
        p_hero.improveStrength(20);
    }
}