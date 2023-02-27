using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtIdade .Text != "" && txtAltura.Text != "" && txtPeso.Text != "")
            {
                //DECLARAR AS VARIAVEIS
                string nome = Convert.ToString(txtNome.Text);
                int idade = Convert.ToInt32(txtIdade.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                double peso = Convert.ToDouble(txtPeso.Text);
                double imc = peso / (altura *altura);

                //lbIMC.Text = imc.ToString("n1");
                //DE ACORDO COM A TABELA POR PESOS
                if (imc <= 18.59)
                {
                    lbIMC.Text = nome + " " + idade + " anos, está Abaixo do Peso"; 
                }
                else if (imc >= 18.69 && imc <= 24.99)
                {
                    lbIMC.Text = nome + " " + idade + " anos, está no Peso Ideal";
                }
                else if (imc >= 25 && imc <= 29.99)
                {
                    lbIMC.Text = nome + " " + idade + " anos, está Acima do Peso";
                }
                else if (imc >= 30 && imc <= 34.99)
                {
                    lbIMC.Text = nome + " " + idade + " anos, está com Obesidade I";
                }
                else if (imc >= 35 && imc <= 39.99)
                {
                    lbIMC.Text = nome + " " + idade + " anos, está com Obesidade II";
                }
                else if (imc >= 40)
                {
                    lbIMC.Text = nome + " " + idade + " anos, está com Obesidade Mórbida";                   
                }
            }
            else
            {
                MessageBox.Show("Favor preencher os campos solicitados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
