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
        static bool flies = false;
        static bool hunting = false;
        static string clearring = "";
        static int clearint = 0;
        static List<Label> szomszedok = new List<Label>();
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
            int honnanint = 0;
           
            
            Label kattintottLabel = sender as Label;
            if (currentturn==1)
            {
                if (kattintottLabel.Text==""&&playerone.Piececount>0&&kattintottLabel.BackColor==Color.Black)
                {
                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    addneighboors(honnanring, honnanint);
                    playerone.Onmappieces-=-1;
                    playerone.Piececount += -1;
                    lbl_Player1_pieces.Text = $"{playerone.Piececount}";
                    kattintottLabel.BackColor = playerone.Color;
                    kattintottLabel.ForeColor = playerone.Color;
                    kattintottLabel.Text = "1";
                    millquestionmark(honnanring);
                    currentturn = 2;
                }
                else if (kattintottLabel.Text=="1"&&kattintottLabel.BackColor==playerone.Color&&playerone.Piececount<1&&moving==0)
                {
                    moving = 1;
                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    clearring = kattintottLabel.Name.Split('_')[0];
                    clearint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    kattintottLabel.BackColor = Color.DarkMagenta;
                    kattintottLabel.ForeColor = Color.DarkMagenta;
                    
                    addneighboors(honnanring,honnanint);
                }
                else if (kattintottLabel.Text==""&&kattintottLabel.BackColor==Color.Black&&moving==1&&flies&&playerone.Onmappieces==3)
                {


                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    addneighboors(honnanring, honnanint);
                    clearlabel(clearint,clearring);
                    kattintottLabel.BackColor = playerone.Color;
                    kattintottLabel.ForeColor = playerone.Color;
                    kattintottLabel.Text = "1";
                    millquestionmark(honnanring);
                    currentturn = 2;
                }
                else if (kattintottLabel.Text == "" && kattintottLabel.BackColor == Color.Black && moving == 1 && !flies&&szomszedok.Contains(kattintottLabel))
                {
                    
                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    addneighboors(honnanring, honnanint);
                    clearlabel(clearint, clearring);
                    kattintottLabel.BackColor = playerone.Color;
                    kattintottLabel.ForeColor = playerone.Color;
                    kattintottLabel.Text = "1";
                    millquestionmark(honnanring);
                    currentturn = 2;
                }
                else if (hunting&&kattintottLabel.BackColor==playertwo.Color&&kattintottLabel.Text=="2")
                {
                    kattintottLabel.Text = "";
                    kattintottLabel.BackColor = Color.Black;
                    kattintottLabel.ForeColor = Color.Black;
                    playertwo.Onmappieces -= +1;
                    currentturn = 2;
                    victoryquestion();
                }
            }
            else if (currentturn == 2)
            {
                if (playertwo.Piececount > 0 && kattintottLabel.Text == "" && kattintottLabel.BackColor == Color.Black)
                {
                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    addneighboors(honnanring, honnanint);
                    kattintottLabel.Text = "2";
                    kattintottLabel.BackColor = playertwo.Color;
                    kattintottLabel.ForeColor = playertwo.Color;
                    playertwo.Piececount--;
                    playertwo.Onmappieces++;
                    lbl_Player2_pieces.Text = $"{playertwo.Name} korongjainak száma: {playertwo.Piececount}";
                    millquestionmark(honnanring);
                    currentturn = 1;
                }
                else if (kattintottLabel.Text == "2" && kattintottLabel.BackColor == playertwo.Color && playertwo.Piececount < 1 && moving == 0)
                {
                    moving = 1;
                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    clearring = kattintottLabel.Name.Split('_')[0];
                    clearint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    kattintottLabel.BackColor = Color.DarkCyan;
                    kattintottLabel.ForeColor = Color.DarkCyan;
                    addneighboors(honnanring, honnanint);
                }
                else if (kattintottLabel.Text == "" && kattintottLabel.BackColor == Color.Black && moving == 1 && flies && playerone.Onmappieces == 3)
                {


                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    addneighboors(honnanring, honnanint);
                    clearlabel(clearint, clearring);
                    kattintottLabel.BackColor = playertwo.Color;
                    kattintottLabel.ForeColor = playertwo.Color;
                    kattintottLabel.Text = "2";
                    millquestionmark(honnanring);
                    currentturn = 1;
                }
                else if (kattintottLabel.Text == "" && kattintottLabel.BackColor == Color.Black && moving == 1 && !flies && szomszedok.Contains(kattintottLabel))
                {
                    honnanring = kattintottLabel.Name.Split('_')[0];
                    honnanint = Convert.ToInt32(kattintottLabel.Name.Split('_')[1]);
                    addneighboors(honnanring, honnanint);
                    clearlabel(clearint, clearring);
                    kattintottLabel.BackColor = playertwo.Color;
                    kattintottLabel.ForeColor = playertwo.Color;
                    kattintottLabel.Text = "2";
                    millquestionmark(honnanring);
                    currentturn = 1;
                }
                else if (hunting && kattintottLabel.BackColor == playerone.Color && kattintottLabel.Text == "1")
                {
                    kattintottLabel.Text = "";
                    kattintottLabel.BackColor = Color.Black;
                    kattintottLabel.ForeColor = Color.Black;
                    playerone.Onmappieces -= +1;
                    currentturn = 1;
                    victoryquestion();
                }

            }
        }

        private void addneighboors(string honnanring,int honnanint)
        {
            szomszedok.Clear();

            if (honnanint==1|| honnanint == 3|| honnanint == 5)
            {
                switch (honnanring)
                {
                    case "outer":
                        
                        szomszedok.Add(outerring[honnanint + 1]);
                        szomszedok.Add(outerring[honnanint - 1]);
                        szomszedok.Add(midring[honnanint]);
                        break;
                    case "inner":
                        szomszedok.Add(innerring[honnanint + 1]);
                        szomszedok.Add(innerring[honnanint - 1]);
                        szomszedok.Add(midring[honnanint]);

                        break;
                    case "mid":
                        szomszedok.Add(midring[honnanint + 1]);
                        szomszedok.Add(midring[honnanint - 1]);
                        szomszedok.Add(outerring[honnanint]);
                        szomszedok.Add(innerring[honnanint]);
                        break;
                }
            }
            else
            {
                switch (honnanring)
                {
                    case "outer":
                        if (honnanint==0)
                        {
                            szomszedok.Add(outerring[honnanint + 1]);
                            szomszedok.Add(outerring[7]);
                        }
                        else if (honnanint == 7)
                        {
                            szomszedok.Add(outerring[honnanint - 1]);
                            szomszedok.Add(outerring[0]);
                            szomszedok.Add(midring[honnanint]);
                        }
                        else
                        {
                            szomszedok.Add(outerring[honnanint + 1]);
                            szomszedok.Add(outerring[honnanint - 1]);
                        }
                        break;
                    case "inner":
                        if (honnanint == 0)
                        {
                            szomszedok.Add(innerring[honnanint + 1]);
                            szomszedok.Add(innerring[7]);
                        }
                        else if (honnanint == 7)
                        {
                            szomszedok.Add(innerring[honnanint - 1]);
                            szomszedok.Add(innerring[0]);
                            szomszedok.Add(midring[honnanint]);
                        }
                        else
                        {
                            szomszedok.Add(innerring[honnanint + 1]);
                            szomszedok.Add(innerring[honnanint - 1]);
                        }

                        break;
                    case "mid":
                        if (honnanint == 0)
                        {
                            szomszedok.Add(midring[honnanint + 1]);
                            szomszedok.Add(midring[7]);
                        }
                        else if (honnanint == 7)
                        {
                            szomszedok.Add(midring[honnanint - 1]);
                            szomszedok.Add(midring[0]);
                            szomszedok.Add(outerring[honnanint]);
                            szomszedok.Add(innerring[honnanint]);
                        }
                        else
                        {
                            szomszedok.Add(midring[honnanint + 1]);
                            szomszedok.Add(midring[honnanint - 1]);
                        }
                        break;
                }
            }

            
        }

        private void millquestionmark(string ring)
        {
            if (midring[1].Text=="1"&& outerring[1].Text == "1"&& innerring[1].Text == "1")
            {
                hunting = true;
            }
            else
            {
                switch (ring)
                {
                    case "outer":
                        if (outerring[0].Text == "1" && outerring[1].Text == "1" && outerring[2].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (outerring[2].Text == "1" && outerring[3].Text == "1" && outerring[4].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (outerring[4].Text == "1" && outerring[5].Text == "1" && outerring[6].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (outerring[6].Text == "1" && outerring[7].Text == "1" && outerring[0].Text == "1")
                        {
                            hunting = true;
                        }
                        break;
                    case "inner":
                        if (innerring[0].Text == "1" && innerring[1].Text == "1" && innerring[2].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (innerring[2].Text == "1" && innerring[3].Text == "1" && innerring[4].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (innerring[4].Text == "1" && innerring[5].Text == "1" && innerring[6].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (innerring[6].Text == "1" && innerring[7].Text == "1" && innerring[0].Text == "1")
                        {
                            hunting = true;
                        }
                        break;
                    case "mid":
                        if (midring[0].Text == "1" && midring[1].Text == "1" && midring[2].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (midring[2].Text == "1" && midring[3].Text == "1" && midring[4].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (midring[4].Text == "1" && midring[5].Text == "1" && midring[6].Text == "1")
                        {
                            hunting = true;
                        }
                        else if (midring[6].Text == "1" && midring[7].Text == "1" && midring[0].Text == "1")
                        {
                            hunting = true;
                        }
                        break;
                }
            }
            


            
        }

        private void victoryquestion()
        {
            if (playerone.Onmappieces<3)
            {
                string message = "hurá hurá hurá jaj de nagyon jó, hogy "+playertwo.Name+" nyert. akartok újra játszani?";
                string title = "jéj  nyertél";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    Application.Restart();
                }
            }
            else if (playertwo.Onmappieces < 3)
            {
                string message = "hurá hurá hurá jaj de nagyon jó, hogy " + playerone.Name + " nyert. akartok újra játszani?";
                string title = "jéj  nyertél";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    
                    Application.Restart();
                }
            }
        }

        private void clearlabel(int clearint,string clearring)
        {
            switch (clearring)
            {
                case "outer":
                    outerring[clearint].BackColor = Color.Black;
                    outerring[clearint].ForeColor = Color.Black;
                    outerring[clearint].Text = "";
                    break;
                case "inner":
                    innerring[clearint].BackColor = Color.Black;
                    innerring[clearint].ForeColor = Color.Black;
                    innerring[clearint].Text = "";
                    break;
                case "mid":
                    midring[clearint].BackColor = Color.Black;
                    midring[clearint].ForeColor = Color.Black;
                    midring[clearint].Text = "";
                    break;
            }
        }

        public void Player_nevek(string player1,string player2,bool flyenabled)
        {
            playerone = new Player(player1, 4,0, Color.CornflowerBlue);
            playertwo = new Player(player2, 4,0, Color.HotPink);
            player1_LBL.Text = $"{playerone.Name}: ";
            player2_LBL.Text = $"{playertwo.Name}: ";
            flies = flyenabled;
        }

        private void Game_Area_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hu.wikipedia.org/wiki/Malom_(j%C3%A1t%C3%A9k)");
        }

        private void player2_LBL_Click(object sender, EventArgs e)
        {

        }
    }
}
