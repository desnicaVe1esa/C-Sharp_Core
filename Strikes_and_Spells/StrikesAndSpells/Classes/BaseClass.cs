using System.Reflection.Metadata;
using System;

namespace StrikesAndSpells.Classes
{
    public abstract class BaseClass
    {
        protected Random random;//random number generator

        //class members
        public event Action IsDead;//Character is dead

        public string Name { get; private set; }
        public string ClassDescription { get; private set; }
        public string UltimateAbilityDescription { get; private set; }

        private int strenght;
        public int Strenght
        {
            get { return strenght; }
            set
            {
                strenght = value;
                Damage = value * Constanta.damageMultiplier;
            }
        }
        public int Damage { get; private set; }

        private int agility;
        public int Agility
        {
            get { return agility; }
            set
            {
                agility = value;
                DodgeChance = value * Constanta.dodgeChanceMultiplier;
            }
        }
        public int DodgeChance { get; private set; }

        private int stamina;
        public int Stamina
        {
            get { return stamina; }
            set
            {
                stamina = value;
                HP = value * Constanta.hpMultiplier;
            }
        }
        private int hp;
        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;
                if (hp < 0)
                {
                    hp = 0;
                    if(IsDead != null)
                    IsDead();
                }
            }
        }


        private int intelligence;
        public int Intelligence
        {
            get { return intelligence; }
            set
            {
                intelligence = value;
                MagicDamage = value * Constanta.magicDamageMultiplier;
            }
        }



        public int MagicDamage { get; private set; }

        protected BaseClass(string name, string classDescription, string ultimateAbilityDescription, int strenght, int agility, int stamina, int intelligence)//class constructor
        {
            random = new Random();
            Name = name;
            ClassDescription = classDescription;
            UltimateAbilityDescription = ultimateAbilityDescription;
            Strenght = strenght;
            Agility = agility;
            Stamina = stamina;
            Intelligence = intelligence;
        }

        public int Attack()
        {
            int totalDamage = random.Next(Damage - 10, Damage + 11);
            Console.WriteLine("{0} attack and give {1} damage", Name, Damage);
            return totalDamage;
        }

        public abstract int UltimateAbilityTrigger();

        public override string ToString()
        {
            return $"Name: {Name}\nClass: {ClassDescription}\nStrenght: {Strenght}\tAgility: {Agility}\t\tStamina: {Stamina}\tInelligence: {Intelligence}\nDamage: {Damage}\tDodge chance: {DodgeChance}\tHP: {HP}\t\tMagic damage: {MagicDamage}\nUltimate abillity trigger: {UltimateAbilityDescription}";
        }
    }
}