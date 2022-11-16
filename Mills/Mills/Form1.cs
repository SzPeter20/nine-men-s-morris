using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mills
{
    
    public partial class Form1 : Form
    {
        static string player_1_name = "";
        static string player_2_name = "";
        static bool enabled_flying = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void chbx_fly_CheckedChanged(object sender, EventArgs e)
        {
            if (enabled_flying)
            {
                enabled_flying = false;
            }
            else
            {
                enabled_flying = true;
            }
        }

        private void Explain(object sender, CancelEventArgs e)
        {
            MessageBox.Show("");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (txtbx_player_2_name.Text=="")
            {
                player_1_name = "Player 1";
            }
            else
            {
                player_1_name = txtbx_player_2_name.Text;
            }
            if (txtbx_player_1_name.Text == "")
            {
                player_2_name = "Player 2";
            }
            else
            {
                player_2_name = txtbx_player_1_name.Text;
            }


            Game_Area uj = new Game_Area();
            this.Hide();
            uj.Player_nevek(player_1_name, player_2_name,enabled_flying);
            uj.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
