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
    public partial class illaTresor : Form
    {
        public illaTresor()
        {
            InitializeComponent();
        }

        String[,] illa;
        int num;
        Random r = new Random();
        int tresorX = 0;
        int tresorY = 0;
        String sorra = "[S]";
        int cavarX = 0;
        int cavarY = 0;
        private void btINICIAR_Click(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(txMatriu.Text);
            }
            catch
            {
                MessageBox.Show("INTRODUEIX UN NÚMERO");
                txMatriu.Focus();
                txMatriu.SelectAll();
                return;
            }
            txIlla.Text = "";
            num = int.Parse(txMatriu.Text);
            illa = new string[num, num];

            for (int i = 0; i<illa.GetLength(0); i++)
            {
                for (int j =0; j<illa.GetLength(1); j++)
                {
                    illa[i, j] = sorra;
                }
            }
            txM1.Text = "";
            txM2.Text = "";
            tresorX = r.Next(0, illa.GetLength(0));
            tresorY = r.Next(0, illa.GetLength(1));
            ImprimirIlla();
        }
        private void ImprimirIlla()
        {
            for (int i = 0; i < illa.GetLength(0); i++)
            {
                for (int j = 0; j < illa.GetLength(1); j++)
                {
                    txIlla.Text = txIlla.Text + illa[i, j];
                }
                txIlla.Text = txIlla.Text + Environment.NewLine;
            }
        }
        private void btCAVAR_Click(object sender, EventArgs e)
        {
            try
            {
                cavarX = int.Parse(txM1.Text) - 1;
                cavarY = int.Parse(txM2.Text) - 1;
            }
            catch
            {
                MessageBox.Show("INTRODUEIX UN NÚMERO");
                txM1.Focus();
                txM1.SelectAll();
                txM2.Clear();
                return;
            }
            cavarX = int.Parse(txM1.Text)-1;
            cavarY = int.Parse(txM2.Text)-1;

            if (cavarX < 0 || cavarY < 0 || cavarX >= illa.GetLength(0) || cavarY>=illa.GetLength(1))
            {
                MessageBox.Show("ENTRA UN NÚMERO DINS DEL RANG DE LA MATRIU");
                txM1.Text = "";
                txM2.Text = "";
                return;
            }
            txIlla.Text = "";
            if (cavarX == tresorX && cavarY == tresorY)
            {
                illa[cavarX, cavarY] = "[T]";
                ImprimirIlla();
                txSortida.Text = "Has trobat el tresor !!!";
            }
            else
            {
                illa[cavarX, cavarY] = "[O]";
                ImprimirIlla();
                txSortida.Text = "Segueix provant !!!";
            }



        }
    }
}
