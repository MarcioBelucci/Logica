using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {   //VERIFICAR SE O CAMPO ESTA PREENCHIDO
            if (txtIdade.Text  != "")
            {   //DECLARAR AS VARIÁVEIS E ATRIBUIR AS CAIXAS
                int idade = Convert.ToInt32(txtIdade.Text);

                //VERIFICAÇÃO DAS PERMISSÕES
                if (idade >= 18)
                {               
                    lbResultado.Text = "Permissão Concedida";
                    lbResultado.ForeColor = Color.Green;
                    //MUDAR A FONTE 
                    lbResultado.Font = new Font("Goudy Stout", 16);
                }
                else
                {
                    lbResultado.Text = "Sem Permissão";
                    lbResultado.ForeColor = Color.Red;
                    //MUDAR A FONTE 
                    lbResultado.Font = new Font("Goudy Stout", 18);
                }
            }
            else
            {   
                //MENSAGEM DE ERRO
                MessageBox.Show("Favor preencher o campo da idade", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtIdade.BackColor = Color.LightBlue;
                txtIdade.Focus();
            }

        }
    }
}
