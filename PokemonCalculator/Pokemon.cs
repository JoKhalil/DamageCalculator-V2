using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PokemonCalculator
{
    class Pokemon
    {
        private String name;
        private int level;
        private ArrayList moves;
        private int attack;
        private int defense;
        private int spAttack;
        private int spDefense;
        private String type;

        public Pokemon(String name, int level, ArrayList moves, int attack, int defense, int spAttack, int spDefense, String type)
        {
            this.Name = name;
            this.Level = level;
            this.Moves = moves;
            this.Attack = attack;
            this.Defense = defense;
            this.SpAttack = spAttack;
            this.SpDefense = spDefense;
            this.Type = type;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public ArrayList Moves { get => moves; set => moves = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
        public int SpAttack { get => spAttack; set => spAttack = value; }
        public int SpDefense { get => spDefense; set => spDefense = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.moves + " Attack: " + this.attack + " Defense: " 
               + this.defense + " Special Attack: " + this.spAttack + " Special Defense: " + this.spDefense
               + " " + this.type;
        }
    }
}
