using System;

namespace RandomAcrsOfKindness
{
    class Goblin
    {
        private static Random _rng = new Random();

        private int _hitPoints;

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                if (value < 0)
                    return;
                else
                    _hitPoints = value;
            }
        }

        public string Name { get; set; }

        public bool IsDead { get; private set; }

        public void Attack(Goblin victim)
        {
            int damage = _rng.Next(1, 5);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{Name} attacks {victim.Name} for {damage} damage!");
            Console.ReadLine();
            victim.Hit(damage);
        }

        public void Hit(int damage)
        {
            _hitPoints -= damage;

            if (_hitPoints >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{Name} receives {damage} damage. They have {_hitPoints} health.");
                Console.ReadLine();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} receives {damage} damage. They have 0 health.");
                Console.ReadLine();
                Console.WriteLine($"{Name} has died!");
                IsDead = true;
                Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string input;
            int ans;
            
            Console.WriteLine($"You have started the Mother's Day Program: Random Acts of Kindness at {DateTime.Now}!");
            Console.ReadLine();
            Console.WriteLine("Over the next 7 days, please run this program to receive one random act of kindness from your sweetie, Matty Humble!");
            Console.ReadLine();

            Goblin g1 = new Goblin();
            Goblin g2 = new Goblin();

            Console.WriteLine("But first, you will need to defeat Goblin Gus in battle!");
            Console.ReadLine();
            Console.Write("What is your name mighty mom warrior? ");

            g1.Name = Console.ReadLine();
            Console.WriteLine($"\nWelcome {g1.Name}! Let the battle begin!");
            Console.ReadLine();

            g1.HitPoints = 50;

            g2.Name = "Goblin Gus";
            g2.HitPoints = 10;

            int whoseTurn = 1;

            while (!g1.IsDead && !g2.IsDead)
            {
                if (whoseTurn == 1)
                {
                    g1.Attack(g2);
                    whoseTurn = 2;
                }
                else
                {
                    g2.Attack(g1);
                    whoseTurn = 1;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The battles has ended!");
            Console.ReadLine();
            Console.WriteLine("Press enter to claim your prize and roll your random act of kindness!");
            Console.ReadLine();

            while(true)
            {
                kindness();

                if(num == 1)
                {
                    Console.WriteLine("You rolled a FOOT RUB!");
                    Console.ReadLine();
                    Console.WriteLine("You are entitled to one 15 minute foot rub from Matty Humble. Valid today at the moment of your choosing!");
                    Console.ReadLine();
                    verify();
                    
                    if(ans == 1)
                    {
                        break;
                    }
                }

                else if(num==2)
                {
                    Console.WriteLine("You rolled a BACK RUB!");
                    Console.ReadLine();
                    Console.WriteLine("You are entitled to one 15 minute back rub from Matty Humble. Valid today at the moment of your choosing!");
                    Console.ReadLine();
                    verify();

                    if (ans == 1)
                    {
                        break;
                    }
                }

                else if (num == 3)
                {
                    Console.WriteLine("You rolled a CHORE COMPLETION!");
                    Console.ReadLine();
                    Console.WriteLine("Matty Humble will complete a chore of your choosing. Valid today at the moment you deem appropriate!");
                    Console.ReadLine();
                    verify();

                    if (ans == 1)
                    {
                        break;
                    }
                }

                else if (num == 4)
                {
                    Console.WriteLine("You rolled ALONE TIME!");
                    Console.ReadLine();
                    Console.WriteLine("You are entitled to 2 hours of alone time today. Valid at the moment of your choosing!");
                    Console.ReadLine();
                    verify();

                    if (ans == 1)
                    {
                        break;
                    }
                }

                else if (num == 5)
                {
                    Console.WriteLine("You rolled A WELL COOKED MEAL!");
                    Console.ReadLine();
                    Console.WriteLine("You are entitled to have Matty Humble cook you a meal of your choosing. Valid whenever you are hungry!");
                    Console.ReadLine();
                    verify();

                    if (ans == 1)
                    {
                        break;
                    }
                }

                else if (num == 6)
                {
                    Console.WriteLine("You rolled THURSDAY NIGHT PICNIC!");
                    Console.ReadLine();
                    Console.WriteLine("Matty Humble will prepare and take you on a Thursday Night Picnic. Valid a Thursday of your choosing!");
                    Console.ReadLine();
                    verify();

                    if (ans == 1)
                    {
                        break;
                    }
                }

                else if (num == 7)
                {
                    Console.WriteLine("You rolled a WINE AND MOVIE NIGHT!");
                    Console.ReadLine();
                    Console.WriteLine("You are entitled to one wine and movie night with your sugar, Matty Humble. You pick the wine and the movie! Kids will stay with Papa and Gigi!");
                    Console.ReadLine();
                    verify();

                    if (ans == 1)
                    {
                        break;
                    }
                }
            }
            
            int kindness()
            {
                Random rng = new Random();
                num = rng.Next(1, 8);
                return num;
            }

            int verify()
            {
                while (true)
                {
                    Console.Write("Enter 1 to keep your current gift or 2 to roll again: ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out ans))
                    {
                        if (ans == 1)
                        {
                            Console.WriteLine("\nCongratulations on your fabulous prize! We love you! See you tomorrow (unless this is day 7)!");
                            Console.ReadLine();
                            break;
                        }

                        else if (ans == 2)
                        {
                            Console.WriteLine("\nVery well, we will roll again! Press enter to continue.");
                            Console.ReadLine();
                            break;
                        }

                        else
                        {
                            Console.WriteLine("\nYou did not enter a number between 1 and 2. Please try again!");
                            Console.ReadLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nYou did not enter a valid value. Please try again.");
                        Console.ReadLine();
                    }
                }
                return ans;
            }

        }
    }
}
