﻿using PokemonBattle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle.pokemons
{
    internal class Ivysaur : Pokemon
    {
        public Ivysaur()
        { 
            this.name = "Ivysaur";
            Random random = new Random();
            //random number between >= min and <max (value etc)
            this.HP = random.Next(230, 324);
            this._image = Properties.Resources._002;
            this.Attack = random.Next(116, 245);
            this.Defense = random.Next(117, 247);
        }
    }
}
