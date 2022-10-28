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
    public partial class Game_Area : Form
    {
        static List<Pont> empty = new List<Pont>();
        public Game_Area()
        {
            InitializeComponent();
        }

        private void Game_Area_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Game_Area_Load(object sender, EventArgs e)
        {
            generatemap();
        }

        private void generatemap()
        {
            
        }
        public void Player_nevek(string player1,string player2)
        {
            Player playerone = new Player(player1, 9,0, "CornflowerBlue");
            Player playertwo = new Player(player2, 9,0, "HotPink");
        }
    }
}
