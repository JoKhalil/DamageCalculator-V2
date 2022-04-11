using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;

namespace PokemonCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            

            InitializeComponent();
            jsonToMove();
            jsonToPokemon();

        }

        public void jsonToPokemon()
        {
            List<Pokemon> pokemonsList = new List<Pokemon>();

            String jsonString = File.ReadAllText(@"C:\Users\Zouz\source\repos\PokemonCalculator\PokemonCalculator\json\pokemons.json");

            JObject jsonParse = JObject.Parse(jsonString);

            JArray jsonArray = (JArray)jsonParse["Pokemon"];

            pokemonsList = jsonArray.ToObject<List<Pokemon>>();

            foreach (var pokemons in pokemonsList)
            {
                comboBoxPokemons.Items.Add(pokemons.name.english);
            }
        }


        public void jsonToMove()
        {
            List<Move> movesList = new List<Move>();

            String jsonString = File.ReadAllText(@"C:\Users\Zouz\source\repos\PokemonCalculator\PokemonCalculator\json\moves.json");

            JObject jsonParse = JObject.Parse(jsonString);

            JArray jsonArray = (JArray)jsonParse["Move"];

            movesList = jsonArray.ToObject<List<Move>>();

            //listBoxPokemons.DataSource = movesList;

            foreach (var moves in movesList)
            {
                if (moves.Name != null)
                {
                    


                    comboBoxMoves1.Items.Add(moves.Name);
                    comboBoxMoves2.Items.Add(moves.Name);
                    comboBoxMoves3.Items.Add(moves.Name);
                    comboBoxMoves4.Items.Add(moves.Name);
                }
                
            }


            //return movesList;
        }
    }
}
