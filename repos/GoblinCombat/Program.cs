using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinCombat
{
    class Goblin
    {
        private static Random _rng = new Random();

        private int _hitPoints;

        public int HitPoints
        {
            get { return _hitPoints;  }
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
            Goblin g1 = new Goblin();
            Goblin g2 = new Goblin();

            Console.WriteLine("But first, you will need to defeat Goblin Gus in battle!");
            Console.ReadLine();
            Console.Write("What is your name mighty mom warrior? ");

            g1.Name = Console.ReadLine();
            g1.HitPoints = 50;

            g2.Name ="Goblin Gus";
            g2.HitPoints = 10;

            int whoseTurn = 1;

            while(!g1.IsDead && !g2.IsDead)
            {
                if(whoseTurn == 1)
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
            Console.WriteLine("The battles is ended!");
            Console.ReadLine();
        }
    }
}
