class HeroWeapons : Weapon
{
    public HeroWeapons(int attackPoint) : base(attackPoint) { }

    public override void inflictDamage(Character target)
    {
        int bonus = getBonus();
        target.receiveDamages(AttackPoint * bonus);
    }

    private int getBonus()
    {
        Random rnd = new Random();
        int valeur = rnd.Next(1, 5);
        Console.WriteLine($"Bonus x{valeur}");
        return valeur;
    }
}
