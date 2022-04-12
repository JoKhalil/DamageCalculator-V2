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
                switch (move.Category)
                {
                    case "Physical":
                        pictureBoxCategory1.Image = null;
                        //pictureBoxCategory1.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Physical.JPG";
                        pictureBoxCategory1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case "Status":
                        pictureBoxCategory1.Image = null;
                        pictureBoxCategory1.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Status.JPG";
                        pictureBoxCategory1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case "Special":
                        pictureBoxCategory1.Image = null;
                        pictureBoxCategory1.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Special.JPG";
                        pictureBoxCategory1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    default:
                        break;
                }


                /*if (move.Category.Equals("Physical"))
                {
                    pictureBoxCategory1.ImageLocation = null;
                    pictureBoxCategory1.InitialImage = null;
                    pictureBoxCategory1.Dispose();
                    pictureBoxCategory1.Refresh();
                    //pictureBoxCategory1.Update();
                    pictureBoxCategory1.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Physical.JPG";
                    pictureBoxCategory1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (move.Category.Equals("Status"))
                {
                    pictureBoxCategory1.ImageLocation = null;
                    pictureBoxCategory1.InitialImage = null;
                    pictureBoxCategory1.Dispose();
                    pictureBoxCategory1.Refresh();
                    //pictureBoxCategory1.Update();
                    pictureBoxCategory1.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Status.JPG";
                    pictureBoxCategory1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (move.Category.Equals("Special"))
                {
                    pictureBoxCategory1.ImageLocation = null;
                    pictureBoxCategory1.InitialImage = null;
                    pictureBoxCategory1.Dispose();
                    pictureBoxCategory1.Refresh();
                    //pictureBoxCategory1.Update();
                    pictureBoxCategory1.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Special.JPG";
                    pictureBoxCategory1.SizeMode = PictureBoxSizeMode.StretchImage;
                }*/
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
