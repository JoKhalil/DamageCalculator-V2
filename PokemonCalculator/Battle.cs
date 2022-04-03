using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PokemonCalculator
{
    class Battle
    {
        private int targetNumber;
        private ArrayList weather;

        public int TargetNumber { get => targetNumber; set => targetNumber = value; }
        public ArrayList Weather { get => weather; set => weather = value; }

        public Battle (int targetNumber, ArrayList weather)
        {
            this.targetNumber = targetNumber;
            this.weather = weather;
        }
    }
}
