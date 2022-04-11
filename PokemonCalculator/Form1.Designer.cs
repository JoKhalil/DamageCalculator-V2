
namespace PokemonCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMoves1 = new System.Windows.Forms.ComboBox();
            this.comboBoxMoves2 = new System.Windows.Forms.ComboBox();
            this.comboBoxMoves3 = new System.Windows.Forms.ComboBox();
            this.comboBoxMoves4 = new System.Windows.Forms.ComboBox();
            this.comboBoxPokemons = new System.Windows.Forms.ComboBox();
            this.richTextBoxPokemon = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // comboBoxMoves1
            // 
            this.comboBoxMoves1.FormattingEnabled = true;
            this.comboBoxMoves1.Location = new System.Drawing.Point(39, 72);
            this.comboBoxMoves1.Name = "comboBoxMoves1";
            this.comboBoxMoves1.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMoves1.TabIndex = 1;
            this.comboBoxMoves1.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoves1_SelectedIndexChanged);
            // 
            // comboBoxMoves2
            // 
            this.comboBoxMoves2.FormattingEnabled = true;
            this.comboBoxMoves2.Location = new System.Drawing.Point(166, 72);
            this.comboBoxMoves2.Name = "comboBoxMoves2";
            this.comboBoxMoves2.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMoves2.TabIndex = 2;
            // 
            // comboBoxMoves3
            // 
            this.comboBoxMoves3.FormattingEnabled = true;
            this.comboBoxMoves3.Location = new System.Drawing.Point(39, 101);
            this.comboBoxMoves3.Name = "comboBoxMoves3";
            this.comboBoxMoves3.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMoves3.TabIndex = 3;
            // 
            // comboBoxMoves4
            // 
            this.comboBoxMoves4.FormattingEnabled = true;
            this.comboBoxMoves4.Location = new System.Drawing.Point(166, 101);
            this.comboBoxMoves4.Name = "comboBoxMoves4";
            this.comboBoxMoves4.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMoves4.TabIndex = 4;
            // 
            // comboBoxPokemons
            // 
            this.comboBoxPokemons.FormattingEnabled = true;
            this.comboBoxPokemons.Location = new System.Drawing.Point(102, 43);
            this.comboBoxPokemons.Name = "comboBoxPokemons";
            this.comboBoxPokemons.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPokemons.TabIndex = 5;
            this.comboBoxPokemons.SelectedIndexChanged += new System.EventHandler(this.comboBoxPokemons_SelectedIndexChanged);
            // 
            // richTextBoxPokemon
            // 
            this.richTextBoxPokemon.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxPokemon.Location = new System.Drawing.Point(397, 43);
            this.richTextBoxPokemon.Name = "richTextBoxPokemon";
            this.richTextBoxPokemon.Size = new System.Drawing.Size(87, 103);
            this.richTextBoxPokemon.TabIndex = 6;
            this.richTextBoxPokemon.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxPokemon);
            this.Controls.Add(this.comboBoxPokemons);
            this.Controls.Add(this.comboBoxMoves4);
            this.Controls.Add(this.comboBoxMoves3);
            this.Controls.Add(this.comboBoxMoves2);
            this.Controls.Add(this.comboBoxMoves1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMoves1;
        private System.Windows.Forms.ComboBox comboBoxMoves2;
        private System.Windows.Forms.ComboBox comboBoxMoves3;
        private System.Windows.Forms.ComboBox comboBoxMoves4;
        private System.Windows.Forms.ComboBox comboBoxPokemons;
        private System.Windows.Forms.RichTextBox richTextBoxPokemon;
    }
}

