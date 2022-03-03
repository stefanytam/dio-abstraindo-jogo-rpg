using System;
using System.Collections.Generic;
using System.Text;

namespace DIO___Jogo___RPG.scr.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public string Attack(int Bonus)
        {
            return Name + " Atacaou com sua espada com bonus de ataque de " + Bonus;
        }
    }
}
