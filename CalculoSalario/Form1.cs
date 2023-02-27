using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txtNFilhos.Text != "" && txtNHorasTrabalhadas.Text != "" && txtNome.Text != "" && txtValorHora.Text != "")
            {
                double numerohoras = Convert.ToDouble(txtNHorasTrabalhadas.Text);
                int numerofilhos = Convert.ToInt32(txtNFilhos.Text);
                double valorhora = Convert.ToDouble(txtValorHora.Text);
                double salariobruto;
                double salariofinal;
                //CALCULAR O SALARIO
                salariobruto = (numerohoras * valorhora);
                salariofinal = salariobruto + numerofilhos * (salariobruto * 0.03);
                txtSalario.Text = salariofinal.ToString();


            }
            else
            {
                MessageBox.Show("Favor preencher os campos :)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
