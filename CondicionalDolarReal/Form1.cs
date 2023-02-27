using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            if (txtDolar .Text != "" && txtQuantidade .Text != "")
            {
                decimal dolar = Convert.ToDecimal(txtDolar.Text);
                decimal quantidade = Convert.ToDecimal(txtQuantidade.Text);
                decimal real = quantidade * dolar;

                txtReal.Text = real.ToString("n1");

            }
            else
            {
                MessageBox.Show("Favor preencher os campos solicitados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
