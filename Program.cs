using System;
using RpgJogo.Herois;

namespace RpgJogo
{
    class Program
    {
        static void Main(string[] args)
        {
           Heroi a1 = new Heroi("Arus" , 29 , "Guerreiro");
           Ninja a2 = new Ninja("Jenica", 32 , "Ninja");


            Console.WriteLine(a2.Attack(1));
             Console.WriteLine(a2.Attack(7));
        
        }
    }
}
