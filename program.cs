
class Program
{
    static void Main()
    {
        string name;
        string action_choose;
        int index = 1;
        bool fouiller = false;
        Weapon HeroWeapon;


        Console.WriteLine("Quel est votre nom jeune aventurier ?");
        name = Console.ReadLine();
        Hero h = new Hero(name, 200);
        Dungeon d = new Dungeon();
        d.greetHeros(h);
        while (index <= 5)
        {
            Room r = new Room();
            r.enterRoom(h);
            Monster m = r.getMonster();
            h.discoverEnnemy(m);
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
                        Searchable.search(h); //search
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
            Console.WriteLine($"Super ! Vous avez teracé le {m} ! \nQue voulez vous faire: Fouiller ou Avancer");
            action_choose = Console.ReadLine();
            switch (action_choose)
            {
                case "Fouiller":
                    if (m.isSearchDone() == true)
                    {
                        Console.WriteLine($"Vous avez déjà le {m.name}");
                        break;
                    }
                    fouiller = true;
                    Searchable.search(h); //search
                    break;

                case "Avancer":
                    break;

                default:
                    Console.WriteLine("Commande inconnue.");
                    break;

            }
            Console.ReadLine();

            index++;

        }

        Console.WriteLine("Félicitation ! Vous avez vaincu tout les monstres du Dungeon vous pouvez maitnenant continuez votre chemin");

    }
}

