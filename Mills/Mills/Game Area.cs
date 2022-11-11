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
        static int moving = 0;
        static Player playerone;
        static Player playertwo;
        static int currentturn = 0;
        static int labelsize = 17;
        static List<Label> empty = new List<Label>();
        static List<Label> midring = new List<Label>();
        static List<Label> outerring = new List<Label>();
        static List<Label> innerring = new List<Label>();
        static List<Label> labelek = new List<Label>();
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
            //pontgeneration();
            outerringgeneration();
            midringgeneration();
            innerringgeneration();
            pictureBox1.SendToBack();
            
            turns();
        }

        private void turns()
        {
            Random velet = new Random();
            int decide = velet.Next(0, 101);
            if (decide > 50)
            {
                currentturn = 1;
                playerone.Color = Color.HotPink;
                playertwo.Color = Color.CornflowerBlue;
                player1_color_LBL.BackColor = playerone.Color;
                player2_color_LBL.BackColor = playertwo.Color;
            }
            else
            {
                currentturn = 2;
                playertwo.Color = Color.HotPink;
                playerone.Color = Color.CornflowerBlue;
                player1_color_LBL.BackColor = playerone.Color;
                player2_color_LBL.BackColor = playertwo.Color;
            }
        }

        private void pontgeneration()
        {/*
            List<Pont> helper_szomszed = new List<Pont>();
            
            for (int i = 0; i < 8; i++)
            {
                midring.Add( new Pont( "midring_" + i,"Nothing",empty));
            }
            for (int i = 0; i < 8; i++)
            {
                outerring.Add(new Pont("outerring_" + i, "Nothing", empty));
            }
            for (int i = 0; i < 8; i++)
            {
                innerring.Add(new Pont("innerring_" + i, "Nothing", empty));
            }
            neighbouring(helper_szomszed,outerring,midring);
            neighbouring(helper_szomszed, innerring, midring);
            neighbouring(helper_szomszed, midring, outerring);
            neighbouring(helper_szomszed, midring, innerring);
            */
        }

        private void neighbouring(List<Pont> help, List<Pont> van, List<Pont> masik)
        {
            for (int i = 0; i < van.Count; i++)
            {
                if (i == 0)
                {
                    help.Add(van[i + 1]);
                    help.Add(van[van.Count-1]);
                }
                if (i==1||i==3||i==5 )
                {
                    help.Add(van[i+1]);
                    help.Add(van[i - 1]);
                    help.Add(masik[i]);
                }
                if (i == 7)
                {
                    help.Add(van[0]);
                    help.Add(van[i - 1]);
                    help.Add(masik[masik.Count-1]);
                }
                van[i].Neighbors = help;
            }
        }

        private void innerringgeneration()
        {
            int x = 312;
            int y = 160;
            for (int i = 0; i < 8; i++)
            {
                Label newlabel = new Label();
                newlabel.Width = labelsize+2;
                newlabel.Height = labelsize+2;
                if (i <= 2)
                {
                    newlabel.Location = new Point(x + labelsize+2 + 50, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 2 && i <= 4)
                {
                    newlabel.Location = new Point(x, y + labelsize+2 + 50);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 4 && i <= 6)
                {
                    newlabel.Location = new Point(x - 50 - labelsize+2, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i == 7)
                {
                    newlabel.Location = new Point(x, y - 50 - labelsize+2);
                }
                newlabel.BackColor = Color.Black;
                newlabel.Name = "inner_" + i;
                newlabel.Text = "";
                newlabel.AutoSize = false;
                newlabel.TextAlign = ContentAlignment.MiddleCenter;
                newlabel.Click += new EventHandler(Kattintas);
                for (int j = 0; j < 10; j++)
                {
                    newlabel.BringToFront();
                }
                this.Controls.Add(newlabel);
                innerring.Add(newlabel);
            }
        }

        private void midringgeneration()
        {
            int x = 150;
            int y = 80;
            for (int i = 0; i < 8; i++)
            {
                Label newlabel = new Label();
                newlabel.Width = labelsize+2;
                newlabel.Height = labelsize+2;
                if (i <= 2)
                {
                    newlabel.Location = new Point(x + labelsize+2 + 130, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 2 && i <= 4)
                {
                    newlabel.Location = new Point(x, y + labelsize+2 + 130);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 4 && i <= 6)
                {
                    newlabel.Location = new Point(x - 130 - labelsize+2, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i == 7)
                {
                    newlabel.Location = new Point(x, y - 130 - labelsize+2);
                }
                newlabel.BackColor = Color.Black;
                newlabel.Name = "mid_" + i;
                newlabel.Text = "";
                newlabel.AutoSize = false;
                newlabel.TextAlign = ContentAlignment.MiddleCenter;
                newlabel.Click += new EventHandler(Kattintas);
                for (int j = 0; j < 10; j++)
                {
                    newlabel.BringToFront();
                }
                this.Controls.Add(newlabel);
                midring.Add(newlabel);
            }
        }

        private void outerringgeneration()
        {
            int x = 12;
            int y = 12;
            for (int i = 0; i < 8; i++)
            {
                Label newlabel = new Label();
                newlabel.Width = labelsize+2;
                newlabel.Height = labelsize+2;
                if (i <= 2)
                {
                    newlabel.Location = new Point(x + labelsize+2 + 200, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 2 && i <= 4)
                {
                    newlabel.Location = new Point(x, y + labelsize+2 + 200);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 4 && i <= 6)
                {
                    newlabel.Location = new Point(x - 200 - labelsize+2, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i == 7)
                {
                    newlabel.Location = new Point(x, y - 200 - labelsize+2);
                }
                newlabel.BackColor = Color.Black;
                newlabel.Name = "outer_" + i;
                newlabel.Text = "";
                newlabel.AutoSize = false;
                newlabel.TextAlign = ContentAlignment.MiddleCenter;
                newlabel.Click += new EventHandler(Kattintas);
                for (int j = 0; j < 10; j++)
                {
                    newlabel.BringToFront();
                }
                
                this.Controls.Add(newlabel);
                outerring.Add(newlabel);
            }
        }

        private void Kattintas(object sender, EventArgs e)
        {
            string honnanring = "";
            string hovaring = "";
            int honnanint = 0;
            int hovaint = 0;
            
            Label kattintottLabel = sender as Label;
            if (currentturn==1)
            {
                if (playerone.Piececount > 0 && moving == 0)
                {
                    if (kattintottLabel.Text == "")
                    {
                        kattintottLabel.Text = "1";
                        kattintottLabel.BackColor = playerone.Color;
                        kattintottLabel.ForeColor = playerone.Color;
                        playerone.Piececount--;
                        playerone.Onmappieces++;
                        millquestionmark();
                        currentturn = 2;
                    }

                }
                else if (kattintottLabel.Text == "1"&&moving==0 &&!(playerone.Piececount > 0))
                {
                    moving = 1;
                    honnanint =Convert.ToInt32( kattintottLabel.Name.Split('_')[1]);
                    honnanring = kattintottLabel.Name.Split('_')[0];
                    kattintottLabel.BackColor = Color.DarkMagenta;

                }
                if (moving==1&&kattintottLabel.Text=="")
                {
                    moving = 0;
                    kattintottLabel.Text = "1";
                    kattintottLabel.BackColor = playerone.Color;
                    kattintottLabel.ForeColor = playerone.Color;
                    millquestionmark();
                    clearlabel(honnanint,honnanring);

                }
                currentturn = 2;
                
            }
            else if (currentturn == 2 && moving == 0)
            {
                if (playertwo.Piececount > 0 && kattintottLabel.Text == "")
                {
                    kattintottLabel.Text = "2";
                    kattintottLabel.BackColor = playertwo.Color;
                    kattintottLabel.ForeColor = playertwo.Color;
                    playertwo.Piececount--;
                    playertwo.Onmappieces++;
                    currentturn = 1;
                }
                currentturn = 1;
            }
        }

        private void millquestionmark()
        {
            
        }

        private void clearlabel(int honnanint,string honnanring)
        {
            switch (honnanring)
            {
                case "outer":
                    outerring[honnanint].BackColor = Color.Black;
                    outerring[honnanint].ForeColor = Color.Black;
                    outerring[honnanint].Text = "";
                    break;
                case "inner":
                    innerring[honnanint].BackColor = Color.Black;
                    innerring[honnanint].ForeColor = Color.Black;
                    innerring[honnanint].Text = "";
                    break;
                case "mid":
                    midring[honnanint].BackColor = Color.Black;
                    midring[honnanint].ForeColor = Color.Black;
                    midring[honnanint].Text = "";
                    break;
            }
        }

        public void Player_nevek(string player1,string player2)
        {
            playerone = new Player(player1, 9,0, Color.CornflowerBlue);
            playertwo = new Player(player2, 9,0, Color.HotPink);
            player1_LBL.Text = $"{playerone.Name}: ";
            player2_LBL.Text = $"{playertwo.Name}: ";
        }

        private void Game_Area_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Malom_(j%C3%A1t%C3%A9k)");
        }
    }
}
