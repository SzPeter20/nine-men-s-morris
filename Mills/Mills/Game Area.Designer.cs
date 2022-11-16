
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Player2_pieces = new System.Windows.Forms.Label();
            this.lbl_Player1_pieces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.player1_LBL.BackColor = System.Drawing.Color.Wheat;
            this.player1_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_LBL.Location = new System.Drawing.Point(18, 47);
            this.player1_LBL.Name = "player1_LBL";
            this.player1_LBL.Size = new System.Drawing.Size(65, 20);
            this.player1_LBL.TabIndex = 1;
            this.player1_LBL.Text = "Player1:";
            // 
            // player2_LBL
            // 
            this.player2_LBL.AutoSize = true;
            this.player2_LBL.BackColor = System.Drawing.Color.Wheat;
            this.player2_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_LBL.Location = new System.Drawing.Point(18, 79);
            this.player2_LBL.Name = "player2_LBL";
            this.player2_LBL.Size = new System.Drawing.Size(65, 20);
            this.player2_LBL.TabIndex = 2;
            this.player2_LBL.Text = "Player2:";
            this.player2_LBL.Click += new System.EventHandler(this.player2_LBL_Click);
            // 
            // player1_color_LBL
            // 
            this.player1_color_LBL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.player1_color_LBL.Location = new System.Drawing.Point(110, 47);
            this.player1_color_LBL.Name = "player1_color_LBL";
            this.player1_color_LBL.Size = new System.Drawing.Size(20, 20);
            this.player1_color_LBL.TabIndex = 3;
            // 
            // player2_color_LBL
            // 
            this.player2_color_LBL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.player2_color_LBL.Location = new System.Drawing.Point(110, 84);
            this.player2_color_LBL.Name = "player2_color_LBL";
            this.player2_color_LBL.Size = new System.Drawing.Size(20, 20);
            this.player2_color_LBL.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Player2_pieces
            // 
            this.lbl_Player2_pieces.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Player2_pieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Player2_pieces.Location = new System.Drawing.Point(146, 84);
            this.lbl_Player2_pieces.Name = "lbl_Player2_pieces";
            this.lbl_Player2_pieces.Size = new System.Drawing.Size(20, 20);
            this.lbl_Player2_pieces.TabIndex = 8;
            // 
            // lbl_Player1_pieces
            // 
            this.lbl_Player1_pieces.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Player1_pieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Player1_pieces.Location = new System.Drawing.Point(146, 47);
            this.lbl_Player1_pieces.Name = "lbl_Player1_pieces";
            this.lbl_Player1_pieces.Size = new System.Drawing.Size(20, 20);
            this.lbl_Player1_pieces.TabIndex = 9;
            // 
            // Game_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 559);
            this.Controls.Add(this.lbl_Player1_pieces);
            this.Controls.Add(this.lbl_Player2_pieces);
            this.Controls.Add(this.player2_color_LBL);
            this.Controls.Add(this.player1_color_LBL);
            this.Controls.Add(this.player2_LBL);
            this.Controls.Add(this.player1_LBL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(768, 598);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(768, 598);
            this.Name = "Game_Area";
            this.Text = "Game_Area";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Game_Area_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_Area_FormClosing);
            this.Load += new System.EventHandler(this.Game_Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label player1_LBL;
        private System.Windows.Forms.Label player2_LBL;
        private System.Windows.Forms.Label player1_color_LBL;
        private System.Windows.Forms.Label player2_color_LBL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Player2_pieces;
        private System.Windows.Forms.Label lbl_Player1_pieces;
    }
}