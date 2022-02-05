using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgJogo.Herois
{
    public class Heroi
    {

        public Heroi(string Nome, int Level, string typeforc)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.TypeForc = typeforc;
        }
        public string Nome;

        public int Level;
        public string TypeForc;

        public override string ToString()
        {
            return this.Nome + " " + this.Level + " " + this.TypeForc;
            

        }

        public virtual string Attack()
        {
            return this.Nome + " " + "Atacou com a espada";
        }

        
    }
}