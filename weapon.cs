class Weapon
{
    public int AttackPoint { get; protected set; }

    public Weapon(int attackPoint)
    {
        AttackPoint = attackPoint;
    }

    public virtual void inflictDamage(Character target) //passe par heroweapons.cs
    {
        Console.WriteLine("passez par inflict Damage weapon");
        target.receiveDamages(AttackPoint);
    }
}
