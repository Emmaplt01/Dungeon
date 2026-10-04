
class Program
{
    static void Main()
    {
        string name;
        string action_choose;
        int index = 1;
        bool fouiller = false;


        Console.WriteLine("Quel est votre nom jeune aventurier ?");
        name = Console.ReadLine();
        Hero h = new Hero(name, 200, 20);
        Dungeon d = new Dungeon();
        d.greetHeros(h);
        while (index <= 5)
        {
            Room r = new Room(index);
            r.enterRoom(h);
            Monster m = r.getMonster();
            while (m.LifePoints > 0)
            {
                m.attack(h);
                if (h.LifePoints <= 0)
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
                        h.SelectWeaponFromArsenal(Console.ReadLine());
                        h.attack(m);
                        Console.WriteLine($"Vous avez attaqué le {m} il lui reste {m.LifePoints} points ");
                        break;

                    default:
                        Console.WriteLine("Commande inconnue.");
                        break;
                }

                //riposte qui peut être demeander bonus, attaque, voir

            }
            fouiller = false;
            Console.WriteLine($"Super ! Vous avez teracé le {m} ! \nVous pouvez passer à la prochaine pièce ->");
            Console.ReadLine();

            index++;

        }

        Console.WriteLine("Félicitation ! Vous avez vaincu tout les monstres du Dungeon vous pouvez maitnenant continuez votre chemin");

    }
}

