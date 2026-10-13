using System.ComponentModel.DataAnnotations;

class HeroWeapons : Weapon
{
    private int m_iAttackBonus;
    private int nb;
    public HeroWeapons(string name, int attackPoints) : base(name, attackPoints)
    {
    }

    public override void inflictDamage(Character target)
    {
        Random rnd = new Random();
        int bonus = rnd.Next(0, 5); // bonus aléatoire
        setAttackBonus(bonus);

        int totalDamage = m_iAttackPoints + m_iAttackBonus;
        target.receiveDamages(totalDamage);
    }



    private void setAttackBonus(int p_iBonus)
    {
        m_iAttackBonus = p_iBonus;
        Console.WriteLine($"Bonus +{m_iAttackBonus}");
        return;
    }
}
