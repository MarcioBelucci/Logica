
namespace CondicionalMediaAlunoImpressao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMedia = new System.Windows.Forms.Label();
            this.gbAluno = new System.Windows.Forms.GroupBox();
            this.gbAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1057, 142);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(641, 171);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(150, 95);
            this.btCalcular.TabIndex = 1;
            this.btCalcular.Text = "Calcular Media e Impressão";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota5";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(129, 39);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 39);
            this.txtNota1.TabIndex = 6;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(129, 104);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 39);
            this.txtNota2.TabIndex = 7;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(129, 174);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 39);
            this.txtNota3.TabIndex = 8;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(129, 238);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 39);
            this.txtNota4.TabIndex = 9;
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(362, 174);
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(100, 39);
            this.txtExame.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Exame";
            // 
            // lbMedia
            // 
            this.lbMedia.AutoSize = true;
            this.lbMedia.Location = new System.Drawing.Point(558, 314);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.Size = new System.Drawing.Size(0, 32);
            this.lbMedia.TabIndex = 14;
            // 
            // gbAluno
            // 
            this.gbAluno.Controls.Add(this.txtNota3);
            this.gbAluno.Controls.Add(this.label2);
            this.gbAluno.Controls.Add(this.label7);
            this.gbAluno.Controls.Add(this.label3);
            this.gbAluno.Controls.Add(this.txtExame);
            this.gbAluno.Controls.Add(this.label4);
            this.gbAluno.Controls.Add(this.txtNota4);
            this.gbAluno.Controls.Add(this.label5);
            this.gbAluno.Controls.Add(this.txtNota1);
            this.gbAluno.Controls.Add(this.txtNota2);
            this.gbAluno.Location = new System.Drawing.Point(34, 155);
            this.gbAluno.Name = "gbAluno";
            this.gbAluno.Size = new System.Drawing.Size(481, 308);
            this.gbAluno.TabIndex = 15;
            this.gbAluno.TabStop = false;
            this.gbAluno.Text = "Aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 522);
            this.Controls.Add(this.gbAluno);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "CondicionalMediaAlunoImpressao";
            this.gbAluno.ResumeLayout(false);
            this.gbAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMedia;
        private System.Windows.Forms.GroupBox gbAluno;
    }
}

