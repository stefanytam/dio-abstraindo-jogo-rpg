using DIO___Jogo___RPG.scr.Entities;
using System;

namespace DIO___Jogo___RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",23, "Knight");
            Wizard jennica = new Wizard("Jenicca", 23, "White wizard");
            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(arus.Attack(7));
            Console.ReadKey();
        }
    }
}
