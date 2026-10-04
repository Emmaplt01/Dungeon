using System.Net.ServerSentEvents;

public class Searchable
{
    public static Item search(Hero hero)
    {
        Random rnd = new Random();
        int valeur = rnd.Next(0, 30);

        if (valeur <= 10)
        {
            Item potion = new StrengthPotion(valeur);
            hero.Inventory.Add(potion);
            Console.WriteLine($"Vous avez trouver une potion de force");
            return potion;
        }
        if (valeur <= 20)
        {
            Item potion = new HealthPotion(valeur);
            hero.Inventory.Add(potion);
            Console.WriteLine($"Vous avez trouver une potion de vie");
            return potion;
        }
        Console.WriteLine("Vous n'avez rien trouvé");
        return null;
    }
}