using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgJogo.Herois
{
    public class Knight : Heroi
    {
        public Knight(string Nome, int Level, string typeforc) : base(Nome, Level, typeforc)
        {
              this.Nome = Nome;
            this.Level = Level;
            this.TypeForc = typeforc;
        }
    }
}