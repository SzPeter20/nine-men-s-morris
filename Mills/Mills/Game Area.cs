﻿using System;
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
        static string player1_name;
        static string player2_name;
        public Game_Area()
        {
            InitializeComponent();
        }
        public void atadas(string player1name, string player2name)
        {
            player1_name = player1name;
            player2_name = player2name;
        }

        private void Game_Area_Load(object sender, EventArgs e)
        {
            User player1 = new User(player1_name, 9);
            User player2 = new User(player2_name, 9);
        }
    }
}
