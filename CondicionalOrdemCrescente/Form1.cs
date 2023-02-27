using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalOrdemCrescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text != "" && txtValor2 .Text != "" && txtValor3 .Text != "")
            {
                //DECLARAR AS VARIAVEIS
                decimal valor1 = Convert.ToDecimal(txtValor1.Text);
                decimal valor2 = Convert.ToDecimal(txtValor2.Text);
                decimal valor3 = Convert.ToDecimal(txtValor3.Text);
                //CONDIÇÃO PARA CADA UMA POSSIBILIDADE
                if (valor1 < valor2 && valor1 < valor3 && valor2 < valor3)
                {
                    lbOrdemCrescente.Text = valor1 + ";" + valor2 + ";" + valor3;
                }
                else if (valor1 < valor2 && valor1 < valor3 && valor3 < valor2)
                {
                    lbOrdemCrescente.Text = valor1 + ";" + valor3 + ";" + valor2;
                }
                else if (valor2 < valor1 && valor2 < valor3 && valor1 < valor3)
                {
                    lbOrdemCrescente.Text = valor2 + ";" + valor1 + ";" + valor3;
                }
                else if (valor2 < valor1 && valor2 < valor3 && valor3 < valor1)
                {
                    lbOrdemCrescente.Text = valor2 + ";" + valor3 + ";" + valor1;
                }
                else if (valor3 < valor1 && valor3 < valor2 && valor1 < valor2 )
                {
                    lbOrdemCrescente.Text = valor3 + ";" + valor1 + ";" + valor2;
                }
                else if (valor3 < valor1 && valor3 < valor2 && valor2 < valor1)
                {
                    lbOrdemCrescente.Text = valor3 + ";" + valor2 + ";" + valor1;
                }
            }   //MENSSAGEM DE ERRO
            else
            {
                MessageBox.Show("Preencher os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
    }
}
