public abstract class Item
{
    protected int m_iEffectvalue;

    public void setValue(int p_iValue)
    {
        m_iEffectvalue = p_iValue;
    }

    public abstract void applyEffect(Hero hero); //ELle est en virtual, elle est bien utilisée va être overrind

}
