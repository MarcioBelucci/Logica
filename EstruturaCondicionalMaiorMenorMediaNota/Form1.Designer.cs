
namespace EstruturaCondicionalMaiorMenorMediaNota
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
            this.txtNota01 = new System.Windows.Forms.TextBox();
            this.txtNota02 = new System.Windows.Forms.TextBox();
            this.txtNota03 = new System.Windows.Forms.TextBox();
            this.txtNota04 = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtMaiorNota = new System.Windows.Forms.TextBox();
            this.txtMenorNota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elaborar um sistema onde o usuário digita 04 notas e exibir: Maior Nota, Menor No" +
    "ta e Média.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label2.Location = new System.Drawing.Point(80, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 03";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 04";
            // 
            // txtNota01
            // 
            this.txtNota01.Location = new System.Drawing.Point(75, 205);
            this.txtNota01.MaxLength = 2;
            this.txtNota01.Name = "txtNota01";
            this.txtNota01.Size = new System.Drawing.Size(100, 39);
            this.txtNota01.TabIndex = 5;
            // 
            // txtNota02
            // 
            this.txtNota02.Location = new System.Drawing.Point(224, 205);
            this.txtNota02.MaxLength = 2;
            this.txtNota02.Name = "txtNota02";
            this.txtNota02.Size = new System.Drawing.Size(100, 39);
            this.txtNota02.TabIndex = 6;
            // 
            // txtNota03
            // 
            this.txtNota03.Location = new System.Drawing.Point(363, 205);
            this.txtNota03.MaxLength = 2;
            this.txtNota03.Name = "txtNota03";
            this.txtNota03.Size = new System.Drawing.Size(100, 39);
            this.txtNota03.TabIndex = 7;
            // 
            // txtNota04
            // 
            this.txtNota04.Location = new System.Drawing.Point(500, 205);
            this.txtNota04.MaxLength = 2;
            this.txtNota04.Name = "txtNota04";
            this.txtNota04.Size = new System.Drawing.Size(100, 39);
            this.txtNota04.TabIndex = 8;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(69, 294);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(160, 92);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Média:";
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(377, 317);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 39);
            this.txtMedia.TabIndex = 11;
            // 
            // txtMaiorNota
            // 
            this.txtMaiorNota.Enabled = false;
            this.txtMaiorNota.Location = new System.Drawing.Point(129, 460);
            this.txtMaiorNota.Name = "txtMaiorNota";
            this.txtMaiorNota.Size = new System.Drawing.Size(100, 39);
            this.txtMaiorNota.TabIndex = 12;
            // 
            // txtMenorNota
            // 
            this.txtMenorNota.Enabled = false;
            this.txtMenorNota.Location = new System.Drawing.Point(296, 460);
            this.txtMenorNota.Name = "txtMenorNota";
            this.txtMenorNota.Size = new System.Drawing.Size(104, 39);
            this.txtMenorNota.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maior Nota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Menor Nota";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 635);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMenorNota);
            this.Controls.Add(this.txtMaiorNota);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtNota04);
            this.Controls.Add(this.txtNota03);
            this.Controls.Add(this.txtNota02);
            this.Controls.Add(this.txtNota01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Estrutura Condicional Maior/Menor nota e Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota01;
        private System.Windows.Forms.TextBox txtNota02;
        private System.Windows.Forms.TextBox txtNota03;
        private System.Windows.Forms.TextBox txtNota04;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtMaiorNota;
        private System.Windows.Forms.TextBox txtMenorNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

