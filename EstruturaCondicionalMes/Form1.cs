using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaCondicionalMes
{
    public partial class fmEstruturaCondicionalMes : Form
    {
        public fmEstruturaCondicionalMes()
        {
            InitializeComponent();
        }

        private void fmEstruturaCondicionalMes_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO MANUALMENTE
            cbMes.Items.Add(01);
            cbMes.Items.Add(02);
            cbMes.Items.Add(03);
            cbMes.Items.Add(04);
            cbMes.Items.Add(05);
            cbMes.Items.Add(06);
            cbMes.Items.Add(07);
            cbMes.Items.Add(08);
            cbMes.Items.Add(09);
            cbMes.Items.Add(10);
            cbMes.Items.Add(11);
            cbMes.Items.Add(12);

            cbMescase.Items.Add(01);
            cbMescase.Items.Add(02);
            cbMescase.Items.Add(03);
            cbMescase.Items.Add(04);
            cbMescase.Items.Add(05);
            cbMescase.Items.Add(06);
            cbMescase.Items.Add(07);
            cbMescase.Items.Add(08);
            cbMescase.Items.Add(09);
            cbMescase.Items.Add(10);
            cbMescase.Items.Add(11);
            cbMescase.Items.Add(12);

        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Mes = Convert.ToInt32(cbMes.SelectedItem);
            if (Mes == 01)
            {
                lbResultado.Text = "Janeiro";
            }
            else if (Mes == 02)
            {
                lbResultado.Text = "Fevereiro";
            }
            else if (Mes == 03)
            {
                lbResultado.Text = "Março";
            }
            else if (Mes == 04)
            {
                lbResultado.Text = "Abril";
            }
            else if (Mes == 05)
            {
                lbResultado.Text = "Maio";

            }
            else if (Mes == 06)
            {
                lbResultado.Text = "Junho";
            }
            else if (Mes == 07)
            {
                lbResultado.Text = "Julho";
            }
            else if (Mes == 08)
            {
                lbResultado.Text = "Agosto";
            }
            else if (Mes == 09)
            {
                lbResultado.Text = "Setembro";
            }
            else if (Mes == 10) 
            {
                lbResultado.Text = "Outubro";
            }
            else if (Mes == 11)
            {
                lbResultado.Text = "Novembro";
            }
            else if (Mes == 12)
            {
                lbResultado.Text = "Dezembro";
            }
            

            
        }

        private void cbMescase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int MesCase = Convert.ToInt32(cbMescase.SelectedItem);
            switch (MesCase)
            {
                case 01:
                    lbResultadocase.Text = "Janeiro";
                    break;
                case 02:
                    lbResultadocase.Text = "Fevereiro";
                    break;
                case 03:
                    lbResultadocase.Text = "Março";
                    break;
                case 04:
                    lbResultadocase.Text = "Abril";
                    break;
                case 05:
                    lbResultadocase.Text = "Maio";
                    break;
                case 06:
                    lbResultadocase.Text = "Junho";
                    break;
                case 07:
                    lbResultadocase.Text = "Julho";
                    break;
                case 08:
                    lbResultadocase.Text = "Agosto";
                    break;
                case 09:
                    lbResultadocase.Text = "Setembro";
                    break;
                case 10:
                    lbResultadocase.Text = "Outubro";
                    break;
                case 11:
                    lbResultadocase.Text = "Novembro";
                    break;
                default:
                    lbResultadocase.Text = "Dezembro";
                    break;
                        

            }
        }
    }
}
