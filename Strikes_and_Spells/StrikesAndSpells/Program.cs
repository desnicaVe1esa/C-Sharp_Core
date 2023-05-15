using System;
using StrikesAndSpells.Classes;

namespace StrikesAndSpells
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
        }
        //Method paint main menu
        static void PrintMenu()
        {
            //Menu
            Console.Clear();
            Console.WriteLine("GAME \"Strikes and Spells\"\n");
            Console.WriteLine("1 - Start");
            Console.WriteLine("2 - Help");
            Console.WriteLine("3 - Exit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                GameProcess gameProcess = new GameProcess();
                gameProcess.StartGame();
            }

            if (option == "2")
                Help();


            if (option == "3")
                return;//Declare the fulfillment of the condition under which the infinite loop will be interrupted


            //Recursion in action
            PrintMenu();

            //Environment.Exit(0);
        }

        //Method outputs the rules of the game to the console
        static void Help()
        {
            Console.Clear();
            Console.WriteLine(new Warrior());
            Console.WriteLine(new Rogue());
            Console.WriteLine(new Mage());
            Console.WriteLine("\nEach fighter has four characteristics - strength, agility, endurance and intelligence. " +
" Strength affects the damage done, agility affects the chance to dodge an opponent's blow, endurance affects the number of lives scored, intelligence affects magic damage. " +
"Also, each fighter has a special skill that he uses in battle. " +
string.Format("Before the start of the battle, players choose their fighters and distribute {0} skill points among three characteristics, thereby affecting certain indicators of the fighter. ", Constanta.pointsNumber) +
string.Format("+1 strength = +{0} damage, +1 dexterity = +{1} % dodge a blow, +1 survivability = +{2} HP, +1 intelligence = +{3} magic damage ", Constanta.damageMultiplier, Constanta.dodgeChanceMultiplier, Constanta.hpMultiplier, Constanta.magicDamageMultiplier) +
"The fight consists of rounds. In each round, the fighters inflict direct damage to each other and use a special skill once. " +
"The number of rounds depends on the life points of the fighters. As soon as one of the fighters runs out of lives, the fight stops.");
            Console.ReadLine();
        }
    }
}
