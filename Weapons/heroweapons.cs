using System.ComponentModel.DataAnnotations;

public class HeroWeapons : Weapon
{
    private int m_iAttackBonus;

    public HeroWeapons(string name, int attackPoints) : base(name, attackPoints)
    {
    }

    public override void inflictDamage(Character p_target, int strength)
    {
        Random rnd = new Random();
        int bonus = rnd.Next(0, 5); // bonus aléatoire
        setAttackBonus(bonus);

        int totalDamage = m_iAttackPoints + m_iAttackBonus + strength;
        p_target.receiveDamages(totalDamage);
        Console.WriteLine(Messages.HeroAttacksMonster(p_target.getNbLifePoints()));
    }

    private void setAttackBonus(int p_iBonus)
    {
        m_iAttackBonus = p_iBonus;
        Console.WriteLine(Messages.AttackBonus(m_iAttackBonus));
        return;
    }
}
