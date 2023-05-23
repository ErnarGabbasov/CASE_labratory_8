using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pac pac = new Pac();
            pac.Owner = this;
            pac.Show();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Owner = this;
            about.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZapisForm zapis = new ZapisForm();
            zapis.Owner = this;
            zapis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dr zapisForm = new Dr();
            zapisForm.Owner = this;
            zapisForm.Show();
        }
    }
}
