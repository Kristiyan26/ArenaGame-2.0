using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            Hero firstHero = RandomHero();
            Hero secondHero = RandomHero();
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = firstHero,
                HeroB = secondHero,
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            Console.WriteLine($"{firstHero.Name} picked {firstHero.Weapon.Name}");
            Console.WriteLine($"{secondHero.Name} picked {secondHero.Weapon.Name}");
            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }

        static Hero RandomHero()
        {
            Hero hero = null;
            Random random = new Random();
            int randomNum = random.Next(1, 5);
            switch (randomNum)
            {
                case 1:
                    hero = new Assassin("Assassin", 18, 5, RandomWeapon());
                    break;
                case 2:
                    hero = new Gladiator("Gladiator", 21, 10, RandomWeapon());
                    break;
                case 3:
                    hero = new Dwarf("Dwarf", 14, 9, RandomWeapon());
                    break;
                case 4:
                    hero = new Knight("Knight", 16, 13, RandomWeapon());
                    break;

            }
            return hero;
        }
        static IWeapon RandomWeapon()
        {
            IWeapon weapon = null;
            Random random = new Random();
            int randomNum = random.Next(1, 6);
            switch (randomNum)
            {
                case 1:
                    weapon = new Dagger("Dagger");
                    break;
                case 2:
                    weapon = new Spear("Spear");
                    break;
                case 3:
                    weapon = new Axe("Axe");
                    break;
                case 4:
                    weapon = new Sword("Sword");
                    break;
                case 5:
                    weapon = new Crossbow("Crossbow");
                    break;
            }
            return weapon;
        }
    }
}