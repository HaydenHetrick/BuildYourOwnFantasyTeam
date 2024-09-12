using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnFantasyTeam
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Character> team = new List<Character>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nFantasy Team Builder");
                Console.WriteLine("1. Add Character");
                Console.WriteLine("2. Display Team");
                Console.WriteLine("3. Remove Character");
                Console.WriteLine("4. Display Team Stats");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCharacter(team);
                        break;
                    case "2":
                        DisplayTeam(team);
                        break;
                    case "3":
                        RemoveCharacter(team);
                        break;
                    case "4":
                        DisplayTeamStats(team);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void AddCharacter(List<Character> team)
        {
            Console.Write("Enter character type (Warrior/Mage/Archer): ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter character name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Health: ");
            int health = int.Parse(Console.ReadLine());

            Console.Write("Enter Strength: ");
            int strength = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "warrior":
                    Console.Write("Enter Armor: ");
                    int armor = int.Parse(Console.ReadLine());
                    team.Add(new Warrior(name, health, strength, armor));
                    break;

                case "mage":
                    Console.Write("Enter Mana: ");
                    int mana = int.Parse(Console.ReadLine());
                    team.Add(new Mage(name, health, strength, mana));
                    break;

                case "archer":
                    Console.WriteLine("Enter Range: ");
                    int range = int.Parse(Console.ReadLine());
                    team.Add(new Archer(name, health, strength, range));
                    break;

                default:
                    Console.WriteLine("Invalid character type");
                    break;


            }
        }

        static void DisplayTeam(List<Character> team)
        {
            foreach (var character in team)
            {
                character.DisplayInfo();
            }
        }
        static void RemoveCharacter(List<Character> team)
        {
            Console.Write("Enter character name to remove: ");
            string name = Console.ReadLine();

            Character character = team.FirstOrDefault(c => c.Name == name);

            if (character != null)
            {
                team.Remove(character);
                Console.WriteLine($"{name} removed from team");
            }
            else
            {
                Console.WriteLine($"{name} not found in team");
            }
        }

        static void DisplayTeamStats(List<Character> team)
        {
            int totalHealth = 0;
            int totalStrength = 0;

            foreach (var character in team)
            {
                totalHealth += character.Health;
                totalStrength += character.Strength;
            }

            Console.WriteLine($"Total Health: {totalHealth}");
            Console.WriteLine($"Total Strength: {totalStrength}");
        }
    }
}