using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class GameCharacter
    {
        private string Name;
        public string name { get; set; }
        
        
       

        private int Str;
        public int str { get; set; }
        

        private int Int;
        public int _int { get; set; }
       
        
        public virtual void Play()
        {
            Console.WriteLine($"This character is {Name} and their stats are: \nInt: {Int}\nStr:{Str}");
        }
    }
    class Warrior : GameCharacter
    {
        private string WepType;
        public string weptype { get; set; }
        
        public override void Play()
        {
            Console.WriteLine($"This character is {name} and their stats are: \nInt: {_int}\nStr:{str}\nAnd their weapon is a {weptype}.");
        }
    }
    class MagicUsingCharacter : GameCharacter
    {
        private int MagicEnergy;
        public int magicenergy { get; set; }
        
        public override void Play()
        {
            Console.WriteLine($"This character is {name} and their stats are: \nInt: {_int}\nStr:{str}\nThey have {magicenergy} MP.");
        }
    }
    class Wizard : MagicUsingCharacter
    {
       
        private int SpellCount;
        public int spellcount { get; set; }
        
        public override void Play()
        {
            Console.WriteLine($"This character is {name} and their stats are: \nInt: {_int}\nStr:{str}\nThey have {spellcount} spell slots and {magicenergy} mp.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Warrior war1 = new Warrior();
            Warrior war2 = new Warrior();
            Wizard w1 = new Wizard();
            Wizard w2 = new Wizard();
            Wizard w3 = new Wizard();
            war1.name = "Fred";
            war1.str = 100;
            war1.weptype = "Sword";
            war1._int = 10;
            war1.Play();
            war2.name = "Frank";
            war2.str = 10;
            war2.weptype = "Axe";
            war2._int = 8;
            war2.Play();
            w1.name = "Edmund";
            w1.str = 5;
            w1._int = 30;
            w1.magicenergy = 100;
            w1.spellcount = 10;
            w1.Play();
            w2.name = "Frances";
            w2.str = 8;
            w2._int = 50;
            w2.magicenergy = 100;
            w2.spellcount = 15;
            w2.Play();
            w3.name = "Holly";
            w3.str = 6;
            w3._int = 45;
            w3.magicenergy = 100;
            w3.spellcount = 16;
            w3.Play();
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(w1);
            gameCharacters.Add(w2);
            gameCharacters.Add(w3);
            gameCharacters.Add(war1);
            gameCharacters.Add(war2);
            foreach (GameCharacter next in gameCharacters)
            {
                next.Play();
            }

        }
    }
}
