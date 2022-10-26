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
        public static string player1 = "";
        public static string player2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void chbx_fly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void str_btn_Click(object sender, EventArgs e)
        {
            if (txtbx_player_1_name.Text.Length == 0)
            {
                player1 = "Player 1";
            }
            else
            {
                player1 = txtbx_player_1_name.Text;
            }
            if (txtbx_player_2_name.Text.Length == 0)
            {
                player2 = "Player 2";
            }
            else
            {
                player2 = txtbx_player_2_name.Text;
            }

            Game_Area uj = new Game_Area();
            this.Hide();
            uj.atadas(player1, player2);
            uj.Show();
        }
    }
}
