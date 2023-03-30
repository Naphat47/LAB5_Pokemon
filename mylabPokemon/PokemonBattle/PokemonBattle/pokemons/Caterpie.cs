using PokemonBattle.pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Caterpie : Pokemon
    {
        public Caterpie()
        {
            this.name = "Caterpie";
            Random random = new Random();
            //random number between >= min and <max (value etc)
            this.HP = random.Next(200, 294);
            this._image = Properties.Resources._010;
            this.Attack = random.Next(58, 174);
            this.Defense = random.Next(67, 185);
        }
    }
}
