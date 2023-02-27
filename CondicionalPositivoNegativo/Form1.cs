using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalPositivoNegativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "")
            {
                int numero = Convert.ToInt32(txtNumero.Text);

                if (numero > 0)
                {
                    lbResultado.Text = "Positivo seu modulo é " + numero;
                }
                else if (numero == 0)
                {
                    lbResultado.Text = "Neutro seu modulo é " + numero;
                }
                else
                {
                    lbResultado.Text = "Negativo seu modulo é " + numero * -1;
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
