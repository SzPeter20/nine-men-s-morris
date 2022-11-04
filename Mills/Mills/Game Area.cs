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
        static int labelsize = 17;
        static List<Pont> empty = new List<Pont>();
        static List<Pont> midring = new List<Pont>();
        static List<Pont> outerring = new List<Pont>();
        static List<Pont> innerring = new List<Pont>();
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
            outerringgeneration();
            midringgeneration();
            innerringgeneration();
            pictureBox1.SendToBack();
            pontgeneration();
        }

        private void pontgeneration()
        {
            List<Pont> helper_szomszed = new List<Pont>();
            
            for (int i = 0; i < labelek.Count/3; i++)
            {
                midring.Add( new Pont( "midring_" + i,"Nothing",empty));
            }
            for (int i = 0; i < labelek.Count / 3; i++)
            {
                outerring.Add(new Pont("outerring_" + i, "Nothing", empty));
            }
            for (int i = 0; i < labelek.Count / 3; i++)
            {
                innerring.Add(new Pont("innerring_" + i, "Nothing", empty));
            }
            neighbouring(helper_szomszed);
            


        }

        private void neighbouring(List<Pont> help,)
        {
            for (int i = 0; i < outerring.Count; i++)
            {
                if (i == 0)
                {
                    helper_szomszed.Add(outerring[i + 1]);
                    helper_szomszed.Add(outerring[outerring.Count]);
                }
                if (i % 2 == 0 && i != 8)
                {
                    helper_szomszed.Add(outerring[i + 1]);
                    helper_szomszed.Add(outerring[i - 1]);
                    helper_szomszed.Add(midring[i]);

                }
                if (i == 8)
                {
                    helper_szomszed.Add(outerring[0]);
                    helper_szomszed.Add(outerring[i - 1]);
                    helper_szomszed.Add(midring[midring.Count]);
                }
                outerring[i].Neighbors = helper_szomszed;
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
                labelek.Add(newlabel);
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
                labelek.Add(newlabel);
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
                labelek.Add(newlabel);
            }
        }

        private void Kattintas(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Player_nevek(string player1,string player2)
        {
            Player playerone = new Player(player1, 9,0, "CornflowerBlue");
            Player playertwo = new Player(player2, 9,0, "HotPink");
        }
    }
}
