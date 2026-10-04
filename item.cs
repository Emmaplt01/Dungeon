public class Item
{
    protected int m_iEffectValue;

    public Item(int value)
    {
        m_iEffectValue = value;
    }

    public virtual void applyEffect(Hero hero)
    {
    }

    /*public abstract void ApplyEffect(Hero hero)
    {
        J'ai décidé de pas la faire car pas utile comme attack
    }*/
}
