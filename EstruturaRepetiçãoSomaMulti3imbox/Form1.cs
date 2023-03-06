using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepetiçãoSomaMulti3mbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            //DECLARAR A  VARIAVEL SOMA
            int soma = 0;
            //LAÇO DE REPETIÇÃO
            for (int num = 1; num <= 1000; num++)
            {
                //ABRI A CONDIÇÃO
                if (num % 3 != 0)
                {
                    soma += num;
                }
            }
            //LOCAL DA RESPOSTA
            MessageBox.Show("A soma é " + soma, "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
