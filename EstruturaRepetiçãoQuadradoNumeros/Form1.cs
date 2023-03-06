using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepetiçãoQuadradoNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {

            for (int inicio = 15; inicio <= 200; inicio ++)
            {
                lboxLista.Items.Add(inicio + "^2 = " + (inicio * inicio));
            }
        }
    }
}
