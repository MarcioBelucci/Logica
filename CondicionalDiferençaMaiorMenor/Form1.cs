using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalDiferençaMaiorMenor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text != "" && txtValor2.Text != "")
            {
                int valor1 = Convert.ToInt32(txtValor1.Text);
                int valor2 = Convert.ToInt32(txtValor2.Text);
                int calcular;

                if (valor1 > valor2)
                {
                    calcular = valor1 - valor2;
                    lbResultado.Text = calcular.ToString();
                    lbResultado.BackColor = Color.LightSkyBlue;
                }
                else
                {
                    calcular = valor2 - valor1;
                    calcular *= -1;
                    lbResultado.Text = calcular.ToString();
                    lbResultado.BackColor = Color.Red;
                }


            }
            else
            {
                MessageBox.Show("Favor Preencher os Campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btCalcularCase_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);
            int valor2 = Convert.ToInt32(txtValor2.Text);
            int calcular = valor1 - valor2;


            //switch (calcular)
            //{
            //    case 0:
            //        calcular = valor1 - valor2;
            //        lbResultado.Text = calcular.ToString();
            //        lbResultado.BackColor = Color.LightSkyBlue;
            //        break;
            //    //default:
            //    //    calcular = valor2 - valor1;
            //    //    lbResultado.Text = calcular.ToString();
            //    //    lbResultado.BackColor = Color.Red;
            //    //    break;

            //}


        }
    }
}
