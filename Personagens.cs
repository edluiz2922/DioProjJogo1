using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo1.src.Model
{
    public abstract class Personagens
    {  
        public string ?Name {get; set;}

        public int Level {get; set;}

        public string ?HeroType {get; set;}

      

        public override string ToString(){
            return this.Name + " " +  this.Level + this.HeroType;
        }

         public virtual string Attack(){
            return this.Name + " Atacou com a sua espada...";
        }
        
        public virtual string Attack( int Bonus)
          { 
                if (Bonus > 6) {
                      return this.Name + $" Ganhou bonus de {Bonus}...";
                }else {
                      return this.Name +  $"  Perdeu bonus de {Bonus}...";
                }        
            }  
   

        
    }
}