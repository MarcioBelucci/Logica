using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepetiçãoDivi3ou4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            for (int num = 0; num <= 30; num ++)
            {
                if (num % 3 == 0 || num % 4 ==0)
                {
                    lboxImpressao.Items.Add(num);
                }
            }
        }
    }
}
