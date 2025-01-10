namespace SnakeGame_DoNotClickIgnoreAndContinue_15_September_2024
{
    partial class GameInstructions_26092024
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
            this.instructions = new System.Windows.Forms.TextBox();
            this.gameInstructions = new System.Windows.Forms.Button();
            this.textHighestScore = new System.Windows.Forms.Label();
            this.textCurrentScore = new System.Windows.Forms.Label();
            this.snapButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.MidnightBlue;
            this.instructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructions.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.Color.White;
            this.instructions.Location = new System.Drawing.Point(35, 41);
            this.instructions.Multiline = true;
            this.instructions.Name = "instructions";
            this.instructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instructions.Size = new System.Drawing.Size(690, 769);
            this.instructions.TabIndex = 10;
            // 
            // gameInstructions
            // 
            this.gameInstructions.BackColor = System.Drawing.Color.Orange;
            this.gameInstructions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameInstructions.Location = new System.Drawing.Point(829, 540);
            this.gameInstructions.Name = "gameInstructions";
            this.gameInstructions.Size = new System.Drawing.Size(163, 72);
            this.gameInstructions.TabIndex = 9;
            this.gameInstructions.Text = "Game Instructions";
            this.gameInstructions.UseVisualStyleBackColor = false;
            this.gameInstructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // textHighestScore
            // 
            this.textHighestScore.AutoSize = true;
            this.textHighestScore.BackColor = System.Drawing.Color.Black;
            this.textHighestScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHighestScore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textHighestScore.Location = new System.Drawing.Point(763, 379);
            this.textHighestScore.Name = "textHighestScore";
            this.textHighestScore.Size = new System.Drawing.Size(181, 29);
            this.textHighestScore.TabIndex = 7;
            this.textHighestScore.Text = "Highest Score:";
            // 
            // textCurrentScore
            // 
            this.textCurrentScore.AutoSize = true;
            this.textCurrentScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentScore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textCurrentScore.Location = new System.Drawing.Point(858, 326);
            this.textCurrentScore.Name = "textCurrentScore";
            this.textCurrentScore.Size = new System.Drawing.Size(106, 29);
            this.textCurrentScore.TabIndex = 8;
            this.textCurrentScore.Text = "Score: 0";
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.SystemColors.Menu;
            this.snapButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.snapButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapButton.Location = new System.Drawing.Point(840, 102);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(152, 125);
            this.snapButton.TabIndex = 5;
            this.snapButton.Text = "Save Photo";
            this.snapButton.UseVisualStyleBackColor = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(840, 35);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 52);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // GameInstructions_26092024
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1026, 894);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.gameInstructions);
            this.Controls.Add(this.textHighestScore);
            this.Controls.Add(this.textCurrentScore);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameInstructions_26092024";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameInstructions_26092024";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox instructions;
        private System.Windows.Forms.Button gameInstructions;
        private System.Windows.Forms.Label textHighestScore;
        private System.Windows.Forms.Label textCurrentScore;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Button startButton;
    }
}