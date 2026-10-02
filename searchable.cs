using System.Net.ServerSentEvents;

public class Searchable
{
    public Item search()
    {
        Random rnd = new Random();
        int valeur = rnd.Next(0, 30);

        if (valeur <= 10)
        {
            return new StrengthPotion(valeur);
        }
        if (valeur <= 20)
        {
            return new HealthPotion(valeur);
        }
        return null;
    }
}