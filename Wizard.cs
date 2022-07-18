using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo1.src.Model
{
    public class Wizard : Personagens
    {
         public Wizard (string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Lançou com a sua Magia...";
        }
        
    }
}