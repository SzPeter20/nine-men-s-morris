
namespace Mills
{
    partial class Game_Area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Area));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player1_LBL = new System.Windows.Forms.Label();
            this.player2_LBL = new System.Windows.Forms.Label();
            this.player1_color_LBL = new System.Windows.Forms.Label();
            this.player2_color_LBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mills.Properties.Resources._9_MEN_300;
            this.pictureBox1.Location = new System.Drawing.Point(227, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // player1_LBL
            // 
            this.player1_LBL.AutoSize = true;
            this.player1_LBL.Location = new System.Drawing.Point(12, 25);
            this.player1_LBL.Name = "player1_LBL";
            this.player1_LBL.Size = new System.Drawing.Size(45, 13);
            this.player1_LBL.TabIndex = 1;
            this.player1_LBL.Text = "Player1:";
           
            // 
            // player2_LBL
            // 
            this.player2_LBL.AutoSize = true;
            this.player2_LBL.Location = new System.Drawing.Point(12, 54);
            this.player2_LBL.Name = "player2_LBL";
            this.player2_LBL.Size = new System.Drawing.Size(45, 13);
            this.player2_LBL.TabIndex = 2;
            this.player2_LBL.Text = "Player2:";
            // 
            // player1_color_LBL
            // 
            this.player1_color_LBL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.player1_color_LBL.Location = new System.Drawing.Point(68, 21);
            this.player1_color_LBL.Name = "player1_color_LBL";
            this.player1_color_LBL.Size = new System.Drawing.Size(17, 17);
            this.player1_color_LBL.TabIndex = 3;
            // 
            // player2_color_LBL
            // 
            this.player2_color_LBL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.player2_color_LBL.Location = new System.Drawing.Point(68, 50);
            this.player2_color_LBL.Name = "player2_color_LBL";
            this.player2_color_LBL.Size = new System.Drawing.Size(17, 17);
            this.player2_color_LBL.TabIndex = 4;
            // 
            // Game_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 559);
            this.Controls.Add(this.player2_color_LBL);
            this.Controls.Add(this.player1_color_LBL);
            this.Controls.Add(this.player2_LBL);
            this.Controls.Add(this.player1_LBL);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game_Area";
            this.Text = "Game_Area";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Game_Area_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_Area_FormClosing);
            this.Load += new System.EventHandler(this.Game_Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label player1_LBL;
        private System.Windows.Forms.Label player2_LBL;
        private System.Windows.Forms.Label player1_color_LBL;
        private System.Windows.Forms.Label player2_color_LBL;
    }
}