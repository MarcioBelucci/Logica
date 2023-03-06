using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaCondicionalVendaPorcentagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE OS CAMPOS ESTÃO PREENCHIDOS
            if(txtCusto.Text != "" && txtPorcentagem.Text != "")
            {
                //DECLARAR AS VARIAVAEIS 
                decimal Custo = Convert.ToDecimal(txtCusto.Text);
                decimal Porcentagem = Convert.ToDecimal(txtPorcentagem.Text);
                decimal Venda = 0;

                //CALCULO DE REVENDA
                Venda = Custo + (Custo * Porcentagem / 100);
                txtVenda.Text = Venda.ToString("n2");

            }
            else
            {
                //MENSAGEM DE ERRO
                MessageBox.Show("É necessário preencher", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCusto.Focus();
            }
        }

    }
}
