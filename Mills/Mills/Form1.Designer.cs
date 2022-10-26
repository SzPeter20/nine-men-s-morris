
namespace Mills
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_player_2_name = new System.Windows.Forms.TextBox();
            this.txtbx_player_1_name = new System.Windows.Forms.TextBox();
            this.chbx_fly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2:";
            // 
            // txtbx_player_2_name
            // 
            this.txtbx_player_2_name.Location = new System.Drawing.Point(126, 105);
            this.txtbx_player_2_name.Name = "txtbx_player_2_name";
            this.txtbx_player_2_name.Size = new System.Drawing.Size(100, 20);
            this.txtbx_player_2_name.TabIndex = 2;
            // 
            // txtbx_player_1_name
            // 
            this.txtbx_player_1_name.Location = new System.Drawing.Point(126, 66);
            this.txtbx_player_1_name.Name = "txtbx_player_1_name";
            this.txtbx_player_1_name.Size = new System.Drawing.Size(100, 20);
            this.txtbx_player_1_name.TabIndex = 3;
            // 
            // chbx_fly
            // 
            this.chbx_fly.AutoSize = true;
            this.chbx_fly.Location = new System.Drawing.Point(300, 88);
            this.chbx_fly.Name = "chbx_fly";
            this.chbx_fly.Size = new System.Drawing.Size(86, 17);
            this.chbx_fly.TabIndex = 4;
            this.chbx_fly.Text = "Enable flying";
            this.chbx_fly.UseVisualStyleBackColor = true;
            this.chbx_fly.CheckedChanged += new System.EventHandler(this.chbx_fly_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 207);
            this.Controls.Add(this.chbx_fly);
            this.Controls.Add(this.txtbx_player_1_name);
            this.Controls.Add(this.txtbx_player_2_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_player_2_name;
        private System.Windows.Forms.TextBox txtbx_player_1_name;
        private System.Windows.Forms.CheckBox chbx_fly;
    }
}

