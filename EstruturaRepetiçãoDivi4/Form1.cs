using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepetiçaoDivi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            //LAÇO DE REPETIÇÃO
            for (int num = 0; num < 200; num += 4)
            {
                lboxNumeros.Items.Add(num);
            }
            //OU
            //for (int num = 0; num < 200; num++)
            //{
            //    if (num % 4 == 0)
            //    {
            //        lboxNumeros.Items.Add(num);
            //    }
            //}
        }
    }
}
