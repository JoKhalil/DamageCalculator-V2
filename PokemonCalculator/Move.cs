using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace PokemonCalculator
{
    [Serializable]
    class Move
    {
        

        private String name;
        private String type;
        private int power;
        private ArrayList category;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int PowerPoint { get => power; set => power = value; }
        public ArrayList Category { get => category; set => category = value; }

        public Move(ArrayList category, String name, String type, int power)
        {
            
            this.name = name;
            this.type = type;           
            this.category = category;
            this.power = power;
        }

        public class Root
        {
            public List<Move> Move { get; set; }
        }
    }
}
