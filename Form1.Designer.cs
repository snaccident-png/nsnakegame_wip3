namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.snapButton = new System.Windows.Forms.Button();
            this.textCurrentScore = new System.Windows.Forms.Label();
            this.textHighestScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameInstructions = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.visualInstructions = new System.Windows.Forms.PictureBox();
            this.backgroundFill = new System.Windows.Forms.PictureBox();
            this.returnToGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundFill)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(837, 31);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 52);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.SystemColors.Menu;
            this.snapButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.snapButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapButton.Location = new System.Drawing.Point(837, 98);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(152, 125);
            this.snapButton.TabIndex = 0;
            this.snapButton.Text = "Save Photo";
            this.snapButton.UseVisualStyleBackColor = false;
            this.snapButton.Click += new System.EventHandler(this.TakeSnapshot);
            // 
            // textCurrentScore
            // 
            this.textCurrentScore.AutoSize = true;
            this.textCurrentScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentScore.ForeColor = System.Drawing.Color.Black;
            this.textCurrentScore.Location = new System.Drawing.Point(855, 322);
            this.textCurrentScore.Name = "textCurrentScore";
            this.textCurrentScore.Size = new System.Drawing.Size(106, 29);
            this.textCurrentScore.TabIndex = 2;
            this.textCurrentScore.Text = "Score: 0";
            // 
            // textHighestScore
            // 
            this.textHighestScore.AutoSize = true;
            this.textHighestScore.BackColor = System.Drawing.Color.Bisque;
            this.textHighestScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHighestScore.ForeColor = System.Drawing.Color.Black;
            this.textHighestScore.Location = new System.Drawing.Point(760, 375);
            this.textHighestScore.Name = "textHighestScore";
            this.textHighestScore.Size = new System.Drawing.Size(181, 29);
            this.textHighestScore.TabIndex = 2;
            this.textHighestScore.Text = "Highest Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // gameInstructions
            // 
            this.gameInstructions.BackColor = System.Drawing.Color.FloralWhite;
            this.gameInstructions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInstructions.Location = new System.Drawing.Point(826, 536);
            this.gameInstructions.Name = "gameInstructions";
            this.gameInstructions.Size = new System.Drawing.Size(163, 72);
            this.gameInstructions.TabIndex = 3;
            this.gameInstructions.Text = "Game Instructions";
            this.gameInstructions.UseVisualStyleBackColor = false;
            this.gameInstructions.Click += new System.EventHandler(this.OpenInstructions);
            this.gameInstructions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OpenInstructions);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.FloralWhite;
            this.picCanvas.Location = new System.Drawing.Point(32, 37);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(690, 769);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // visualInstructions
            // 
            this.visualInstructions.Image = global::SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024.Properties.Resources.Visual_instructions_for_Nathans_Snake_Game_06_December_2024;
            this.visualInstructions.Location = new System.Drawing.Point(-714, 171);
            this.visualInstructions.Name = "visualInstructions";
            this.visualInstructions.Size = new System.Drawing.Size(1001, 600);
            this.visualInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visualInstructions.TabIndex = 4;
            this.visualInstructions.TabStop = false;
            this.visualInstructions.Visible = false;
            // 
            // backgroundFill
            // 
            this.backgroundFill.BackColor = System.Drawing.Color.DimGray;
            this.backgroundFill.Location = new System.Drawing.Point(-760, 31);
            this.backgroundFill.Name = "backgroundFill";
            this.backgroundFill.Size = new System.Drawing.Size(1025, 992);
            this.backgroundFill.TabIndex = 5;
            this.backgroundFill.TabStop = false;
            this.backgroundFill.Visible = false;
            this.backgroundFill.Click += new System.EventHandler(this.backgroundFill_Click);
            // 
            // returnToGame
            // 
            this.returnToGame.BackColor = System.Drawing.Color.Red;
            this.returnToGame.FlatAppearance.BorderSize = 0;
            this.returnToGame.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToGame.ForeColor = System.Drawing.Color.White;
            this.returnToGame.Location = new System.Drawing.Point(4, 848);
            this.returnToGame.Name = "returnToGame";
            this.returnToGame.Size = new System.Drawing.Size(208, 108);
            this.returnToGame.TabIndex = 6;
            this.returnToGame.Text = "Return to game";
            this.returnToGame.UseVisualStyleBackColor = false;
            this.returnToGame.Visible = false;
            this.returnToGame.Click += new System.EventHandler(this.ReturnToGame);
            // 
            // Form1
            // 
            this.AcceptButton = this.snapButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1026, 992);
            this.Controls.Add(this.returnToGame);
            this.Controls.Add(this.backgroundFill);
            this.Controls.Add(this.visualInstructions);
            this.Controls.Add(this.gameInstructions);
            this.Controls.Add(this.textHighestScore);
            this.Controls.Add(this.textCurrentScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nathan\'s Snake Game_v2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundFill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label textCurrentScore;
        private System.Windows.Forms.Label textHighestScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button gameInstructions;
        private System.Windows.Forms.PictureBox visualInstructions;
        private System.Windows.Forms.PictureBox backgroundFill;
        private System.Windows.Forms.Button returnToGame;
    }
}

