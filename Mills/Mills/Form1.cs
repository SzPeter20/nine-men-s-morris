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
    }
}
