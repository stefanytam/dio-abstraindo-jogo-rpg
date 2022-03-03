using System;
using System.Collections.Generic;
using System.Text;

namespace DIO___Jogo___RPG.scr.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }

        public override string Attack()
        {
            return Name + " Atacaou com sua magia!!";
        }
        public string Attack(int Bonus)
        {
            return Name + " Atacaou com sua magia, com bonus de ataque de " + Bonus;
        }
    }
}
