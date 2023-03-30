using PokemonBattle.pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Venusaur : Pokemon
    {
        public Venusaur()
        { 
            this.name = "Venusaur";
            Random random = new Random();
            //random number between >= min and <max (value etc)
            this.HP = random.Next(270, 364);
            this._image = Properties.Resources._003;
            this.Attack = random.Next(152, 289);
            this.Defense = random.Next(153, 291);
        }
    }
}
