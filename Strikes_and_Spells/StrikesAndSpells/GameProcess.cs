using System;
using StrikesAndSpells.Classes;

namespace StrikesAndSpells
{
    public class GameProcess
    {
        private Random random;
        private BattleState battleState;
        private BaseClass player1;
        private BaseClass player2;

        public GameProcess()
        {
            random = new Random();
            battleState = BattleState.NextRound;
        }

        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Player 1 create new character:\n");
            player1 = CreateCharacter();
            Console.Clear();
            Console.WriteLine("Player 2 create new character:\n");
            player2 = CreateCharacter();
            StartBattle();
        }

        private BaseClass CreateCharacter()
        {
            BaseClass character;
            int points = Constanta.pointsNumber;

            Console.WriteLine("Name the character:");
            string name = Console.ReadLine();

            Console.WriteLine("\nSelect a class:\n1: Warrior\n2: Rogue\n3: Mage");
            string characterType = Console.ReadLine();

            switch (characterType)
            {
                case "1":
                    character = new Warrior(name);
                    break;
                case "2":
                    character = new Rogue(name);
                    break;
                default:
                    character = new Mage(name);
                    break;
            }

            while (points > 0)
            {
                Console.Clear();
                Console.WriteLine(character);
                Console.WriteLine("Distribute skill points:");
                Console.WriteLine("+1 Strenght:        +{0} damage", Constanta.damageMultiplier);
                Console.WriteLine("+1 Agility:         +{0}% dodge chance", Constanta.dodgeChanceMultiplier);
                Console.WriteLine("+1 Stamina:         +{0} HP", Constanta.hpMultiplier);
                Console.WriteLine("+1 Intelligence:    +{0} magic damage", Constanta.magicDamageMultiplier);
                Console.WriteLine();
                Console.WriteLine("Points left: {0}", points);
                Console.WriteLine("1: +1 Strenght");
                Console.WriteLine("2: +1 Agility");
                Console.WriteLine("3: +1 Stamina");
                Console.WriteLine("4: +1 Intelligence");
                switch (Console.ReadLine())
                {
                    case "1":
                        character.Strenght += 1;
                        break;
                    case "2":
                        character.Agility += 1;
                        break;
                    case "3":
                        character.Stamina += 1;
                        break;
                    default:
                        character.Intelligence += 1;
                        break;
                }
                points -= 1;
            }
            character.IsDead += () => battleState = BattleState.Stopped;
            return character;
        }
        private void StartBattle()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine("{0}...", i);
                Console.ReadLine();
            }
            int round = 1;
            while (battleState == BattleState.NextRound)
            {
                Console.Clear();
                Console.WriteLine("ROUND {0}...\n", round);

                CalculateDamage(player1, player2);
                CalculateDamage(player2, player1);

                Console.WriteLine();
                Console.WriteLine("PLAYER 1:");
                Console.WriteLine(player1);
                Console.WriteLine();
                Console.WriteLine("PLAYER 2:");
                Console.WriteLine(player2);

                Console.ReadLine();
                round += 1;               
            }
            Console.WriteLine("Battle is finished!");
            Console.ReadLine();
        }
        private void CalculateDamage(BaseClass agr, BaseClass victim)
        {
            if(victim.DodgeChance > random.Next(1, 101))
            {
                Console.WriteLine("{0} want strike, but enemy is evade!", agr.Name);
            }
            else
            {
                victim.HP -= agr.Attack();
                //Console.WriteLine("");
                victim.HP -= agr.UltimateAbilityTrigger();
                //Console.WriteLine("");
            }
        }
    }
}