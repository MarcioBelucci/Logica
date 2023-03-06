using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estrutura_de_repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_while_Click(object sender, EventArgs e)
        {
            //LISTAR TODOS OS NUMEROS DE 01 A 50 - WHILE
            int numbr = 1;
         
            lbox.Items.Clear();
            lbox.Items.Add("Laço While");
            while (numbr <= 50)
            {
                lbox.Items.Add(numbr);
                numbr++;

            }

        }

        private void bt_for_Click(object sender, EventArgs e)
        {
            //LISTAR TODOS O NUMEROS DE 01 A 50 - FOR

            lbox.Items.Clear();
            lbox.Items.Add("Laço For");
            for (int numbr= 1; numbr <= 50; numbr++)
            {
                           
                lbox.Items.Add(numbr);
                
            }

        }

        private void bt_dowhile_Click(object sender, EventArgs e)
        {
            //LISTAR TODOS O NUMEROS DE 01 A 50 - DO WHILE


            lbox.Items.Clear();
            lbox.Items.Add("Laço Do WHile");
            int numbr = 1;

            do
            {
                lbox.Items.Add(numbr);
                numbr++;

            } while (numbr <= 50);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while(i < 10)
            {

                i++;
                if(i%2 == 0)
                {
                    continue;
                }
                lbox.Items.Add(i);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LISTAR OS NUMEROS PARES DE 01 A 50 - FOR


            //for(int numbr = 0; numbr <= 50; numbr += 2)
            //{


            //    lbox.Items.Add(numbr);


            //}

            for (int numbr = 1; numbr <= 50; numbr++)
            {
                if (numbr % 2 == 0)
                   
                lbox.Items.Add(numbr);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //LISTAR OS NUMEROS PARES DE 50 A 01 - FOR


            for (int num = 50; num >= 0; num--)
            {

                if (num % 2 == 0)
                    lbox.Items.Add(num);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //LISTAR OS NUMEROS PARES DE 0 A 50 de 5 em 5 - FOR

            for (int num = 0; num <= 50; num +=5)
            {          
                    lbox.Items.Add(num);

            }
        }
    }
}
