using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo1.src.Model
{
    public class Topapa : Personagens
    {
        public Topapa (string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Poder Invisivel...";
        }
    }
}