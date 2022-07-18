// See https://aka.ms/new-console-template for more information
using System;
using jogo1.src.Model;

namespace jogo1
{
    class Program
    {
        static void Main( string[] args )
        {
           Arus hero  =  new  Arus("Arus", 23, " ..Knight");           
           Wizard w = new Wizard ( "Jennica", 23, "..white Wizard");
           Wedge eg = new Wedge ( " wedge", 43, "..Ninja");
           Topapa t = new Topapa ( "topapa", 53, "..black Wizard");
           
           
            Console.WriteLine("--------@@@@ -----");
            Console.WriteLine(hero.ToString());
            Console.WriteLine(hero.Attack());
            Console.WriteLine(hero.Attack(7));
            Console.WriteLine("--------@@@@ -----");
            Console.WriteLine("-    - ");
            Console.WriteLine("--------@@@@ -----");
            Console.WriteLine( w.ToString());
            Console.WriteLine( w.Attack());
            Console.WriteLine( w.Attack(4));
            Console.WriteLine("--------@@@@ -----");
            Console.WriteLine("-    - ");
            Console.WriteLine("--------@@@@ -----");
            Console.WriteLine( eg.ToString());
            Console.WriteLine( eg.Attack());
            Console.WriteLine( eg.Attack(17));
            Console.WriteLine("--------@@@@ -----");
              Console.WriteLine("-    - ");
            Console.WriteLine("--------@@@@ -----");
            Console.WriteLine( t.ToString());
            Console.WriteLine( t.Attack());
            Console.WriteLine( t.Attack(2));
            Console.WriteLine("--------@@@@ -----");


        }
    }
}

