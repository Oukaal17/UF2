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
    public partial class CONECTA_4 : Form
    {
        public CONECTA_4()
        {
            InitializeComponent();
                for (int i = 0; i < tauler.GetLength(0); i++)
                {
                    for (int j = 0; j < tauler.GetLength(1); j++)
                    {
                        tauler[i, j] = "[ ]";
                    }
                }
                Pintar();
            txTauler.Enabled=false;
        }

        String[,] tauler = new string[6, 7];
        Random rand = new Random();
        bool torn = true;
        //true --> 1
        //false -->2
        int y;
        String fitxaJ1 = "[¹]";
        String fitxaJ2 = "[²]";
        int contador = 0;
        int cont = 0;
        int tirada = 0;

        private void PantallaBuida()
        {
            txTauler.Text = "";
            torn = true;
            for (int i = 0; i < tauler.GetLength(0); i++)
            {
                for (int j = 0; j < tauler.GetLength(1); j++)
                {
                    tauler[i, j] = "[ ]";
                }
            }
        }
        private void Pintar()
        {
            for (int i = 0; i < tauler.GetLength(0); i++)
            {
                for (int j = 0; j < tauler.GetLength(1); j++)
                {
                    txTauler.Text = txTauler.Text + tauler[i, j];
                }
                txTauler.Text = txTauler.Text + Environment.NewLine;
            }
        }
        private void FILES(string fitxa)
        {
            //comprova contador (bloqeuja contador i la recorres [columna])
            for (int i = 0; i < tauler.GetLength(1); i++)
            {
                if (tauler[tirada, i] == fitxa)
                {
                    contador++;
                }
                else
                {
                    contador = 0;
                }
                if (contador == 4)
                {
                    MessageBox.Show("CONECTA 4! Jugador  " + fitxa);
                    PantallaBuida();
                    return;
                }
            }
        }
        private void COLUMNES(string fitxa)
        {
            //Comprovar columna
            for (int j = 0; j < tauler.GetLength(0); j++)
            {
                if (tauler[j, y] == fitxa)
                {
                    contador++;
                }
                else
                {
                    contador = 0;
                }
                if (contador == 4)
                {
                    MessageBox.Show("CONECTA 4! Jugador  " + fitxa);
                    PantallaBuida();
                    return;
                }
            }
        }

        private void DIAGONAL(string fitxa)
        {
            contador = 0;
            for (int i=0; i<tauler.GetLength(0)-3; i++)
            {
                for(int j=3; j<tauler.GetLength(1);j++)
                {
                    for(int k=0; k<4; k++)
                    {
                        if (tauler[i+k, j+k]==fitxa)
                        {
                            contador++;
                        }
                        else
                        {
                            contador = 0;
                        }
                        if(contador==4)
                        {
                            MessageBox.Show("Completa 4 Diagonal /");
                            return;
                        }
                    }
                }
            }
            //COMPROVAR ALTRE DIAGONAL
            cont = 0;
            for (int i = 0; i < tauler.GetLength(0) - 3; i++)
            {
                for (int j = 3; j < tauler.GetLength(1); j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (tauler[i + k, j - k] == fitxa)
                        {
                            cont++;
                        }
                        else
                        {
                            cont = 0;
                        }
                        if (cont == 4)
                        {
                            MessageBox.Show("Daigonal ");
                            return;
                        }
                    }
                }
            }
            }
        public void Omplir(string[,]tauler, int y)
        {
            int aux = 0;
            for (int i = tauler.GetLength(0) - 1; i >= 0; i--)
            {
                if (tauler[i, y] == "[ ]")
                {
                    //tirada --> la contador que s'ha omplert
                    tirada = i;
                    if (torn)
                    {
                        tauler[i, y] = fitxaJ1;
                        aux++;
                        torn = !torn;
                        break;
                    }
                    else
                    {
                        tauler[i, y] = fitxaJ2;
                        aux++;
                        torn = !torn;
                        break;
                    }
                }
            }
            if (aux == 0)
            {
                MessageBox.Show("Tria una altra columna !");
                return;
            }
        }
        private void btJuga1_Click(object sender, EventArgs e)
        {
            PantallaBuida();
            //txTauler.Text = "";
            ////--------------------------------------------------------EMPLENAR
            //for (int i = 0; i < tauler.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tauler.GetLength(1); j++)
            //    {
            //        tauler[i, j] = "[ ]";
            //    }
            //}
            //--------------------------------------------------------PINTAR
            Pintar();
            //for (int i = 0; i < tauler.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tauler.GetLength(1); j++)
            //    {
            //        txTauler.Text = txTauler.Text + tauler[i, j];
            //    }
            //    txTauler.Text = txTauler.Text + Environment.NewLine;
            //}
            //------------------------------------------------------------------------------------------------------------
        }

        /*CODI DE BUTTONS DE COLUMNA*/
        private void btC1_Click(object sender, EventArgs e)
        {
            y =0;
            Omplir(tauler, y);
            txTauler.Text = "";
            Pintar();
            FILES(fitxaJ1);
            FILES(fitxaJ2); 
            COLUMNES(fitxaJ1); COLUMNES(fitxaJ2);            
            DIAGONAL(fitxaJ1);
            DIAGONAL(fitxaJ2);
        }
        private void btC2_Click(object sender, EventArgs e)
        {
            y =1;
            Omplir(tauler, y);
            txTauler.Text = "";
            Pintar();
            FILES(fitxaJ1);
            FILES(fitxaJ2); COLUMNES(fitxaJ1); COLUMNES(fitxaJ2);            
            DIAGONAL(fitxaJ1);
            DIAGONAL(fitxaJ2);
        }
        private void btC3_Click(object sender, EventArgs e)
        {
            y =2;
            Omplir(tauler, y);
            txTauler.Text = "";
            Pintar();
            FILES(fitxaJ1);
            FILES(fitxaJ2); COLUMNES(fitxaJ1); COLUMNES(fitxaJ2);            
            DIAGONAL(fitxaJ1);
            DIAGONAL(fitxaJ2);
        }
        private void btC4_Click(object sender, EventArgs e)
        {
            y =3;
            Omplir(tauler, y);
            txTauler.Text = "";
            Pintar();
            FILES(fitxaJ1);
            FILES(fitxaJ2); COLUMNES(fitxaJ1); COLUMNES(fitxaJ2);            
            DIAGONAL(fitxaJ1);
            DIAGONAL(fitxaJ2);
        }
        private void btC5_Click(object sender, EventArgs e)
        {
            y =4;
            Omplir(tauler, y);
            txTauler.Text = "";
            Pintar();
            FILES(fitxaJ1);
            FILES(fitxaJ2); COLUMNES(fitxaJ1); COLUMNES(fitxaJ2);            
        }
        private void btC6_Click(object sender, EventArgs e)
        {
            y =5;
            Omplir(tauler, y);
            txTauler.Text = "";
            Pintar();
            FILES(fitxaJ1);
            FILES(fitxaJ2); COLUMNES(fitxaJ1); COLUMNES(fitxaJ2);            
        }
        private void btC7_Click(object sender, EventArgs e)
        {
            y =6;
            Omplir(tauler, y);
            txTauler.Text = "";
            Pintar();
            FILES(fitxaJ2); COLUMNES(fitxaJ1); COLUMNES(fitxaJ2);            
        }
    }
}
