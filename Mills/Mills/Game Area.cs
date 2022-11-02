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
        static int labelsize = 20;
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
        }

        private void innerringgeneration()
        {
            int x = 312;
            int y = 160;
            for (int i = 0; i < 8; i++)
            {
                Label newlabel = new Label();
                newlabel.Width = labelsize;
                newlabel.Height = labelsize;
                if (i <= 2)
                {
                    newlabel.Location = new Point(x + labelsize + 50, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 2 && i <= 4)
                {
                    newlabel.Location = new Point(x, y + labelsize + 50);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 4 && i <= 6)
                {
                    newlabel.Location = new Point(x - 50 - labelsize, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i == 7)
                {
                    newlabel.Location = new Point(x, y - 50 - labelsize);
                }
                newlabel.BackColor = Color.Gray;
                newlabel.BorderStyle = BorderStyle.FixedSingle;
                newlabel.Name = "outer_" + i;
                newlabel.Text = "";
                newlabel.AutoSize = false;
                newlabel.TextAlign = ContentAlignment.MiddleCenter;
                newlabel.Click += new EventHandler(Kattintas);
                this.Controls.Add(newlabel);
                labelek.Add(newlabel);
            }
        }

        private void midringgeneration()
        {
            int x = 212;
            int y = 110;
            for (int i = 0; i < 8; i++)
            {
                Label newlabel = new Label();
                newlabel.Width = labelsize;
                newlabel.Height = labelsize;
                if (i <= 2)
                {
                    newlabel.Location = new Point(x + labelsize + 100, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 2 && i <= 4)
                {
                    newlabel.Location = new Point(x, y + labelsize + 100);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 4 && i <= 6)
                {
                    newlabel.Location = new Point(x - 100 - labelsize, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i == 7)
                {
                    newlabel.Location = new Point(x, y - 100 - labelsize);
                }
                newlabel.BackColor = Color.Gray;
                newlabel.BorderStyle = BorderStyle.FixedSingle;
                newlabel.Name = "outer_" + i;
                newlabel.Text = "";
                newlabel.AutoSize = false;
                newlabel.TextAlign = ContentAlignment.MiddleCenter;
                newlabel.Click += new EventHandler(Kattintas);
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
                newlabel.Width = labelsize;
                newlabel.Height = labelsize;
                if (i <= 2)
                {
                    newlabel.Location = new Point(x + labelsize + 200, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 2 && i <= 4)
                {
                    newlabel.Location = new Point(x, y + labelsize + 200);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i > 4 && i <= 6)
                {
                    newlabel.Location = new Point(x - 200 - labelsize, y);
                    x = newlabel.Location.X;
                    y = newlabel.Location.Y;
                }
                else if (i == 7)
                {
                    newlabel.Location = new Point(x, y - 200 - labelsize);
                }
                newlabel.BackColor = Color.Gray;
                newlabel.BorderStyle = BorderStyle.FixedSingle;
                newlabel.Name = "outer_" + i;
                newlabel.Text = "";
                newlabel.AutoSize = false;
                newlabel.TextAlign = ContentAlignment.MiddleCenter;
                newlabel.Click += new EventHandler(Kattintas);
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
