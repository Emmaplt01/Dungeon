public class Character
{
    public int LifePoints;   // ✔ public pour être visible partout
    public string name;

    public Character(int pts)
    {
        LifePoints = pts;
    }

    public int getNbLifePoints()
    {
        return LifePoints;
    }

    public void receiveDamages(int damages)
    {
        LifePoints -= damages;
        getNbLifePoints();
    }

    public bool isalive()
    {
        return LifePoints > 0;
    }
}
