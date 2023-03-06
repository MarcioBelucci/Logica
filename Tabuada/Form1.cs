using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //DANILO
            //int num = Convert.ToInt32(txtTabuada.Text);
            //int i = 0;

            //while(i <= 10)
            //{

            //    lboxTabuada.Items.Add(num + " x " + i + " = " + num * i);
            //    i++;
            //}

            //for (int i = 0; i <= 10; i ++)
            //{
            //    lboxTabuada.Items.Add(num + " x " + i + " = " + num * i);
            //}

            //do
            //{
            //    lboxTabuada.Items.Add(num + " x " + i + " = " + (num * i));
            //    i++;
            //} while (i <= 10);

            //RENATA
            int tabuada = Convert.ToInt32(txtTabuada.Text);
            
            for(int inicio = 0; inicio <= 10; inicio++)
            {
                lboxTabuada.Items.Add(tabuada + " x " + inicio + " = " + (inicio * tabuada));
            }
        }   
    }
}
