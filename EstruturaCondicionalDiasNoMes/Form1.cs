using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaCondicionalDiasNoMes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
        }

        private void btCalcularCase_Click(object sender, EventArgs e)
        {
            string Mes = cbMes.SelectedItem.ToString();
            int Dias;
            
            //CALCULAR
            switch (Mes)
            {
                case "Janeiro":
                case "Março":
                case "Maio":
                case "Julho":
                case "Agosto":
                case "Outubro":
                case "Dezembro":
                    Dias = 31;
                    break;
                case "Abril":
                case "Junho":
                case "Setembro":
                case "Novembro":
                    Dias = 30;
                    break;
                default:
                    Dias = 28;
                    break;
            }
            txtDias.Text = "São " + Dias;
            txtDias.BackColor = Color.Red;
        }

        private void btIF_Click(object sender, EventArgs e)
        {
            string Mes = cbMes.SelectedItem.ToString();
            int Dias;

            if (Mes == "Janeiro" || Mes == "Março" || Mes == "Maio" || Mes == "Julho" || Mes == "Agosto" || Mes == "Outubro" || Mes == "Dezembro")
            {
                Dias = 31;
                txtDias.Text = "São " + Dias;
                txtDias.BackColor = Color.LightBlue;
            }
            else if (Mes == "Abril" || Mes == "Junho" || Mes == "Setembro" || Mes == "Novembro")
            {
                Dias = 30;
                txtDias.Text = "São " + Dias;
                txtDias.BackColor = Color.LightBlue;
            }
            else
            {
                Dias = 28;
                txtDias.Text = "São " + Dias;
                txtDias.BackColor = Color.LightBlue;
            }

        }        
    }
}
