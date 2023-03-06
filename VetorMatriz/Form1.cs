using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetorMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVetorINT_Click(object sender, EventArgs e)
        {
            //VETOR NUMÉRICO DE 5 POSIÇÕES

            //DECLARAÇÃO 1
            //CRIAR O VETOR
            int[] vetornum1;

            //INSTANCIAR O VETOR e DEFINIR TAMANHO
            vetornum1 = new int[05];

            //DECLARAR OS VALORES PRA CADA POSIÇÃO
            vetornum1[0] = 15;
            vetornum1[1] = 1;
            vetornum1[2] = 3;
            vetornum1[3] = 9;
            vetornum1[4] = 2;

            //ORDENAR OS VALORES DO VETOR
            Array.Sort(vetornum1);

            //DECLARAÇÃO 2
            //CRIAR O VETOR / INSTANCIA-LO / DECLARAR OS VALORES
            int[] vetornum2 = new int[5] { 15, 1, 3, 9, 2 };

            //DECLARAÇÃO 3
            int[] vetornum3 = { 15, 1, 3, 9, 2 };

            //SEM USAR LOOPING
            //lboxLista.Items.Add(vetornum1[0]);
            //lboxLista.Items.Add(vetornum1[1]);
            //lboxLista.Items.Add(vetornum1[2]);
            //lboxLista.Items.Add(vetornum1[3]);
            //lboxLista.Items.Add(vetornum1[4]);

            //COM LOOPING
            //for(int i = 0; i < vetornum1.Length; i++)
            //{
            //    lboxLista.Items.Add(vetornum1[i]);
            //}

            //int i = 0;
            //while ( i < vetornum1 .Length )
            //{
            //    lboxLista.Items.Add(vetornum1[i]);
            //    i++;
            //}
            //ORDENAR OS VALORES DO VETOR

            Array.Reverse(vetornum1);

            lboxLista.Items.Add("USANDO FOREACH");
            foreach (int i in vetornum1)
            {

                lboxLista.Items.Add(i);
            }

            int soma = 0;
            foreach (int numeros in vetornum1)
            {
                soma += numeros;
                txtSoma.Text = soma.ToString();

            }

        }

        private void btMatrizINT_Click(object sender, EventArgs e)
        {
            //CRIAR A MATRIZ 1
            int[,] matriznum1;
            //INSTANCIAR A MATRIZ
            matriznum1 = new int[2, 2];

            //DECLARAR OS VALORES NA MATRIZ
            matriznum1[0, 0] = 25;
            matriznum1[0, 1] = 13;
            matriznum1[1, 0] = 15;
            matriznum1[1, 1]= 17;

            int[,] matriznum2 = new int[2, 2] { { 25, 13 }, { 15, 17 } };

            //CRIAR MATRIZ 2
            int[,] matriznum3 = { { 25, 13 }, { 15, 27 } };

            
            for (int l = 0; l < 2; l++ )
            {
                for (int c = 0; c < 2; c++)
                {
                    lboxLista.Items.Add("Linha: " + l + " coluna: " + c + " = " + matriznum1[l, c]);
                }
            }
        }

        private void btVetorSTRING_Click(object sender, EventArgs e)
        {
            string[] vetorstring = new string[7] { "Domingo","Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado-Feira" };

            lboxLista.Items.Add("Dias da Semana");
            for (int i = 0; i < vetorstring .Length;i++)
            {
                lboxLista.Items.Add(vetorstring[i]);
            }
            
            lboxLista.Items.Add("Dias da Semana");
            foreach (string inicio in vetorstring)
            {
                lboxLista.Items.Add(inicio);
            }
        }

        private void btMatrizString_Click(object sender, EventArgs e)
        {
            string[,] matrizstring = new string[3, 3] { { "Vidas Secas", "Graciliano Ramos", " Livraria José Olympio Editora" }, { "Capitães da Areia", "Jorge Amado", "Jóse Olympio" }, { "O Cortiço", "Aluíso Azevedo", "B. L. Garnier" }  };

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int ed = 0, ed < 3; ed++)
                    {

                    }
                }
            }
        }
    }
}
