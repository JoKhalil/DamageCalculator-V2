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
        private String category;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Power { get => power; set => power = value; }
        public String Category { get => category; set => category = value; }

        public Move(String category, String name, String type, int power)
        {
            
            this.name = name;
            this.type = type;           
            this.category = category;
            this.power = power;
        }

    }
}
