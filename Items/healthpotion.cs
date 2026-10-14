class HealthPotion : Item
{
    public override void applyEffect(Hero p_hero)
    {
        p_hero.improveHealth(10);
    }
}