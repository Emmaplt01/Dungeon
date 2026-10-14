using System.ComponentModel.DataAnnotations;

class HeroWeapons : Weapon
{
    private int m_iAttackBonus;

    public HeroWeapons(string name, int attackPoints) : base(name, attackPoints)
    {
    }

    public override void inflictDamage(Character target, int strength)
    {
        Random rnd = new Random();
        int bonus = rnd.Next(0, 5); // bonus aléatoire
        setAttackBonus(bonus);

        int totalDamage = m_iAttackPoints + m_iAttackBonus + strength;
        target.receiveDamages(totalDamage);
    }



    private void setAttackBonus(int p_iBonus)
    {
        m_iAttackBonus = p_iBonus;
        Console.WriteLine($"Bonus +{m_iAttackBonus}");
        return;
    }
}
