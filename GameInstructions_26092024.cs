using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    public partial class GameInstructions_26092024 : Form
    {

        string openFile = @"C:\Users\natha\OneDrive\Desktop\Frustrating to make games_03-August-2024\Visual instructions 
            //for Nathans Snake Game_06-December-2024.png";
        public GameInstructions_26092024()
        {
            InitializeComponent();

            // TextWriter.
        }

        private void instructions_Click(object sender, EventArgs e)
        {
            //Label gameInstructions = new Label();

            //gameInstructions.Text = openFile;
            //gameInstructions.ForeColor = Color.White;
            //gameInstructions.BackColor = Color.Transparent;
            //gameInstructions.Font = new Font("Arial", 12, FontStyle.Bold);
            //gameInstructions.TextAlign = ContentAlignment.MiddleCenter;

            instructions.Controls.Add(gameInstructions);

            if (File.Exists(openFile))
            {
                string readText = File.ReadAllText(openFile);

                instructions.Text = readText;

                //instructions. = Color.White;
                //instructions.BackColor = Color.Transparent;
                //instructions.Font = new Font("Arial", 12, FontStyle.Bold);
                //instructions.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleCenter;

                //for (int i = 0; i < instructions.Controls.Count; i++)
                //{
                //    instructions.ForeColor = Color.White;
                //    instructions.BackColor = Color.Transparent;
                //    instructions.Font = new Font("Arial", 12, FontStyle.Bold);
                //    instructions.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleCenter;
                //}



            }
        }

        //private void turnoff(object sender, eventargs e)
        //{
        //    instructions.text = "";
        //}

        //private void instructions_TextChanged(object sender, EventArgs e)
        //{

        //}


    }
}
