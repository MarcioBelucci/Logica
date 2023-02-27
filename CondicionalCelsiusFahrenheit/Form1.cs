using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalCelsiusFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConverter_Click(object sender, EventArgs e)
        {
            if (txtCelsius.Text != "")
            {
                decimal celsius = Convert.ToDecimal(txtCelsius.Text);
                decimal fahrenheit = (celsius * 9 + 160) / 5;

                txtFahrenheit.Text = fahrenheit.ToString();
            }
            else
            {
                MessageBox.Show("Favor preencher o campo solicitado", "Atenção", MessageBoxButtons.OK , MessageBoxIcon.Hand);
            }
        }
    }
}
