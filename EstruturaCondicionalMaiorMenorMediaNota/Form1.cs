using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaCondicionalMaiorMenorMediaNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if(txtNota01.Text != "" && txtNota02.Text != "" && txtNota03.Text != "" && txtNota04.Text != "")
            {
                //DECLARAR AS VARIAVEIS
                decimal nota01 = Convert.ToDecimal(txtNota01.Text);
                decimal nota02 = Convert.ToDecimal(txtNota02.Text);
                decimal nota03 = Convert.ToDecimal(txtNota03.Text);
                decimal nota04 = Convert.ToDecimal(txtNota04.Text);
                decimal media;
                decimal maiornota = nota01;
                decimal menornota = nota01;

                //CALCULAR A MEDIA 
                media = (nota01 + nota02 + nota03 + nota04) / 4;
                txtMedia.Text = media.ToString();
                

                //MAIOR NOTA
                if(nota02 > maiornota)
                {
                    maiornota = nota02;
                }

                if (nota03 > maiornota)
                {
                    maiornota = nota03;
                   
                }

                if (nota04 > maiornota)
                {
                    maiornota = nota04;
                }

                //MENOR NOTA
                if(nota02 < menornota)
                {
                    menornota = nota02;
                }

                if (nota03 < menornota)
                {
                    menornota = nota03;
                }
                
                if (nota04 < menornota)
                {
                    menornota = nota04;
                }
                //EXIBIR A < > NOTA
                txtMaiorNota.Text = maiornota.ToString();
                txtMenorNota.Text = menornota.ToString();



            }
            else
            {
                MessageBox.Show("Favor preencher os campos", "!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
