
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_player_2_name = new System.Windows.Forms.TextBox();
            this.txtbx_player_1_name = new System.Windows.Forms.TextBox();
            this.chbx_fly = new System.Windows.Forms.CheckBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1 name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2 name:";
            // 
            // txtbx_player_2_name
            // 
            this.txtbx_player_2_name.Location = new System.Drawing.Point(147, 81);
            this.txtbx_player_2_name.Name = "txtbx_player_2_name";
            this.txtbx_player_2_name.Size = new System.Drawing.Size(100, 20);
            this.txtbx_player_2_name.TabIndex = 2;
            // 
            // txtbx_player_1_name
            // 
            this.txtbx_player_1_name.Location = new System.Drawing.Point(147, 42);
            this.txtbx_player_1_name.Name = "txtbx_player_1_name";
            this.txtbx_player_1_name.Size = new System.Drawing.Size(100, 20);
            this.txtbx_player_1_name.TabIndex = 3;
            // 
            // chbx_fly
            // 
            this.chbx_fly.AutoSize = true;
            this.chbx_fly.Location = new System.Drawing.Point(291, 63);
            this.chbx_fly.Name = "chbx_fly";
            this.chbx_fly.Size = new System.Drawing.Size(86, 17);
            this.chbx_fly.TabIndex = 4;
            this.chbx_fly.Text = "Enable flying";
            this.chbx_fly.UseVisualStyleBackColor = true;
            this.chbx_fly.CheckedChanged += new System.EventHandler(this.chbx_fly_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(157, 131);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 166);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.chbx_fly);
            this.Controls.Add(this.txtbx_player_1_name);
            this.Controls.Add(this.txtbx_player_2_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Explain);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_player_2_name;
        private System.Windows.Forms.TextBox txtbx_player_1_name;
        private System.Windows.Forms.CheckBox chbx_fly;
        private System.Windows.Forms.Button btn_start;
    }
}

