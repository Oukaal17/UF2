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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            //array [].
            //Split(' ') només per String ---> Split significa partir caracters.

            int[] cartes = new int[48];
            int contador = 1;
            txBox1.Text = "";
            int punts = 0;
            for (int i = 0; i < cartes.Length; i++)
            {
                cartes[i] = contador;
                txBox1.Text = txBox1.Text + " " + cartes[i];
                contador++;
                if (contador == 13)
                {
                    contador = 1;
                    txBox1.Text = txBox1.Text + Environment.NewLine;
                }
            }

            for (int j=0; j<cartes.Length; j++)
            {
                if(cartes[j]==1)
                {
                    punts = punts + 11;
                }

                else if (cartes[j] == 3)
                {
                    punts = punts + 10;
                }

                else if (cartes[j] == 10)
                {
                    punts = punts + 2;
                }

                else if (cartes[j] == 11)
                {
                    punts = punts + 3;
                }

                else if (cartes[j] == 12)
                {
                    punts = punts + 4;
                }
                else
                {
                    punts = punts + 0;
                }
            }
            txBox1.Text = txBox1.Text + Environment.NewLine + "Els punts totals de la baralla és de: " + punts + " punts";

        }
    }
}
