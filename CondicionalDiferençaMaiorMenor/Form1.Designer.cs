
namespace CondicionalDiferençaMaiorMenor
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btCalcularCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ler dois valores numéricos inteiros e apresentar o resultado da diferença do maio" +
    "r pelo menor valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor2";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(51, 164);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 39);
            this.txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(197, 164);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 39);
            this.txtValor2.TabIndex = 4;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(95, 235);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(155, 83);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "CalcularIF";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(295, 313);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(140, 32);
            this.lbResultado.TabIndex = 6;
            this.lbResultado.Text = "Resultado";
            // 
            // btCalcularCase
            // 
            this.btCalcularCase.Location = new System.Drawing.Point(95, 324);
            this.btCalcularCase.Name = "btCalcularCase";
            this.btCalcularCase.Size = new System.Drawing.Size(138, 92);
            this.btCalcularCase.TabIndex = 7;
            this.btCalcularCase.Text = "CalcularCase";
            this.btCalcularCase.UseVisualStyleBackColor = true;
            this.btCalcularCase.Click += new System.EventHandler(this.btCalcularCase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 440);
            this.Controls.Add(this.btCalcularCase);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "CondicionalDiferençaMaioMenor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btCalcularCase;
    }
}

