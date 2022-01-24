using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UF2
{
    public partial class Reordenarfrase2 : Form
    {
        public Reordenarfrase2()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            txReordenat.Text = "";
            Random r = new Random();
            string[] frase = txFrase.Text.Split(' ');
            for (int i=0; i<frase.Length; i++)
            {
                txReordenat.Text= txReordenat.Text + " " + frase[r.Next(0, frase.Length)];
            }
        }
    }
}
