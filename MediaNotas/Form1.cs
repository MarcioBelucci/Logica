using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStatusAluno_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE TODAS AS CAIXAS DE TEXTOS ESTÃO PREENCHIDAS
            if (txtNota01.Text != "" && txtNota02.Text != "" && txtNota03.Text != "")
            {
                //DECLARAÇÃO DAS VARIÁVEIS
                decimal nota01, nota02, nota03;
                decimal media;

                //ATRIBUI OS VALORES DAS TEXT BOX PARA AS VARIÁVEIS
                nota01 = Convert.ToDecimal(txtNota01.Text);
                nota02 = Convert.ToDecimal(txtNota02.Text);
                nota03 = Convert.ToDecimal(txtNota03.Text);

                //CALCULAR A MEDIA
                media = (nota01 + nota02 + nota03) / 3;

                //EXIBIR O RESULTADO NO FORMULÁRIO
                txtMedia.Text = media.ToString();

                //STATUS DO ALUNO: APROVADO,REPROVADO E RECUPERAÇÃO 
                if (media >= 7)
                {
                    lbStatusdeAprovação.Text = "Aprovado";
                    lbStatusdeAprovação.ForeColor = Color.Blue;
                }

                else if (media < 7 && media >= 5)
                {
                    lbStatusdeAprovação.Text = "Recuperação";
                    lbStatusdeAprovação.ForeColor = Color.Gold;
                }

                else
                {
                    lbStatusdeAprovação.Text = "Reprovado";
                    lbStatusdeAprovação.ForeColor = Color.Red;

                }
            }
                       
            else
            {
                //SEQUENCIA CAIXA DE MENSAGEM: MENSAGEM, TITULO, BOTÃO, ÍCONE
                MessageBox.Show("Favor preencher todas as idades", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //PINTAR AS CAIXAS COMO ALERTA
                txtNota01.BackColor = Color.Red;
                txtNota02.BackColor = Color.Red;
                txtNota03.BackColor = Color.Red;

                //FOCAR NA CAIXA
                txtNota01.Focus();

            }
        }

        private void btStatusCase_Click(object sender, EventArgs e)
        {
            decimal nota01 = Convert.ToDecimal(txtNota01.Text);
            decimal nota02 = Convert.ToDecimal(txtNota02.Text);
            decimal nota03 = Convert.ToDecimal(txtNota03.Text);
            int media;

            media = Convert.ToInt32 (nota01 + nota02 + nota03) / 3;

            //EXIBIR O RESULTADO NO FORMULÁRIO
            txtMedia.Text = media.ToString();

            switch (media)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    lbStatusdeAprovação.Text = "Reprovado";
                    break;
                case 5:
                case 6:
                    lbStatusdeAprovação.Text = "Recuperação";
                    break;
                default:
                    lbStatusdeAprovação.Text = "Aprovado";
                    break;


            }    

        }
    }
}
