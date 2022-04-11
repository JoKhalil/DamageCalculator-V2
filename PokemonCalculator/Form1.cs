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


        }

        public void jsonToMove()
        {
            IList<Move> movesList = new List<Move>();


            //using (StreamReader file = File.OpenText(@"\json\moves.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject jsonToken = (JObject)JToken.ReadFrom(reader);



            //}
            String jsonString = File.ReadAllText(@"C:\Users\Zouz\source\repos\PokemonCalculator\PokemonCalculator\json\moves.json");

            JObject jsonParse = JObject.Parse(jsonString);

            JArray jsonArray = (JArray)jsonParse["Move"];

            movesList = jsonArray.ToObject<IList<Move>>();

            //listBoxPokemons.DataSource = movesList;

            foreach (var moves in movesList)
            {
                if (moves.Name != null)
                {
                   comboBoxMoves.Items.Add(moves.Name);
                }
                
            }


            //return movesList;
        }
    }
}
