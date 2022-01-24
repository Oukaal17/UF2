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
    public partial class Reordenarfrase : Form
    {
        public Reordenarfrase()
        {
            InitializeComponent();
        }

        private void btProcessar_Click(object sender, EventArgs e)
        {
            string[] frase = txFrase.Text.Split(' '); ////les posicions són tots els espais que trobi +1.
                                                      ////si en comptes d'espai, posem una lletra o alguna altra cosa, en la frase s'elimina i se separen altres paraules
                                                      ////Split només en String. Només es pot posar 1sol caràcter.
            //for (int i=frase.Length-1; i>=0 ; i--)
            //{
            //    ////MessageBox.Show(frase[i]);
            //    txReordenat.Text = txReordenat.Text + " " +frase[i];
                
            //}
            txReordenat.Text = "";
            for(int i=0; i<frase.Length; i++)
            {
                txReordenat.Text = frase[i] + " " +txReordenat.Text;
            }
        }
    }
}
