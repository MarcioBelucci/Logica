using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondicionalDivi2e3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "" && txtNum3.Text != "" && txtNum4.Text != "")
            {
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                int num3 = Convert.ToInt32(txtNum3.Text);
                int num4 = Convert.ToInt32(txtNum4.Text);


                if (num1 % 2 == 0 && num1 % 3 == 0)
                {
                    txtNumeroF1.Text = num1.ToString();
                }
                if (num2 % 2 == 0 && num2 % 3 == 0)
                {
                    txtNumeroF2.Text = num2.ToString();
                }
                if (num3 % 2 == 0 && num3 % 3 == 0)
                {
                    txtNumeroF3.Text = num3.ToString();
                }
                if (num4 % 2 == 0 && num4 % 3 == 0)
                {
                    txtNumeroF4.Text = num4.ToString();
                }
            }
            else
            {
                MessageBox.Show("Favor preencher os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
