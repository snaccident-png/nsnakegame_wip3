using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    public partial class SplashScreen_24_Sep_2024 : Form
    {
        public SplashScreen_24_Sep_2024()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);

            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 snakeGameLaunch = new Form1();

                snakeGameLaunch.Show();
                this.Hide();
            }
        }
    }
}
