using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepetiçãoMaiorIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "" && txt4.Text != "" && txt5.Text != "" && txt6.Text != "" && txt7.Text != "" && txt8.Text != "" && txt9.Text != "" && txt10.Text != "")
            {
                int idade1 = Convert.ToInt32(txt1.Text);
                int idade2 = Convert.ToInt32(txt2.Text);
                int idade3 = Convert.ToInt32(txt3.Text);
                int idade4 = Convert.ToInt32(txt4.Text);
                int idade5 = Convert.ToInt32(txt5.Text);
                int idade6 = Convert.ToInt32(txt6.Text);
                int idade7 = Convert.ToInt32(txt7.Text);
                int idade8 = Convert.ToInt32(txt8.Text);
                int idade9 = Convert.ToInt32(txt9.Text);
                int idade10 = Convert.ToInt32(txt10.Text);

                int[] idade = new int[10];
                idade[0] = idade1;
                idade[1] = idade2;
                idade[2] = idade3;
                idade[3] = idade4;
                idade[4] = idade5;
                idade[5] = idade6;
                idade[6] = idade7;
                idade[7] = idade8;
                idade[8] = idade9;
                idade[9] = idade10;

                for (int i = 0; i < 10; i++)
                {
                    if (idade[i] >= 18)

                        lboxMaiorIdade.Items.Add(idade[i]);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
