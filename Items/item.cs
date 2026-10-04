public class Item
{
    protected int m_iEffectvalue;

    public Item(int value)
    {
        m_iEffectvalue = value;
    }

    public void setValue(int value)
    {
        m_iEffectvalue = value;
    }

    public virtual void applyEffect(Hero hero)
    {
    }

}
