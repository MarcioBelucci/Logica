using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalMediaAlunoImpressao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txtNota1.Text != "" && txtNota2.Text != "" && txtNota3.Text != "" && txtNota4.Text != "" && txtExame.Text != "")
            {
                decimal nota1 = Convert.ToDecimal(txtNota1.Text);
                decimal nota2 = Convert.ToDecimal(txtNota2.Text);
                decimal nota3 = Convert.ToDecimal(txtNota3.Text);
                decimal nota4 = Convert.ToDecimal(txtNota4.Text);
                decimal exame = Convert.ToDecimal(txtExame.Text);
                decimal media;
                decimal medianova;

                media = (nota1 + nota2 + nota3 + nota4) / 4;

                if (media >= 7)
                {
                    lbMedia.Text = "Aprovado. Sua média é " + media.ToString ("n2");
                }
                else
                {

                    medianova = (media + exame) / 2;

                    if (medianova >= 5)
                    {
                        lbMedia.Text = "Aprovado em Exame. Sua média é " + medianova.ToString ("n2");
                    }
                    else
                    {
                        lbMedia.Text = "Reprovado. Sua média é " + medianova.ToString ("n2");
                    }
                }
            }
            else
            {
                MessageBox.Show("FAVOR PREENCHER TODOS OS CAMPOS SOLICITADOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

    }
}
