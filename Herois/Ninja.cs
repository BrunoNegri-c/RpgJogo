using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgJogo.Herois
{
    public class Ninja : Heroi
    {
        public Ninja(string Nome, int Level, string typeforc) : base(Nome, Level, typeforc)
        {
             this.Nome = Nome;
            this.Level = Level;
            this.TypeForc = typeforc;
        }

         public override string Attack()
        {
            return this.Nome + " " + "Lançou Magia";
        }

        public string  Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                 return this.Nome + " " + "Lançou magia super efetiva com bonus de ataque de " + Bonus;
            }
            else{
                return this.Nome + " " + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
           
        }

        
    }
}