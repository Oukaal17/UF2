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
    public partial class Bingo : Form
    {
        public Bingo()
        {
            InitializeComponent();
        }
        int contadorJ1 = 0;
        int contadorJ2 = 0;
        private void btReset_Click(object sender, EventArgs e)
        {
            txBox1.Text = "";
            txBox2.Text = "";
            txBox11.Text = "";
            contadorJ1 = 0;
            contadorJ2 = 0;
        }
        String[] cartroJ1 = new string[7];
        String[] cartroJ2 = new string[7];
        Random r = new Random();
        private void btCartro_Click(object sender, EventArgs e)
        {
            //EMPLENAR CARTRÓ
            for (int i = 0; i < cartroJ1.Length; i++)
            {
                cartroJ1[i] = r.Next(1, 31).ToString();
                cartroJ2[i] = r.Next(1, 31).ToString();
            }
            //IMPRIMIR CARTRÓ
            Imprimircartro(cartroJ1, txBox1);
            Imprimircartro(cartroJ2, txBox11);
        }

        private void Imprimircartro(string[] cartro, TextBox tb)
        {
            //IMPRIMIR CARTRÓ
            tb.Text = "";
            for (int i = 0; i < cartroJ1.Length; i++)
            {
                tb.Text = tb.Text + "⌠" + cartro[i] + "⌡";
            }
        }
        private void btBola_Click(object sender, EventArgs e)
        {
            int bola = r.Next(1, 31);
            txBox2.Text = bola.ToString();
            for (int i=0; i<cartroJ1.Length; i++)
            {
                if(bola.ToString()==cartroJ1[i])
                {
                    cartroJ1[i] = "Ꝍ";
                    contadorJ1++;
                }
                else if (bola.ToString() == cartroJ2[i])
                {
                    cartroJ2[i] = "Ꝍ";
                    contadorJ2++;
                }
            }
            Imprimircartro(cartroJ1, txBox1);
            Imprimircartro(cartroJ2, txBox11);
            if (contadorJ1==7 & contadorJ2==7)
            {
                MessageBox.Show(" BINGO EMPAT !!!");
            }
            else if (contadorJ1 == 7)
            {
                MessageBox.Show(" BINGOOO JUGADOR 1 !!!");
            }
            else if (contadorJ2==7)
            {
                MessageBox.Show(" BINGOOO JUGADOR 2 !!!");
            }

        }

        
    }
}
