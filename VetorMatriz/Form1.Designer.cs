
namespace VetorMatriz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btVetorINT = new System.Windows.Forms.Button();
            this.btVetorSTRING = new System.Windows.Forms.Button();
            this.btMatrizINT = new System.Windows.Forms.Button();
            this.btMatrizString = new System.Windows.Forms.Button();
            this.lboxLista = new System.Windows.Forms.ListBox();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "VETOR INT: Criar um vetor numérico de 5 posições.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "VETOR STRING: Criar um vetor que exiba todos os dias da semana.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "MATRIZ STRING: Criar uma matriz de 9 posições (3 linhas e 3 colunas) que exiba no" +
    "me do livro, nome do autor, editora.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soma dos Valores do Vetor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(650, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "MATRIZ INT: Criar uma matriz numérica de 4 posições, 2 linhas e 2 colunas.\r\n";
            // 
            // btVetorINT
            // 
            this.btVetorINT.Location = new System.Drawing.Point(31, 170);
            this.btVetorINT.Name = "btVetorINT";
            this.btVetorINT.Size = new System.Drawing.Size(144, 80);
            this.btVetorINT.TabIndex = 5;
            this.btVetorINT.Text = "Vetor INT";
            this.btVetorINT.UseVisualStyleBackColor = true;
            this.btVetorINT.Click += new System.EventHandler(this.btVetorINT_Click);
            // 
            // btVetorSTRING
            // 
            this.btVetorSTRING.Location = new System.Drawing.Point(31, 264);
            this.btVetorSTRING.Name = "btVetorSTRING";
            this.btVetorSTRING.Size = new System.Drawing.Size(144, 80);
            this.btVetorSTRING.TabIndex = 6;
            this.btVetorSTRING.Text = "Vetor STRING";
            this.btVetorSTRING.UseVisualStyleBackColor = true;
            this.btVetorSTRING.Click += new System.EventHandler(this.btVetorSTRING_Click);
            // 
            // btMatrizINT
            // 
            this.btMatrizINT.Location = new System.Drawing.Point(31, 350);
            this.btMatrizINT.Name = "btMatrizINT";
            this.btMatrizINT.Size = new System.Drawing.Size(144, 80);
            this.btMatrizINT.TabIndex = 7;
            this.btMatrizINT.Text = "Matriz INT";
            this.btMatrizINT.UseVisualStyleBackColor = true;
            this.btMatrizINT.Click += new System.EventHandler(this.btMatrizINT_Click);
            // 
            // btMatrizString
            // 
            this.btMatrizString.Location = new System.Drawing.Point(31, 446);
            this.btMatrizString.Name = "btMatrizString";
            this.btMatrizString.Size = new System.Drawing.Size(144, 80);
            this.btMatrizString.TabIndex = 8;
            this.btMatrizString.Text = "MatrizSTRING";
            this.btMatrizString.UseVisualStyleBackColor = true;
            this.btMatrizString.Click += new System.EventHandler(this.btMatrizString_Click);
            // 
            // lboxLista
            // 
            this.lboxLista.FormattingEnabled = true;
            this.lboxLista.ItemHeight = 22;
            this.lboxLista.Location = new System.Drawing.Point(243, 170);
            this.lboxLista.Name = "lboxLista";
            this.lboxLista.Size = new System.Drawing.Size(361, 356);
            this.lboxLista.TabIndex = 9;
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(286, 540);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(100, 29);
            this.txtSoma.TabIndex = 10;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(462, 532);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(142, 37);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Limpar Lista";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 599);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.lboxLista);
            this.Controls.Add(this.btMatrizString);
            this.Controls.Add(this.btMatrizINT);
            this.Controls.Add(this.btVetorSTRING);
            this.Controls.Add(this.btVetorINT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btVetorINT;
        private System.Windows.Forms.Button btVetorSTRING;
        private System.Windows.Forms.Button btMatrizINT;
        private System.Windows.Forms.Button btMatrizString;
        private System.Windows.Forms.ListBox lboxLista;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.Button btLimpar;
    }
}

