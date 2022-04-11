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
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        private List<Move> movesList = new List<Move>();

        public Form1()
        {
            

            InitializeComponent();
            jsonToMove();
            jsonToPokemon();

        }

        public void jsonToPokemon()
        {
            

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

        private void comboBoxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var pokemon in pokemonsList)
            {
                if (comboBoxPokemons.SelectedItem.Equals(pokemon.name.english))
                {
                    richTextBoxPokemon.Text += "Hp: " + pokemon.@base.HP.ToString() + "\nAttack: " + pokemon.@base.Attack.ToString()
                        + "\nDefense: " + pokemon.@base.Defense.ToString() + "\nSp. Attack: " + pokemon.@base.SpAttack.ToString()
                        + "\nSp. Defense: " + pokemon.@base.SpDefense.ToString() + "\nSpeed: " + pokemon.@base.Speed.ToString();
                    
                }
            }
        }

        private void comboBoxMoves1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var move in movesList)
            {
                if (comboBoxMoves1.SelectedItem.Equals(move.Name))
                {
                    richTextBoxPokemon.Text += move.Name + move.PowerPoint + move.Category + move.Type;

                }
            }
        }

        private void comboBoxMoves2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMoves3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMoves4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
