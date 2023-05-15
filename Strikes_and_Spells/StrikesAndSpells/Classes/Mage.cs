using System.Net.Mail;
using System;

namespace StrikesAndSpells.Classes
{
    //Mage
    public class Mage : BaseClass
    {
        public Mage(string name = "The name must be chosen by the player") : base(name, "Frost Mage", "Frost bolt - The mage releases an ice spike that deals damage in the amount of 200% of the intelligence index", 2, 4, 2, 10)
        {

        }

        public override int UltimateAbilityTrigger()
        {
            int totalDamage = MagicDamage * 2;            
            Console.WriteLine("{0} cast frost bolt and give {1} damage!", Name, totalDamage);
            return totalDamage;
        }
    }
} 
