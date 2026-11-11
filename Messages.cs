public static class Messages
{
    public static string RoomEnter(int index)
    {
        return $"Vous entrez dans la salle N° {index}.";
    }
    public const string HeroName = "Quel est votre nom jeune aventurier ?";

    public static string Greet(string heroName)
    {
        return $@"    
               |>>>
               |
    _  _      _|_  _
   |;|_|;|   |;|_|;|
  \\.    .  / .    //
   \\:  .  /  .  //
    ||:   |   . ||
    ||:.  |   . ||
    ||:  .|    :||
    ||:   |   . ||
    ||: , | .  :||
    ||:   |    :||
    ||: . | .  .||
    ||_   |     ||
    || DUNGEON  ||
    ||   ||||   ||
    ||   ||||   ||
    ||___||||___||
    /____/  \____\

Bonjour {heroName}, bienvenu dans le Dungeon !";
    }

    public const string HeroDead = "Vous êtes malheureusement mort ... #RIP";
    public static string HeroBattleChoice(string heroName)
    {
        return $"Que voulez vous faire {heroName} : Fouiller, Attack";
    }

    public static string PotionFound(Item item)
    {
        return $@"Félicitation vous avez trouvé une {item} :     
    !
   |⁑|
   |_|
   ";
    }

    public const string NotFound = "Vous n'avez rien trouvé ici :(";

    public const string RoomAlreadySearch = "Vous avez déjà fouillé cette pièce";

    public const string WeaponChoose = "Quelles armes voulez-vous utiliser ?";

    public const string MissedAttack = "Coup raté !";

    public static string EffiveWeapon(string EffectiveWeaponType)
    {
        return $"Arme efficace : {EffectiveWeaponType}";
    }

    public static string NotEffectiveWeapon(string monster)
    {
        return $"Cette arme est inutile face au {monster}";
    }

    public static string EnemyInRoom(string monster)
    {
        return $"Il y a un {monster} dans la pièce!";
    }

    public static string HealthGained(int value)
    {
        return $"Vous avez gagner + {value} points de vie";
    }

    public static string HealthRemaining(int value)
    {
        return $"Il vous reste {value} points de vie";
    }

    public static string StrengthGained(int value)
    {
        return $"Vous avez gagner en force +{value} ";
    }

    public const string BothPotionsFound = @"Félicitation vous avez trouvé une HealtPotion et une StrengthPotion ! :

    !       !
   |♥|     |#|
   |_|     |_|

   +10 ♥   +20⚔
    ";

    public const string UnknownCommand = "Commande inconnue.";

    public const string CriticalHit = "Coup critique. Dégats x2 !";

    public static string MonsterAttacks(int damage, int value)
    {
        return $@"
⚔══════════════════════════════⚔

Le monstre vous attaques !

Perte : -{damage} ♥

Hero HP : {value + damage} → {value}
           
⚔══════════════════════════════⚔";
    }

    public static string HeroAttacksMonster(int lifePoints)
    {
        return $@"Vous attaquez le monstre :

   O                 (●'◡'●)
  /|\=======>          /|\  Pv : {lifePoints} ♥
  / \                  / \
    ";
    }

    public static string AttackBonus(int bonus)
    {
        return $"Bonus +{bonus}";
    }

    public static string MonsterDefeate(string Monster)
    {
        return $@"
╔════════════════════════════════════════════╗
║                                            ║
       ✦✦✦ {Monster} VAINCU ! ✦✦✦          
║                                            ║
╚════════════════════════════════════════════╝
";
    }

    public const string HeroChoice = "Que voulez vous faire: Fouiller ou Avancer ?";

    public static string MonsterAlreadySearch(string Monster)
    {
        return $"Vous avez déjà fouillé le {Monster}";
    }

    public const string Victory = @"
╔══════════════════════════════════════════════╗
║                                              ║
║           ✦✦✦ VICTOIRE ! ✦✦✦               ║
║                                              ║
║  Vous avez vaincu tous les monstres du       ║
║  Dungeon.                                    ║
║                                              ║
║  Votre aventure continue au-delà de ces      ║
║  murs obscurs...                             ║
║                                              ║
║                À bientôt !                   ║
║                                              ║
╚══════════════════════════════════════════════╝";
}
