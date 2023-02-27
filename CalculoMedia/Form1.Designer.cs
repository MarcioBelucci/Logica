
namespace CalculoMedia
{
    partial class formCalculoMedia
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
            this.lbResultado = new System.Windows.Forms.Label();
            this.txtIdade01 = new System.Windows.Forms.TextBox();
            this.txtIdade02 = new System.Windows.Forms.TextBox();
            this.txtIdade03 = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar um sistema que calule a média de idade de 3 alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade 01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade 02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade 03";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.Red;
            this.lbResultado.Location = new System.Drawing.Point(311, 306);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(114, 29);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "Resultado";
          
            // 
            // txtIdade01
            // 
            this.txtIdade01.Location = new System.Drawing.Point(127, 149);
            this.txtIdade01.MaxLength = 2;
            this.txtIdade01.Name = "txtIdade01";
            this.txtIdade01.Size = new System.Drawing.Size(100, 26);
            this.txtIdade01.TabIndex = 5;
            // 
            // txtIdade02
            // 
            this.txtIdade02.Location = new System.Drawing.Point(127, 189);
            this.txtIdade02.MaxLength = 2;
            this.txtIdade02.Name = "txtIdade02";
            this.txtIdade02.Size = new System.Drawing.Size(100, 26);
            this.txtIdade02.TabIndex = 6;
            // 
            // txtIdade03
            // 
            this.txtIdade03.Location = new System.Drawing.Point(127, 227);
            this.txtIdade03.MaxLength = 2;
            this.txtIdade03.Name = "txtIdade03";
            this.txtIdade03.Size = new System.Drawing.Size(100, 26);
            this.txtIdade03.TabIndex = 7;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(127, 290);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 64);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "Cálcular Média";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // formCalculoMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 437);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtIdade03);
            this.Controls.Add(this.txtIdade02);
            this.Controls.Add(this.txtIdade01);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formCalculoMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo da Média das Idades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox txtIdade01;
        private System.Windows.Forms.TextBox txtIdade02;
        private System.Windows.Forms.TextBox txtIdade03;
        private System.Windows.Forms.Button btCalcular;
    }
}

