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
    public partial class privatesuma : Form
    {
        public privatesuma()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            int suma1 = suma(1, 3);
            suma1 = suma(suma(1, 2), suma(1, 5));
            txBox1.Text = suma1.ToString();
        }

        private int suma(int a, int b)
        {
            return a + b;
        }
        private int resta(int a, int b)
        {
            return a - b;
        }
        private int multiplicaico(int a, int b)
        {
            return a * b;
        }
        private String divisio(int a, int b)
        {
            if (b==0)
            {
                return "Divisió entre 0, no possible";
            }
            else
            {
                return (a / b).ToString();

            }
        }
    }
}
