using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalNomeSexo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //CARREGAR OS SEXOS QUANDO ABRIR O FORMULARIO
            cbSexo.Items.Add ("Masculino");
            cbSexo.Items.Add("Feminino");
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            if (txtNome .Text != "")
            {
                string nome = txtNome.Text;
                
                if (cbSexo.SelectedItem == "Masculino")
                {
                    lbVerificacao.Text = "Ilmo Sr." + nome; 
                }
                else
                {
                    lbVerificacao.Text = "Ilma Sra." + nome;
                }

            }
            else
            {
                MessageBox.Show("Favor Preencher os Campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        
    }
}
