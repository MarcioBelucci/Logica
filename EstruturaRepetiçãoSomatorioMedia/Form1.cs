using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepeticaoSomatorioMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            int inicio = 2;
            double media;
            int soma = 0;

            while(inicio <= 500)
            {
                soma = inicio + soma;
                media = soma / 250;
                txtSoma.Text = soma.ToString ();
                txtMedia.Text = media.ToString ();
                inicio += 2;

            }
        }

        private void btVerificarImpar_Click(object sender, EventArgs e)
        {
            int inicio = 1;
            double media;
            int soma = 0;

            while (inicio <= 499)
            {
                soma = inicio + soma;
                media = soma / 250;
                txtSoma.Text = soma.ToString();
                txtMedia.Text = media.ToString();
                inicio += 2;

            }
        }

        private void btVerificarTotal_Click(object sender, EventArgs e)
        {
            int inicio = 1;
            decimal media;
            int soma = 0;

            while (inicio <= 500)
            {
                soma = inicio + soma;
                media = soma / 500;
                txtSoma.Text = soma.ToString();
                txtMedia.Text = media.ToString("n2");
                inicio ++;

            }
        }
    }
}
