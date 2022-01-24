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
    public partial class FormRepas : Form
    {
        public FormRepas()
        {
            //int llargada = 121;
            //arrayINT = new int[5];
            //arrayINT[3] = 3;
            InitializeComponent();
        }

        ////int[] arrayINT;
        String[,] taulell = new string[8,8];
        String posaux = "";
        //String[] dies = new string[7] { "dilluns", "dimarts", "dimecres", "dijous", "divendres", "dissabte", "diumenge" };
        //String[] mesos = new string[12] { "gener", "febrer", "març", "abril", "maig", "juny", "juliol", "agost", "septembre", "octubre", "novembre", "desembre", };
        //int contador = 0;
        int PeoX = 0;
        int peoY = 0;
        int torreX = 0;
        int torreY = 0;
        int ReinaX = 0;
        int ReinaY = 0;
        int CavallX = 0;
        int CavallY = 0;
        //////-------------------------------------------------  EMOJIS ESCACS:  ♔ ♕ ♖ ♗ ♘ ♙-------------------------------------------------------
        Random rand = new Random();
        bool blanc = true;
        private void btBT1_Click(object sender, EventArgs e)
        {
            ////arrayINT = new int[5];
            //////int[] arrayINT = new int[5];
            ////string[] arraySTR = new string[5];
            ////int numero = arrayINT[3];
            ////string lletra = arraySTR[3];
            ////arraySTR[0] = "Hola";
            ////arraySTR[1] = "Hola";
            ////arraySTR[2] = "Hola";
            ////arraySTR[3] = "Hola";
            ////arraySTR[4] = "Hola";

            ////for(int i=0; i<arraySTR.Length; i++)
            ////{
            ////    arraySTR[i] = "Hola";
            ////}
            //////txBox1.Text = lletra.Length.ToString();

 /*!           ////string[] frase = "Hola  que tal".Replace("  "," ").ToUpper().Split(' ');
            ////String paraulaprimera = frase[0];
            ////int llargada = frase.Length;
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------*/
            //if (contador==7)
            //{
            //    contador = 0;
            //}

            //Random rand = new Random();
            //txBox1.Text = dies[rand.Next(0,7)];/* txBox1.Text = dies[contador % 7]  (%7) s'exposa el valor % i la longitud*/
            //txBox2.Text = mesos[rand.Next(0,12)]; /*txBox2.Text = mesos[contador % 12] (%12)així no cal posar dos contador per dos variables diferents*/
            //contador++;
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------*/
            txBox3.Text = "";
            txBoxTorreMata.Text = "";
            torreX = rand.Next(taulell.GetLength(0));
            torreY = rand.Next(taulell.GetLength(1));
            PeoX= rand.Next(taulell.GetLength(0));
            peoY= rand.Next(taulell.GetLength(1));

            if (taulell[torreX,torreY]==taulell[PeoX,peoY])
            {
                torreX = rand.Next(taulell.GetLength(0));
                torreY = rand.Next(taulell.GetLength(1));
            }
            
            //if(taulell[ReinaX,ReinaY]==taulell[torreX,torreY])
            //{
            //    torreX = rand.Next(taulell.GetLength(0));
            //    torreY = rand.Next(taulell.GetLength(1));
            //}
            //------------------------EMPLENAR----------------------------------------------
            for (int i=0; i<taulell.GetLength(0);i++)
            {
                for(int j=0; j<taulell.GetLength(1);j++)
                {
                    if (blanc)
                    {
                        taulell[i, j] = "[🔵]";
                    }
                    else
                    {
                        taulell[i, j] = "[🔶]";
                    }
                    blanc = !blanc;
                }
                blanc = !blanc;
            }
            posaux = taulell[0, 0];
            taulell[PeoX, peoY] = "[♙]";
            taulell[torreX, torreY] = "[♖]";

            //--------------------------PINTAR----------------------------------------------------
            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                   txBox3.Text= txBox3.Text+ taulell[i, j];
                }
                txBox3.Text = txBox3.Text + Environment.NewLine;
            }
            //    if (PeoX == ReinaX && PeoX==torreX||PeoX==ReinaX && peoY==torreY||PeoX==torreX && peoY==ReinaY || peoY == ReinaY && peoY==torreY)
            //    {
            //        MessageBox.Show("Reina i Torre poden matar peó");
            //        return;
            //    }
            //    if (PeoX == ReinaX || peoY == ReinaY)
            //    {
            //        MessageBox.Show("Reina pot matar peó");
            //        return;
            //    }
            //    if (ReinaX == torreX || ReinaY == torreY)
            //    {
            //        MessageBox.Show("Reina pot matar torre");
            //        return;
            //    }
            //    if (ReinaX == torreX && ReinaX == PeoX || ReinaY == torreY && ReinaY == peoY)
            //    {
            //        MessageBox.Show("Reina pot matar torre i peó");
            //        return;
            //    }
            //    if (PeoX == torreX || peoY == torreY)
            //    {
            //        MessageBox.Show("Torre pot matar peó");
            //        return;
            //    }
            while (true)
            {
                if (torreX==PeoX||torreY==peoY)
                {
                    txBoxTorreMata.Text = "TORRE POT MATAR EL PEÓ";
                }
                else
                {
                    txBoxTorreMata.Text = "ENCARA NO L'ATRAPES 😂";
                }
                break;
            }

        }

        private void btReinaApareix_Click(object sender, EventArgs e)
        {
            txBox3.Text = "";
            txBoxTorreMata.Text = "";
            ReinaX = rand.Next(taulell.GetLength(0));
            ReinaY = rand.Next(taulell.GetLength(1));
            PeoX = rand.Next(taulell.GetLength(0));
            peoY = rand.Next(taulell.GetLength(1));
            if (taulell[ReinaX, ReinaY] == taulell[PeoX, peoY])
            {
                ReinaX = rand.Next(taulell.GetLength(0));
                ReinaY = rand.Next(taulell.GetLength(1));
            }
            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                    if (blanc)
                    {
                        taulell[i, j] = "[🔵]";
                    }
                    else
                    {
                        taulell[i, j] = "[🔶]";
                    }
                    blanc = !blanc;
                }
                blanc = !blanc;
            }
            taulell[PeoX, peoY] = "[♙]";
            taulell[ReinaX, ReinaY] = "[♕]";
            /*-------------------------------------------------------------------------------------------------------------------------------------------------*/
            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                    txBox3.Text = txBox3.Text + taulell[i, j];
                }
                txBox3.Text = txBox3.Text + Environment.NewLine;
            }
            for(int i=0; i<taulell.GetLength(0);i++)
            {
                if (ReinaX+i==PeoX && ReinaY+i==peoY|| 
                    ReinaX + i == PeoX && ReinaY - i == peoY||
                    ReinaX - i == PeoX && ReinaY + i == peoY|| 
                    ReinaX - i == PeoX && ReinaY - i == peoY ||
                    ReinaX == PeoX || ReinaY == peoY)
                {
                   txBoxTorreMata.Text = "LA REINA POT MATAR El PEÓ";
                }
                else
                {
                    txBoxTorreMata.Text = "ENCARA NO L'ATRAPES 😂";
                }
            }
        }
        private void btCavall_Click(object sender, EventArgs e)
        {
            txBox3.Text = "";
            txBoxTorreMata.Text = "";
            CavallX = rand.Next(taulell.GetLength(0));
            CavallY = rand.Next(taulell.GetLength(1));
            PeoX = rand.Next(taulell.GetLength(0));
            peoY = rand.Next(taulell.GetLength(1));

            if (taulell[CavallX, CavallY] == taulell[PeoX, peoY])
            {
                CavallX = rand.Next(taulell.GetLength(0));
                CavallY = rand.Next(taulell.GetLength(1));
            }

            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                    if (blanc)
                    {
                        taulell[i, j] = "[🔵]";
                    }
                    else
                    {
                        taulell[i, j] = "[🔶]";
                    }
                    blanc = !blanc;
                }
                blanc = !blanc;
            }
            taulell[PeoX, peoY] = "[♙]";
            taulell[CavallX, CavallY] = "[♘]";

            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                    txBox3.Text = txBox3.Text + taulell[i, j];
                }
                txBox3.Text = txBox3.Text + Environment.NewLine;
            }

            if (CavallX + 2 == PeoX && CavallY + 1 == peoY || 
                    CavallX + 2 == PeoX && CavallY - 1 == peoY ||
                CavallX + 1 == PeoX && CavallY + 2 == peoY || 
                    CavallX + 1 == PeoX && CavallY - 2 == peoY ||
                CavallX - 2 == PeoX && CavallY + 1 == peoY || 
                    CavallX - 2 == PeoX && CavallY - 1 == peoY ||
                CavallX - 1 == PeoX && CavallY + 2 == peoY || 
                    CavallX - 1 == PeoX && CavallY - 2 == peoY)
            {
                txBoxTorreMata.Text = "CAVALL POT MATA A PEÓ";
            }
            else
            {
                txBoxTorreMata.Text = "ENCARA NO L'ATRAPES 😂";
            }
        }




























































        /* int contador = 0;
        private void btBT2_Click(object sender, EventArgs e)
        {
            contadorPeo++;
            if(contadorPeo>7)
            {
                return;//Quan contador més gran de 7, codi no avança
            }
            taulell[contadorPeo-1, 0] = posaux;
            txBox3.Text = "";
            posaux = taulell[contadorPeo, peoY];
            taulell[contadorPeo, peoY] = "[P]";
            for (int i = 0; i < taulell.GetLength(0); i++)
            {
                for (int j = 0; j < taulell.GetLength(1); j++)
                {
                    txBox3.Text = txBox3.Text + taulell[i, j];
                }
                txBox3.Text = txBox3.Text + Environment.NewLine;
            }

            for (int i=0;i<taulell.GetLength(0);i++)
            {
                for (int j=0; j<taulell.GetLength(1);j++)
                {
                    if (contadorPeo==torreX || peoY==torreY)
                    {
                        MessageBox.Show("Torre pot matar peó");
                        return;
                    }
                }
            }
        }*/

    }
}
