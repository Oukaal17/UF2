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
    public partial class Ruleta : Form
    {
        int[] ruleta = new int[72] { 1, 1, 1, 100, 100, 100, 0, 0, 0, 25, 25, 25, 50, 50, 50, 2, 2, 2, 3, 3, 3, 50, 50, 50, 1, 1000, 1, 50, 50, 50, 25, 25, 25, 75, 75, 75, 1, 1, 1, 25, 25, 25, 50, 50, 50, 75, 75, 75, 4, 4, 4, 50, 50, 50, 3, 3, 3, 25, 25, 25, 50, 50, 50, 25, 25, 25, 100, 100, 100, 200, 200, 200 };
        public Ruleta()
        {
            InitializeComponent();
            gbRuleta.Visible = false;
            txFrase.Visible = true;
            btNext.Visible = true;
            txFrase.Focus();
        }
        private void ImprimirArray()
        {
            for (int i = 0; i < txFrase.Text.Length; i++)
            {
                txFraseOculta.Text = txFraseOculta.Text + "⌠#⌡";
            }
        }
        private void btRestart_Click(object sender, EventArgs e)
        {
            txFrase.Text = "";
            txFraseOculta.Text = "";
            txLletra.Text = "";
            txPunts.Text = "";
            txPuntuacio.Text = "";
            txSolucionar.Text = "";
            gbRuleta.Visible = false;
            txFrase.Visible = true;
            txFrase.Focus();
            btNext.Visible = true;
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            btNext.Visible = false;
            txFrase.Visible = false;
            txFrase.Enabled = false;
            gbRuleta.Visible = true;
        }
        private void btGirarRuleta_Click(object sender, EventArgs e)
        {
            ImprimirArray();
        }

    }
}
