
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1_LBL = new System.Windows.Forms.Label();
            this.Player2_LBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mills.Properties.Resources._9_MEN_300;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player2:";
            // 
            // Player1_LBL
            // 
            this.Player1_LBL.AutoSize = true;
            this.Player1_LBL.Location = new System.Drawing.Point(380, 12);
            this.Player1_LBL.Name = "Player1_LBL";
            this.Player1_LBL.Size = new System.Drawing.Size(42, 13);
            this.Player1_LBL.TabIndex = 3;
            this.Player1_LBL.Text = "Player1";
            // 
            // Player2_LBL
            // 
            this.Player2_LBL.AutoSize = true;
            this.Player2_LBL.Location = new System.Drawing.Point(380, 43);
            this.Player2_LBL.Name = "Player2_LBL";
            this.Player2_LBL.Size = new System.Drawing.Size(35, 13);
            this.Player2_LBL.TabIndex = 4;
            this.Player2_LBL.Text = "label4";
            // 
            // Game_Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(474, 376);
            this.Controls.Add(this.Player2_LBL);
            this.Controls.Add(this.Player1_LBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(490, 415);
            this.MinimumSize = new System.Drawing.Size(490, 415);
            this.Name = "Game_Area";
            this.Text = "Game_Area";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_Area_FormClosing);
            this.Load += new System.EventHandler(this.Game_Area_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player1_LBL;
        private System.Windows.Forms.Label Player2_LBL;
    }
}