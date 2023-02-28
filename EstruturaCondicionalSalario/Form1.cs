using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaCondicionalSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if(txtsalario.Text != "")
            {
                //DECLARAR AS VARIAVEIS
                decimal salario = Convert.ToDecimal(txtsalario.Text);
                decimal calcular;

                //CALCULAR AUMENTO

                if (salario >= 5000)
                {
                    // PODERIA SER -> CALCULAR = SALARIO * 1.10; 
                    calcular = salario + (salario * 10 / 100);
                } 

                else if (salario < 5000 && salario >= 2000)
                {
                    //PODERIA SER -> CALCULAR = SALARIO * 1.20;
                    calcular = salario + (salario * 20 / 100);
                }
                 
                else
                {
                    //PODERIA SER -> CALCULAR = SALARIO * 1.30
                    calcular = salario + (salario * 30 / 100);
                }

                txtSalarioFinal.Text = calcular.ToString();
            }
            else
            {
                MessageBox.Show("favor preencher os campos", "!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
