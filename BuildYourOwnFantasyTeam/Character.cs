using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnFantasyTeam
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }

        public Character(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }


        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Strength: {Strength}");
        }
    }

    public class Warrior : Character
    {
        public int Armor { get; set; }

        public Warrior(string name, int health, int strength, int armor)
            : base(name, health, strength)
        {
            Armor = armor;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Armor: {Armor}");
        }

        public void UseSpecialAbility()
        {
            Console.WriteLine("Warrior uses special ability");
        }
    }

    public class Mage : Character
    {
        public int Mana { get; set; }

        public Mage(string name, int health, int strength, int mana)
            : base(name, health, strength)
        {
            Mana = mana;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Mana: {Mana}");
        }

        public void UseSpecialAbility()
        {
            Console.WriteLine("Mage uses special ability");
        }
    }

    public class Archer : Character
    {
        public int Range { get; set; }

        public Archer(string name, int health, int strength, int range)
            : base(name, health, strength)
        {
            Range = range;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Range: {Range}");
        }

        public void UseSpecialAbility()
        {
            Console.WriteLine("Archer uses special ability");
        }
    }
}
