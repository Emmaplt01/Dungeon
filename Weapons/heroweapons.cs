using System.ComponentModel.DataAnnotations;

class HeroWeapons : Weapon
{
    public HeroWeapons(int attackPoint) : base(attackPoint) { }

    public override int inflictDamage(Character p_TargetCharacter)
    {
        int bonus = setAttackBonus();
        return m_iAttackPoints + bonus;
    }


    private int setAttackBonus()
    {
        Random rnd = new Random();
        int valeur = rnd.Next(0, 5); //Le max est exclus
        Console.WriteLine($"Bonus +{valeur}");
        return valeur;
    }
}
