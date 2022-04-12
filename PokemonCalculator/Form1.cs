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
                    richTextBoxPokemon.Text = "Hp: " + pokemon.@base.HP.ToString() + "\nAttack: " + pokemon.@base.Attack.ToString()
                        + "\nDefense: " + pokemon.@base.Defense.ToString() + "\nSp. Attack: " + pokemon.@base.SpAttack.ToString()
                        + "\nSp. Defense: " + pokemon.@base.SpDefense.ToString() + "\nSpeed: " + pokemon.@base.Speed.ToString();

                    pictureBoxPokemon.ImageLocation = "https://img.pokemondb.net/sprites/sword-shield/icon/" + pokemon.name.english.ToLower() + ".png";
                }
            }
        }

        public void moveDetailsCategory(ComboBox combo, PictureBox picture, PictureBox pictureType, Button button, Label label)
        {
            foreach (var move in movesList)
            {
                if (combo.SelectedItem.Equals(move.Name))
                {
                    label.Text = move.Power.ToString();

                    switch (move.Category)
                    {
                        case "Physical":
                            picture.Image = null;
                            picture.Update();
                            picture.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Physical.JPG";
                            picture.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Status":
                            picture.Image = null;
                            picture.Update();
                            picture.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Status.JPG";
                            picture.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Special":
                            picture.Image = null;
                            picture.Update();
                            picture.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Special.JPG";
                            picture.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        default:
                            break;
                    }
                    
                    switch (move.Type)
                    {
                        case "Bug":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Bug.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Dark":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Dark.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Dragon":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Dragon.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Electric":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Electric.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Fairy":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Fairy.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Fighting":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Fighting.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Fire":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Fire.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Flying":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Flying.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Ghost":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Ghost.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Grass":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Grass.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Ground":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Ground.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Ice":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Ice.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Normal":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Normal.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Poison":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Poison.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Psychic":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Psychic.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Rock":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Rock.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Steel":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Steel.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;

                        case "Water":
                            pictureType.Image = null;
                            pictureType.Update();
                            pictureType.ImageLocation = "C:/Users/Zouz/source/repos/PokemonCalculator/PokemonCalculator/img/Water.JPG";
                            pictureType.SizeMode = PictureBoxSizeMode.StretchImage;
                            break;
                        default:
                            break;
                    }
                    break;
                }



            }

            button.Text = combo.SelectedItem.ToString();
        }

        private void comboBoxMoves1_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveDetailsCategory(comboBoxMoves1, pictureBoxCategory1, pictureBoxType1, buttonMove1, labelPower1);
        }

        private void comboBoxMoves2_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveDetailsCategory(comboBoxMoves2, pictureBoxCategory4, pictureBoxType2, buttonMove2, labelPower2);
        }

        private void comboBoxMoves3_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveDetailsCategory(comboBoxMoves3, pictureBoxCategory3, pictureBoxType3, buttonMove3, labelPower3);
        }

        private void comboBoxMoves4_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveDetailsCategory(comboBoxMoves4, pictureBoxCategory2, pictureBoxType4, buttonMove4, labelPower4);
        }
    }
}
