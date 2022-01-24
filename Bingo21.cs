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
    public partial class Bingo21 : Form
    {
        public Bingo21()
        {
            InitializeComponent();
        }
        //Inicialitzaem array de boles
        String[,] cartroJ1 = new string[3, 7];
        String[,] cartroJ2 = new string[3, 7];
        String[] boles = new string[90];
        Random r = new Random();
        //int contaJ1 = 0;
        //int contaJ2 = 0;
        private void btCartro_Click_1(object sender, EventArgs e)
        {
            //contaJ1 = 0;
            //contaJ2 = 0;
            x = 0;
            for (int i = 0; i < boles.Length; i++)
            {
                boles[i] = (i + 1).ToString();
            }
            //Desordenem array de boles
            boles = Shuffle(boles);
            int cont = 0;
            //carregar cartro1
            for(int i=0; i<cartroJ1.GetLength(0); i++)
            {
                for (int j=0; j<cartroJ1.GetLength(1); j++)
                {
                    cartroJ1[i, j] = boles[cont]; 
                    cont++;
                    //cartroJ1[i, j] = boles[(i*7)+j];
                }
            }
            txBox1.Text = "";
            //Desordenem array de boles
            boles = Shuffle(boles);
            cont = 0;
            //carregar cartro2
            for (int i=0; i<cartroJ2.GetLength(0); i++)
            {
                for (int j = 0; j < cartroJ2.GetLength(1); j++)
                {
                    cartroJ2[i, j] = boles[cont];
                    cont++;
                    //cartroJ2[i, j] = boles[(i * 7) + j];
                }
            }
            //Desordenem array de boles per extreure la bola
            boles = Shuffle(boles);
            Imprimircartro(cartroJ1, txBox1);
            Imprimircartro(cartroJ2, txBox11);

            txBox11.Text = "";
            for (int i = 0; i < cartroJ2.GetLength(0); i++)
            {
                for (int j = 0; j < cartroJ2.GetLength(1); j++)
                {
                    txBox11.Text = txBox11.Text + "⌠" + cartroJ2[i, j] + "⌡";
                }
                txBox11.Text = txBox11.Text + Environment.NewLine;
            }
        }
        private void Imprimircartro(string[,] cartro, TextBox tb)
        {
            //IMPRIMIR CARTRÓ
            tb.Text = "";
            for (int i = 0; i < cartro.GetLength(0); i++)
            {
                for (int j = 0; j < cartro.GetLength(1); j++)
                {
                    tb.Text = tb.Text + "⌠" + cartro[i, j] + "⌡";
                }
                tb.Text = tb.Text + Environment.NewLine;
            }
        }
        public string[] Shuffle(string[] array)
        {
            int n = array.Length;
            Random rnd = new Random();
            for (int i=n-1; i>0; i--)
            {
                int j = rnd.Next(i);
                string tmp = array[j];
                array[j] = array[i-1];
                array[i-1] = tmp;
            }
            return array;
        }
        int x = 0;
        bool bingoJ1 = false;
        bool bingoJ2 = false;
        bool linea = false;
        bool lineajugador = false;

        private void btBola_Click(object sender, EventArgs e)
        {
            bingoJ1 = true;
            bingoJ2 = true;
            txBox2.Text = boles[x];
            x++;
            //Comprobar numeros del cartró J1
            for (int i=0; i<cartroJ1.GetLength(0); i++)
            {
                lineajugador = true;
                for(int j=0; j<cartroJ1.GetLength(1); j++)
                {
                    if (boles[x] == cartroJ1[i, j])
                    {
                        cartroJ1[i, j] = "Ꝍ";
                        //contaJ1++;
                    }
                    if (cartroJ1[i,j] != "Ꝍ")
                    {
                        bingoJ1 = false;
                        lineajugador = false;
                    }
                }
                if (lineajugador && !linea)
                {
                    MessageBox.Show("Línea Jugador 1");
                    linea = true;
                }
            }
            //Comprobar numeros del cartró J2
            for (int i = 0; i < cartroJ2.GetLength(0); i++)
            {
                for (int j = 0; j < cartroJ2.GetLength(1); j++)
                {
                    if (boles[x] == cartroJ2[i, j])
                    {
                        cartroJ2[i, j] = "Ꝍ";
                        //contaJ2++;
                    }
                        if (cartroJ2[i, j] != "Ꝍ")
                        {
                            bingoJ2 = false;
                            lineajugador = false;
                        }
                }
                if (lineajugador && !linea)
                {
                    MessageBox.Show("Línea Jugador 2");
                    linea = true;
                }
            }
            Imprimircartro(cartroJ1, txBox1);
            Imprimircartro(cartroJ2, txBox11);

            //if(contaJ1==21 && contaJ2==21)
            //{
            //    MessageBox.Show("BINGOOO AMBDÓS JUGADORS");
            //}
            //else if(contaJ1==21)
            //{
            //    MessageBox.Show("BINGOOO JUGADOR 1");
            //}
            //else if(contaJ2==21)
            //{
            //    MessageBox.Show("BINGOOO JUGADOR 2");
            //}

            if (bingoJ1 && bingoJ2)
            {
                MessageBox.Show("BINGOOO AMBDÓS JUGADORS");
            }
            else if (bingoJ1)
            {
                MessageBox.Show("BINGOOO JUGADOR 1");
            }
            else if (bingoJ2)
            {
                MessageBox.Show("BINGOOO JUGADOR 2");
            }

        }
    }
}
