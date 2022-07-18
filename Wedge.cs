using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo1.src.Model
{
    public class Wedge : Personagens
    {
        public Wedge (string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Ataque ozotogari...";
        }
    }
}