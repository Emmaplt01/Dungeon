using System.Net.ServerSentEvents;

public class Searchable
{
    public static void search(Hero hero)
    {
        Random rnd = new Random();
        int valeur = rnd.Next(0, 30);

        if (valeur <= 10)
        {
            hero.Inventory.Add(new StrengthPotion(valeur));
            Console.WriteLine($"Vous avez trouver une potion de force");
            return;
        }
        if (valeur <= 20)
        {
            hero.Inventory.Add(new HealthPotion(valeur));
            Console.WriteLine($"Vous avez trouver une potion de vie");
            return;
        }
        Console.WriteLine("Vous n'avez rien trouvé");
        return;
    }
}