using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaCondicionalParImpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            if(txtNumero.Text != "")
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                int verificar = (numero % 2);

                if(verificar == 0 )
                {
                    lbResultado.Text = "Par";
                }
                else
                {
                    lbResultado.Text = "Ímpar";
                }

   
            }
            else
            {
                MessageBox.Show("Favor preencher", "!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
        }
    }
}
