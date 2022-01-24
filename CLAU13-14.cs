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
    public partial class CLAU13_14 : Form
    {
        public CLAU13_14()
        {
            InitializeComponent();
        }

        private void btSTART_Click(object sender, EventArgs e)
        {
            String[] clau = txClau.Text.Split('-');
            int clau1 = int.Parse(clau[0]);
            int clau2 = int.Parse(clau[1]);
            if (clau1 > clau2)
            {
                if (clau2 % 2 == 0 && clau1 - 1 == clau2)
                {
                    txComprovació.Text = "CLAU VÀLIDA";
                }
                else
                {
                    txComprovació.Text = "NO";
                }
            }
            else if (clau1 < clau2)
            {
                if (clau1 % 2 == 0 && clau2 - 1 == clau1)
                {
                    txComprovació.Text = "CLAU VÀLIDA";
                }
                else
                {
                    txComprovació.Text = "NO";
                }
            }

        }
    }
}
