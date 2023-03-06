using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturaRepetiçãoFatorialImpares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
          
            int resultado = 1;

            for (int numero = 1; numero < 10; numero ++)
            {
                resultado *= numero;
                
                if (numero % 2 == 0)
                {

                }
                else
                {
                    lboxLista.Items.Add(resultado);
                }
            }


            }
        
    }
}
