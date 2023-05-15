using System;

namespace StrikesAndSpells.Classes
{
    //Rogue
    public class Rogue : BaseClass
    {
        public Rogue(string name = "The name must be chosen by the player") : base(name, "Subtlety Rogue", "Сritical hit - With a probability of 20%, the rogue can strike with a weapon in the second hand equal to 400% of agility", 8, 8, 2, 2)
        {

        }

        public override int UltimateAbilityTrigger()
        {
            int chance = random.Next(1, 101);
            if(chance <= 20)
            {
                int totalDamage = Damage * 4;
                Console.WriteLine("{0} give a critical hit {1} damage", Name, totalDamage);
                return totalDamage;
            }
            Console.WriteLine("{0} give a critical hit, but enemy is evade!", Name);
            return 0;            
        }
    }
}
