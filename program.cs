
class Program
{
    static void Main()
    {
        string name;
        string action_choose;
        int index = 0;
        bool fouiller = false;
        Weapon HeroWeapon;
        bool running = true;


        Console.WriteLine("Quel est votre nom jeune aventurier ?");
        name = Console.ReadLine();
        Hero h = new Hero(name, 200);
        Dungeon d = new Dungeon(25);
        d.greetHeros(h);
        while (index <= 5)
        {
            Room r = d.getRoom(index);
            r.enterRoom(h);
            Monster m = r.getMonster();
            Console.WriteLine($"Vous vous faites attaquer par un {m.name} !");
            while (m.getNbLifePoints() > 0)
            {
                m.attack(h);
                if (h.getNbLifePoints() <= 0)
                {
                    Console.WriteLine("Vous êtes malheureusement mort ... #RIP");
                    return;
                }
                Console.WriteLine($"Que voulez vous faire {h.name} ? Fouiller, Inventaire, Attack");
                action_choose = Console.ReadLine();
                switch (action_choose)
                {
                    case "Fouiller":
                        if (fouiller == true)
                        {
                            Console.WriteLine("Vous avez déjà fouillé cette pièce");
                            break;
                        }
                        fouiller = true;
                        Item result = r.search();
                        if (result != null)
                        {
                            h.Inventory.Add(result);
                        }
                        break;

                    case "Inventaire":
                        h.showInventory();
                        break;

                    case "Attack":
                        Console.WriteLine("Quelles armes voulez-vous utiliser ?");
                        HeroWeapon = h.chooseWeapon(Console.ReadLine());
                        if (m.isWeaponEfficient(HeroWeapon) == true)
                        {
                            h.attack(m);
                            Console.WriteLine($"Vous avez attaqué le {m} il lui reste {m.getNbLifePoints()} points ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Cette arme est inutile face au {m}");
                            break;
                        }

                    default:
                        Console.WriteLine("Commande inconnue.");
                        break;
                }

            }
            fouiller = false;
            Console.WriteLine($"Super ! Vous avez teracé le {m} !");
            while (running)
            {
                Console.WriteLine("Que voulez vous faire: Fouiller ou Avancer ?");
                action_choose = Console.ReadLine();

                switch (action_choose)
                {
                    case "Fouiller":
                        if (m.isSearchDone())
                        {
                            Console.WriteLine($"Vous avez déjà fouillé le {m.name}");
                            break;
                        }
                        m.SearchDone();
                        Monster.search(h);
                        continue;

                    case "Avancer":
                        running = false;   // <-- casse la boucle
                        break;

                    default:
                        Console.WriteLine("Commande inconnue.");
                        break;
                }
            }
            index++;

        }

        Console.WriteLine("Félicitation ! Vous avez vaincu tout les monstres du Dungeon vous pouvez maitnenant continuez votre chemin\nA bientôt !");

    }
}