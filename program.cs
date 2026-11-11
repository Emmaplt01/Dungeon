
using System.Security.Cryptography.X509Certificates;

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

        Console.WriteLine(Messages.HeroName);
        name = Console.ReadLine();
        Hero h = new Hero(name, 200, "Sword");
        Dungeon d = new Dungeon(3);
        d.greetHeros(h);
        while (index <= d.maxRoom)
        {
            Room r = d.getRoom(index);
            r.enterRoom(h);
            Monster m = r.getMonster();
            h.discoverEnnemy(m);
            while (m.getNbLifePoints() > 0)
            {
                m.attack(h);
                if (h.getNbLifePoints() <= 0)
                {
                    Console.WriteLine(Messages.HeroDead);
                    return;
                }
                Console.WriteLine(Messages.HeroBattleChoice(h.Name));
                action_choose = Console.ReadLine();
                switch (action_choose)
                {
                    case "Fouiller":
                        if (fouiller == true)
                        {
                            Console.WriteLine(Messages.RoomAlreadySearch);
                            Console.ReadLine();
                            break;
                        }
                        fouiller = true;
                        h.searchForPotion(r);
                        Console.ReadLine();
                        break;

                    case "Attack":
                        Console.WriteLine(Messages.EffiveWeapon(m.getEffectiveWeaponType()));
                        h.attack(m);
                        Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine(Messages.UnknownCommand);
                        break;
                }

            }
            fouiller = false;
            Console.WriteLine(Messages.MonsterDefeate(m.name));
            while (running)
            {
                Console.WriteLine(Messages.HeroChoice);
                action_choose = Console.ReadLine();

                switch (action_choose)
                {
                    case "Fouiller":
                        if (m.m_bSearchDone == true)
                        {
                            Console.WriteLine(Messages.MonsterAlreadySearch(m.name));
                            break;
                        }
                        m.m_bSearchDone = true;
                        h.searchForPotion(m);
                        continue;

                    case "Avancer":
                        running = false;
                        break;

                    default:
                        Console.WriteLine(Messages.UnknownCommand);
                        break;
                }
            }
            running = true;
            index++;

        }

        Console.WriteLine(Messages.Victory);

    }
}