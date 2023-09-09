using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pokaz_Click(object sender, EventArgs e)
        {
            Beach.Visible = true;
        }

        private void Pokaz2_Click(object sender, EventArgs e)
        {
            Cyberpunk.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finkipp.Visible = true;
        }
    }
}
