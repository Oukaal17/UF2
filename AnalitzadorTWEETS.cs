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
    public partial class AnalitzadorTWEETS : Form
    {
        public AnalitzadorTWEETS()
        {
            InitializeComponent();
        }

        //La Salle mola però mola molt.//
        private void btAnalitzar_Click(object sender, EventArgs e)
        {
            String[] frasebase = txBase.Text.ToUpper().Split(' ');
            int[] contador = new int[frasebase.Length];
            for (int i=0; i<frasebase.Length; i++)
            {
                for (int j=0; j<frasebase.Length;j++)
                {
                    if (frasebase[i] == frasebase[j])
                    {
                        contador[i]++;
                    }
                }
            }
        }
    }
}
