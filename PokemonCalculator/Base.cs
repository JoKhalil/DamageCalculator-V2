using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonCalculator
{
    class Base
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        [JsonProperty("Sp. Attack")]
        public int SpAttack { get; set; }

        [JsonProperty("Sp. Defense")]
        public int SpDefense { get; set; }
        public int Speed { get; set; }
    }
}
