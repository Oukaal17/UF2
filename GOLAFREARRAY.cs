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
    public partial class GOLAFREARRAY : Form
    {
        public GOLAFREARRAY()
        {
            InitializeComponent();
        }
        
        private void btGo_Click(object sender, EventArgs e)
        {
            txMenjar.Text = "";
            Random rand = new Random();
            //String[] menjar = txMenjar.Text.Split(',');
            String[] menjar = new string[10];
            for (int i=0; i<menjar.Length; i++)
            {
                menjar[i] = rand.Next(1, 101).ToString();
                txMenjar.Text = txMenjar.Text + menjar[i] + ",";
            }
            int profe = 0;
            int alumne = 0;
            int p1 = 0;
            int p2 = 0;
                int pos1 = 0;
                int posF = menjar.Length-1;
                    int torn = 0;
                    //torn0 ---> professor
                    //torn1 ---> alumne
            for (int i=0; i<menjar.Length; i++)
            {
                p1 = int.Parse(menjar[pos1]);
                p2 = int.Parse(menjar[posF]);
                    if(p1>=p2)
                    {
                        if(torn==0)
                        {
                            profe = profe + p1;
                            torn = 1;
                        }
                        else
                        {
                        alumne = alumne + p1;
                            torn = 0;
                        }
                    pos1++;
                }
                    else
                    {
                        if (torn == 0)
                        {
                            profe = profe + p2;
                            torn = 1;
                        }
                        else
                        {
                            alumne = alumne + p2;
                            torn = 0;
                        }
                    posF--;
                }
            }
            txAlumne.Text = alumne.ToString();
            txProfessor.Text = profe.ToString();
        }
    }
}
