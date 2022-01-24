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
    public partial class Form7_5 : Form
    {
        int[] baralla = new int[40];
        Decimal puntsJ1 = 0;
        Decimal puntsJ2 = 0;
        int posicio = 0;
        public Form7_5()
        {
            InitializeComponent();
            btCartaJ1.Enabled = false;
            btStopJ1.Enabled = false;
            btCartaJ2.Enabled = false;
            btStopJ2.Enabled = false;

        }
        
        private void btIniciar_Click(object sender, EventArgs e)
        {
            puntsJ1 = 0;
            puntsJ2 = 0;
            posicio = 0;

            btCartaJ1.Enabled = true;
            btStopJ1.Enabled = true;

            txCartesJ1.Text = "";
            txCartesJ2.Text = "";
            txSortida.Text = "";
            txPuntsJ1.Text = "";
            txPuntsJ2.Text = "";
            int x = 0;
            for (int i=0; i<baralla.Length; i++)
            {
                if (x==12)
                {
                    x = 0;
                }
                baralla[i] = (x + 1);
                x++;
            }
            baralla = Shuffle(baralla);
            ImprimirBaralla();
        }
        private void ImprimirBaralla()
        {
            for (int i=0; i<baralla.Length; i++)
            {
                txSortida.Text = txSortida.Text + baralla[i] + " ";
            }
        }
        public int[] Shuffle(int[] array)
        {
            int n = array.Length;
            Random rnd = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                int j = rnd.Next(i);
                int tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }
        private void btCartaJ1_Click(object sender, EventArgs e)
        {
            while (baralla[posicio]==8 || baralla[posicio]==9)
            {
                posicio++;
            }
            txCartesJ1.Text = txCartesJ1.Text + " " + baralla[posicio].ToString();
            if (baralla[posicio] < 8)
            {
                puntsJ1 = puntsJ1 + baralla[posicio];
            }
            else
            {
                puntsJ1 = puntsJ1 + 0.5m;
            }
            txPuntsJ1.Text = puntsJ1.ToString();
            if (puntsJ1 > 7.5m)
            {
                MessageBox.Show("JUGADOR 1 S'HA PASSAT !!!");
                btCartaJ1.Enabled = false;
                btStopJ1.Enabled = false;
                btCartaJ2.Enabled = true;
                btStopJ2.Enabled = true;
            }
            posicio++;
        }

        private void btStopJ1_Click(object sender, EventArgs e)
        {
            btCartaJ1.Enabled = false;
            btStopJ1.Enabled = false;
            MessageBox.Show("JUGADOR 1 S'HA PLANTAT !!!");
            btCartaJ2.Enabled = true;
            btStopJ2.Enabled = true;
            btCartaJ2.Focus();
        }

        private void btCartaJ2_Click(object sender, EventArgs e)
        {
            while (baralla[posicio] == 8 || baralla[posicio] == 9)
            {
                posicio++;
            }
            txCartesJ2.Text = txCartesJ2.Text + " " + baralla[posicio];
            if (baralla[posicio] < 8)
            {
                puntsJ2 = puntsJ2 + baralla[posicio];
            }
            else if (baralla[posicio] > 9 || baralla[posicio] < 13)
            {
                puntsJ2 = puntsJ2 + 0.5m;
            }
            txPuntsJ2.Text = puntsJ2.ToString();

            if (puntsJ2 > 7.5m)
            {
                MessageBox.Show("JUGADOR 2 S'HA PASSAT !!!");
                btCartaJ2.Enabled = false;
                btStopJ2.Enabled = false;
                Comprovar();
                btIniciar.Focus();
            }
            posicio++;
        }

        private void btStopJ2_Click(object sender, EventArgs e)
        {
            btCartaJ2.Enabled = false;
            btStopJ2.Enabled = false;
            MessageBox.Show("JUGADOR 2 S'HA PLANTAT");
            Comprovar();
            btIniciar.Focus();
        }

        private void Comprovar()
        {
            if (puntsJ1 >= puntsJ2 && puntsJ1 <= 7.5m || puntsJ1>puntsJ2 && puntsJ2>7.5m)
            {
                MessageBox.Show("GUANYA JUGADOR 1 !!!");
            }
            else if (puntsJ1 < puntsJ2 && puntsJ2 <= 7.5m || puntsJ2>puntsJ1 && puntsJ1>7.5m)
            {
                MessageBox.Show("GUANYA JUGADOR 2 !!!");
            }
            else if (puntsJ1 > 7.5m && puntsJ2 > 7.5m)
            {
                MessageBox.Show("NINGÚ HA GUANYAT, TORNA A JUGAR");
            }
        }
    }
}
