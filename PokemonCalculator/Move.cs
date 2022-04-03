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
        private int powerPoint;
        private ArrayList category;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int PowerPoint { get => powerPoint; set => powerPoint = value; }
        public ArrayList Category { get => category; set => category = value; }

        public Move(String name, String type, int powerPoint, ArrayList category)
        {
            this.name = name;
            this.type = type;
            this.powerPoint = powerPoint;
            this.category = category;
        }

        public ArrayList jsonToMoves()
        {
            
        }
    }
}
