using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class formCalculoMedia : Form
    {
        public formCalculoMedia()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txtIdade01.Text != "" && txtIdade02.Text != "" && txtIdade03.Text != "")
            {


                //DECLARAÇÃO DAS VARIÁVEIS
                int idade01, idade02, idade03;
                decimal resultado;

                //ATRIBUIR OS VALORES DAS CAIXINHAS PARA VARIÁVEIS
                idade01 = Convert.ToInt32(txtIdade01.Text);
                idade02 = Convert.ToInt32(txtIdade02.Text);
                idade03 = Convert.ToInt32(txtIdade03.Text);

                //CALCULAR A MEDIA
                resultado = (idade01 + idade02 + idade03) / 3;

                //EXIBIR O RESULTADO NO FORMULÁRIO
                lbResultado.Text = resultado.ToString();

             
            }

            else 
            {
                MessageBox.Show("Favor preencher os campos :)", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtIdade01.BackColor = Color.LightSkyBlue;
                txtIdade02.BackColor = Color.LightSkyBlue;
                txtIdade03.BackColor = Color.Red ;

                txtIdade01.Focus();
            }

        }

     
    }
}
