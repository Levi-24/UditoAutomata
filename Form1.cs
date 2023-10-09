using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToltes_Click(object sender, EventArgs e)
        {
            double csoterulet = Math.PI * (Math.Pow(Convert.ToInt32(txbAtmero.Text), 2)) / 4;
            int sebesseg = Convert.ToInt32(txbSebesseg.Text);
            int ido = Convert.ToInt32(txbIdo.Text);

            txbKitoltott.Text = Convert.ToString(Math.Round(csoterulet * (sebesseg * ido), 2));
            pbGlass.Image = Properties.Resources.glassFull;
        }
    }
}
