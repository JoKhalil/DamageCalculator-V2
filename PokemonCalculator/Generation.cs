using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonCalculator
{
    class Generation
    {
        private int gen;
        private double crit;

        public int Gen { get => gen; set => gen = value; }
        public double Crit { get => crit; set => crit = value; }

        public Generation(int gen, double crit)
        {
            this.gen = gen;
            this.crit = crit;
        }
    }
}
