using PokemonBattle.pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Charmander : Pokemon
    {
        public Charmander()
        {
            this.name = "Charmander";
            Random random = new Random();
            //random number between >= min and <max (value etc)
            this.HP = random.Next(188, 282);
            this._image = Properties.Resources._004;
            this.Attack = random.Next(98, 223);
            this.Defense = random.Next(81, 203);
        }
    }
}
