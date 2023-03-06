
namespace EstruturaRepeticaoSomatorioMedia
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
            this.btVerificar = new System.Windows.Forms.Button();
            this.txtSoma = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btVerificarImpar = new System.Windows.Forms.Button();
            this.btVerificarTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "2.\tElaborar um programa que apresente no final o somatório e a média dos valores " +
    "pares existentes na faixa de 1 até 500.";
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(36, 165);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(128, 54);
            this.btVerificar.TabIndex = 2;
            this.btVerificar.Text = "VerificarPar";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // txtSoma
            // 
            this.txtSoma.Location = new System.Drawing.Point(240, 178);
            this.txtSoma.Name = "txtSoma";
            this.txtSoma.Size = new System.Drawing.Size(100, 29);
            this.txtSoma.TabIndex = 3;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(358, 178);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 29);
            this.txtMedia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Média";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soma";
            // 
            // btVerificarImpar
            // 
            this.btVerificarImpar.Location = new System.Drawing.Point(36, 269);
            this.btVerificarImpar.Name = "btVerificarImpar";
            this.btVerificarImpar.Size = new System.Drawing.Size(137, 54);
            this.btVerificarImpar.TabIndex = 7;
            this.btVerificarImpar.Text = "VerificarImpar";
            this.btVerificarImpar.UseVisualStyleBackColor = true;
            this.btVerificarImpar.Click += new System.EventHandler(this.btVerificarImpar_Click);
            // 
            // btVerificarTotal
            // 
            this.btVerificarTotal.Location = new System.Drawing.Point(36, 377);
            this.btVerificarTotal.Name = "btVerificarTotal";
            this.btVerificarTotal.Size = new System.Drawing.Size(128, 54);
            this.btVerificarTotal.TabIndex = 8;
            this.btVerificarTotal.Text = "VerificarTotal";
            this.btVerificarTotal.UseVisualStyleBackColor = true;
            this.btVerificarTotal.Click += new System.EventHandler(this.btVerificarTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 562);
            this.Controls.Add(this.btVerificarTotal);
            this.Controls.Add(this.btVerificarImpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.txtSoma);
            this.Controls.Add(this.btVerificar);
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
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.TextBox txtSoma;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVerificarImpar;
        private System.Windows.Forms.Button btVerificarTotal;
    }
}

