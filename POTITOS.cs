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
    public partial class POTITOS : Form
    {
        public POTITOS()
        {
            InitializeComponent();
        }
        String[] primera;
        String[] segona;
        String[] ingredients;
        /*🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩*/
        private void ImprimirArray(string[] array, TextBox tx)
        {
            tx.Text = "";
            for (int i=0; i<array.Length;i++)
            {
                tx.Text = tx.Text + array[i];
            }
            tx.Text = tx.Text + " ";
        }
        /*🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩🚩*/
        private void ImprimirArrayAUXNO(string[] array, TextBox tx)
        {
            tx.Text = "";
            for (int i = 0; i < array.Length; i++)
            {
                tx.Text = tx.Text + array[i];
            }
            tx.Text ="No pot menjar els següents ingredients: " +  tx.Text;
        }
        private void btSTART_Click(object sender, EventArgs e)
        {
            String [] auxSI = new string [100];
            String [] auxNO = new string [100];
            int si=0;
            int no = 0;
            //(EXEMPLE) Si:patata maiz tomaquet [No:patata porro pèsols pollastre[Si:tomàquet pastanaga porro pollastre carbassó arròs
            primera = txEntrada.Text.Split('[');
            for (int i=0; i<primera.Length; i++)
            {
                segona = primera[i].Split(':');
                ingredients=segona[1].Split(' ');
                if(segona[0].ToUpper()=="SI")
                {
                    for(int j=0; j<ingredients.Length; j++)
                    {
                        auxSI[si] = ingredients[j] + " ";
                        si++;
                    }
                }
                else if (segona[0].ToUpper()=="NO")
                {
                    for (int j = 0; j < ingredients.Length; j++)
                    {
                        auxNO[no] = ingredients[j]+" ";
                        no++;
                    }
                }
            }
            for (int i = 0; i < auxNO.Length; i++)
            {
                for (int j = 0; j < auxSI.Length; j++)
                {
                    if (auxNO[i] == auxSI[j])
                    {
                        auxNO[i] = "";
                    }
                    else
                    {
                        auxNO[i] = auxNO[i];
                    }
                }
            }
            //ImprimirArray(auxSI,txEntrada2);
            ImprimirArrayAUXNO(auxNO, txEntrada3);


        }
    }
}
