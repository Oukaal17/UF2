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
    public partial class Bomberman : Form
    {
        String[,] tauler = new string[8, 8];
        String jugador = "[🧍🏽]";
        int PosX;
        int PosY;
        String enemic = "[😈]";
        int posicioenemicX;
        int posicioenemicY;
        Random r = new Random();
        public Bomberman()
        {
            InitializeComponent();
            btFantasma.Enabled = false;
            
        }
        private void Mort()
        {
            if (tauler[PosX,PosY]==tauler[posicioenemicX,posicioenemicY])
            {
                MessageBox.Show("HAS MORT !!! ☠️");
                btAdalt.Enabled = false;
                btAvall.Enabled = false;
                btDreta.Enabled = false;
                btEsquerre.Enabled = false;
                btFantasma.Enabled = true;
            }
        }
        private void ImprimirPantalla()
        {
            for (int i = 0; i < tauler.GetLength(0); i++)
            {
                for (int j = 0; j < tauler.GetLength(1); j++)
                {
                    txPantalla.Text = txPantalla.Text + tauler[i, j];
                }
                txPantalla.Text = txPantalla.Text + Environment.NewLine;
            }
        }
        private void btInici_Click(object sender, EventArgs e)
        {
            btAdalt.Enabled = true;
            btAvall.Enabled = true;
            btDreta.Enabled = true;
            btEsquerre.Enabled = true;
            PosX = 4;
            PosY = 4;
            txPantalla.Text = "";
            posicioenemicX = r.Next(0, tauler.GetLength(0));
            posicioenemicY = r.Next(0,tauler.GetLength(1));
            for (int i = 0; i < tauler.GetLength(0); i++)
            {
                for (int j = 0; j < tauler.GetLength(1); j++)
                {
                        tauler[i, j] = "[#]";
                        tauler[PosX, PosY] = jugador;
                        tauler[posicioenemicX, posicioenemicY] = enemic;
                }
            }
            ImprimirPantalla();
        }
        private void btAdalt_Click(object sender, EventArgs e)
        {
            txPantalla.Text = "";
            if(PosX!=0)
            {
                tauler[PosX, PosY] = "[#]";
                PosX--;
                tauler[PosX, PosY] = jugador;
            }
            else
            {
                if (btFantasma.Enabled == true)
                {
                        tauler[PosX, PosY] = "[#]";
                        PosX = tauler.GetLength(1) - 1;
                        tauler[PosX, PosY] = jugador;
                }
                else
                {
                    //DO NOTHING
                }
            }
            /*-------------------------------------------------------*/
            if (posicioenemicY!= tauler.GetLength(1) - 1)
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicY++;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            else
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicY = 0;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            ImprimirPantalla();
            Mort();
        }
        private void btAvall_Click(object sender, EventArgs e)
        {
            txPantalla.Text = "";
            if (PosX != tauler.GetLength(0)-1)
            {
                tauler[PosX, PosY] = "[#]";
                PosX++;
                tauler[PosX, PosY] = jugador;
            }
            else
            {
                if (btFantasma.Enabled==true)
                {
                        tauler[PosX, PosY] = "[#]";
                        PosX = 0;
                        tauler[PosX, PosY] = jugador;
                }
                else
                {
                //DO NOTHING
                }
            }
            /*-------------------------------------*/
            if(posicioenemicY>0)
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicY--;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            else
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicY = tauler.GetLength(0)-1;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            ImprimirPantalla();
            Mort();
        }
        private void btDreta_Click(object sender, EventArgs e)
        {
            txPantalla.Text = "";
            if (PosY != tauler.GetLength(1)-1)
            {
                tauler[PosX, PosY] = "[#]";
                PosY++;
                tauler[PosX, PosY] = jugador;
            }
            else
            {
                if (btFantasma.Enabled==true)
                {
                    tauler[PosX, PosY] = "[#]";
                    PosY = 0;
                    tauler[PosX, PosY] = jugador;
                }
                else
                {
                //DO NOTHING
                }
            }
            /*--------------------------------------------------*/
            if(posicioenemicX!=0)
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicX--;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            else
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicX = tauler.GetLength(1)-1;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            ImprimirPantalla();
            Mort();
        }
        private void btEsquerre_Click(object sender, EventArgs e)
        {
            txPantalla.Text = "";
            if (PosY != 0)
            {
                tauler[PosX, PosY] = "[#]";
                PosY--;
                tauler[PosX, PosY] = jugador;
            }
            else
            {
                if (btFantasma.Enabled==true)
                {
                    tauler[PosX, PosY] = "[#]";
                    PosY = tauler.GetLength(1) - 1;
                    tauler[PosX, PosY] = jugador;
                }
                else
                {
                    //DO NOTHING
                }
            }
            /*----------------------------------------*/
            if(posicioenemicX!= tauler.GetLength(0)-1)
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicX++;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            else
            {
                tauler[posicioenemicX, posicioenemicY] = "[#]";
                posicioenemicX = 0;
                tauler[posicioenemicX, posicioenemicY] = enemic;
            }
            ImprimirPantalla();
            Mort();
        }
        private void btFantasma_Click(object sender, EventArgs e)
        {
        }

        private void txPantalla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Right)
            {
                
            }
            if (e.KeyCode == Keys.Left)
            {

            }
            if (e.KeyCode == Keys.Up)
            {

            }
            if (e.KeyCode == Keys.Down)
            {

            }
        }
    }
}
