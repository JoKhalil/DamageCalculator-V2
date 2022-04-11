using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PokemonCalculator
{
    class Pokemon
    {

        public int id { get; set; }
        public Name name { get; set; }
        public List<string> type { get; set; }
        public Base @base { get; set; }

        /*private List<String> name;
        private int level;
        private List<Move> moves;
        private int attack;
        private int defense;
        private int spAttack;
        private int spDefense;
        private String type;

        public Pokemon(List<String> name, int level, List<Move> moves, int attack, int defense, int spAttack, int spDefense, String type)
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

        public Pokemon(List<String> name, String type)
        {
            this.Name = name;
            this.Type = type;
        }

        public List<String> Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public List<Move> Moves { get => moves; set => moves = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
        public int SpAttack { get => spAttack; set => spAttack = value; }
        public int SpDefense { get => spDefense; set => spDefense = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return this.name[0] + " " + this.level + " " + this.moves + " Attack: " + this.attack + " Defense: " 
               + this.defense + " Special Attack: " + this.spAttack + " Special Defense: " + this.spDefense
               + " " + this.type;
        }*/
    }
}
