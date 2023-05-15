using System;

namespace StrikesAndSpells.Classes
{
    //Warrior
    public class Warrior : BaseClass
    {
        public Warrior(string name = "The name must be chosen by the player" ) : base(name, "Fury Warrior", "Stun - Every fourth attack take 200% damage and stuns the opponent for 2 seconds", 6, 4, 6, 2)
        {
            
        }
        
        public override int UltimateAbilityTrigger()
        {
            int totalDamage = Strenght * 2;
            Console.WriteLine("{0} give stun for 2 sec and {1} damage", Name, totalDamage);
            return totalDamage;
        }
    }
}