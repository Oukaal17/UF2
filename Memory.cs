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
    public partial class Memory : Form
    {
        String[] baralla = new string[16];
        String[,] tauler2 = new String[4, 4];
        String[,] cartes = new String[4,4]; 
        int x = 0;
        public Memory()
        {
            InitializeComponent();
        }
        private void ImprimirTauler()
        {
            for (int i = 0; i < cartes.GetLength(0); i++)
            {
                for (int j = 0; j < cartes.GetLength(1); j++)
                {
                    txTauler.Text = txTauler.Text + "["+cartes[i, j]+"]";
                }
                txTauler.Text = txTauler.Text + Environment.NewLine;
            }
        }

        private bool ComprovarFinal()
        {
            Boolean final = true;
            for (int i=0; i<cartes.GetLength(0);i++)
            {
                for (int j=0; j<cartes.GetLength(1); j++)
                {
                    if(tauler2[i,j]=="#")
                    {
                        final = false;
                    }
                }
            }
            return final;
        }
        private void ImprimirT2()
        {
            for (int i = 0; i < tauler2.GetLength(0); i++)
            {
                for (int j = 0; j < tauler2.GetLength(1); j++)
                {
                    tx2.Text = tx2.Text + "{"+tauler2[i, j]+"}";
                }
                tx2.Text = tx2.Text + Environment.NewLine;
            }
        }
        private void ImprimirArray(string[] baralla, TextBox tb)
        {
            tb.Text = "";
            for (int i = 0; i < baralla.Length; i++)
            {
                tb.Text = tb.Text + "[" + baralla[i] + "]";
            }
        }
        public String[] Shuffle(String[] array)
        {
            int n = array.Length;
            Random rnd = new Random();
            for (int i = n; i > 0; i--)
            {
                int j = rnd.Next(i);
                String tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
            return array;
        }
        private void btIniciar_Click(object sender, EventArgs e)
        {
            x = 0;
            txVisualitzacio.Text = "";
            txTauler.Text = "";
            tx2.Text = "";
            txM1C1.Text = "";
            txM1C2.Text = "";
            txM2C1.Text = "";
            txM2C2.Text = "";

            for(int i=0; i<baralla.Length; i++)
            {
                if(i%2==0)
                {
                    baralla[i] = (x + 1).ToString();
                    x++;
                }
                else
                {
                    baralla[i] = x.ToString();
                }
                txVisualitzacio.Text = txVisualitzacio.Text + baralla[i];
            }
            baralla = Shuffle(baralla);
            ImprimirArray(baralla, txVisualitzacio);
            for (int i=0; i<cartes.GetLength(0); i++)
            {
                for (int j=0; j<cartes.GetLength(1); j++)
                {
                    cartes[i, j] = "#";
                }
            }
            ImprimirTauler();
            int contador = 0;
            for(int i=0; i<tauler2.GetLength(0); i++)
            {
                for(int j=0; j<tauler2.GetLength(1); j++)
                {
                    tauler2[i, j] = baralla[contador];
                    contador++;
                }
            }
            ImprimirT2();
        }

        int M1C1;
        int M1C2;
        int M2C1;
        int M2C2;
        private void btDestapar_Click(object sender, EventArgs e)
        {
            //M1C1 = int.Parse(txM1C1.Text) - 1;
            //M1C2 = int.Parse(txM1C2.Text) - 1;
            //M2C1 = int.Parse(txM2C1.Text) - 1;
            //M2C2 = int.Parse(txM2C2.Text) - 1;
            try
            {
                M1C1 = int.Parse(txM1C1.Text)- 1;
                M1C2 = int.Parse(txM1C2.Text)- 1;
                M2C1 = int.Parse(txM2C1.Text)- 1;
                M2C2 = int.Parse(txM2C2.Text)- 1;
            }
            catch
            {
                MessageBox.Show("INTRODUEIX UN NÚMERO");
                txM1C1.Focus();
                txM1C1.SelectAll();
                txM1C2.Clear();
                txM2C1.Clear();
                txM2C2.Clear();
                return;
            }
            
            if (M1C1 < 0 || M1C2 < 0 || M2C1 < 0 || M2C2 < 0 || M1C1 >= tauler2.GetLength(0) || 
                M1C2 >= tauler2.GetLength(1) || M2C1 >= tauler2.GetLength(0) || M2C2 >= tauler2.GetLength(1))
            {
                MessageBox.Show("ENTRA UN NÚMERO DINS DEL RANG DE LA MATRIU");
                txM1C1.Focus();
                txM1C1.Text = "";
                txM1C2.Text = "";
                txM2C1.Text = "";
                txM2C2.Text = "";
                return;
            }
            if (M1C1 == M1C2 && M2C1 == M2C2)
            {
                MessageBox.Show("NO TRIIS LA MATEIXA CARTA");
                txM1C1.Focus();
                txM1C1.Text = "";
                txM1C2.Text = "";
                txM2C1.Text = "";
                txM2C2.Text = "";
                return;
            }
            if (cartes[M1C1, M2C1] == "#" )
            {
                //DO NORHING
                cartes[M1C1, M2C1] = tauler2[M1C1, M2C1];
            }
            else
            {
                MessageBox.Show("CARTA 1 JA ESTÀ DESTAPADA");
                return;
            }
            if (cartes[M1C2, M2C2] == "#")
            {
                //DO NORHING
                cartes[M1C2, M2C2] = tauler2[M1C2, M2C2];
            }
            else
            {
                MessageBox.Show("CARTA 2 JA ESTÀ DESTAPADA");
                return;
            }
            //cartes[M1C1, M2C1] = "#";
            //cartes[M1C2, M2C2] = "#";
            cartes[M1C2, M2C2] = tauler2[M1C2, M2C2];
            txTauler.Text = "";
            ImprimirTauler();

            if(cartes[M1C1, M2C1]!=cartes[M1C2,M2C2])
            {
                cartes[M1C1, M2C1] = "#";
                cartes[M1C2, M2C2] = "#";
            }
            ComprovarFinal();
        }
    }
}
