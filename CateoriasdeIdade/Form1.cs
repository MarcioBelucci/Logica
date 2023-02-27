using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriadeIdades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificarIF_Click(object sender, EventArgs e)
        {
            //DECLARAR A VARIAVEL
            int idade = Convert.ToInt32(txtIdade.Text);
            
            //DEFINIR PRE-REQUISITOS
            if (txtIdade.Text != "" && idade >= 5 && idade <= 25)
            { 
                
                if (idade >= 5 && idade <= 10)
                {
                    txtCategoria.Text = "Infantil";
                    txtCategoria.BackColor = Color.LightSkyBlue;

                }
                else if (idade >= 11 && idade <= 15)
                {
                    txtCategoria.Text = "Juvenil";
                    txtCategoria.BackColor = Color.LightGreen; 
                }
                else if (idade >= 16 && idade <= 20)
                {
                    txtCategoria.Text = "Junior";
                    txtCategoria.BackColor = Color.LightYellow;
                }
                else
                {
                    txtCategoria.Text = "Profissional";
                    txtCategoria.BackColor = Color.Red;
                }

            }
            //MENSSAGEM DE ERRO
            else
            {
                MessageBox.Show("Favor Preencher o campo solicitado, com a idade correta", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btVerificarCase_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            switch (idade)
            {
                case 05:
                case 06:
                case 07:
                case 08:
                case 09:
                case 10:
                    txtCategoria.Text = "Infantil";
                    txtCategoria.BackColor = Color.LightSkyBlue;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    txtCategoria.Text = "Juvenil";
                    txtCategoria.BackColor = Color.LightGreen;
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    txtCategoria.Text = "Junior";
                    txtCategoria.BackColor = Color.Yellow;
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    txtCategoria.Text = "Profissional";
                    txtCategoria.BackColor = Color.Red;
                    break;

                default:
                    MessageBox.Show("Favor preencher os campos adequadamente", "Atençao!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }
    }
}
