
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
            this.listBoxPokemons = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxPokemons
            // 
            this.listBoxPokemons.FormattingEnabled = true;
            this.listBoxPokemons.ItemHeight = 15;
            this.listBoxPokemons.Location = new System.Drawing.Point(54, 37);
            this.listBoxPokemons.Name = "listBoxPokemons";
            this.listBoxPokemons.Size = new System.Drawing.Size(223, 79);
            this.listBoxPokemons.TabIndex = 0;
            this.listBoxPokemons.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxPokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPokemons;
    }
}

