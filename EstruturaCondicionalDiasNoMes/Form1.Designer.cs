
namespace EstruturaCondicionalDiasNoMes
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
            this.btCalcularCase = new System.Windows.Forms.Button();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btIF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para demonstar um exemplo de switch/case, considere um programa que informa ao us" +
    "uario a quantidade de dias de um mês a partir do nome de um mês por ele informad" +
    "o";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escolha o mês:";
            // 
            // btCalcularCase
            // 
            this.btCalcularCase.Location = new System.Drawing.Point(84, 226);
            this.btCalcularCase.Name = "btCalcularCase";
            this.btCalcularCase.Size = new System.Drawing.Size(134, 89);
            this.btCalcularCase.TabIndex = 2;
            this.btCalcularCase.Text = "Calcular Case";
            this.btCalcularCase.UseVisualStyleBackColor = true;
            this.btCalcularCase.Click += new System.EventHandler(this.btCalcularCase_Click);
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(197, 157);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 32);
            this.cbMes.TabIndex = 3;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(95, 384);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 32);
            this.txtDias.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qtd de Dias";
            // 
            // btIF
            // 
            this.btIF.Location = new System.Drawing.Point(256, 226);
            this.btIF.Name = "btIF";
            this.btIF.Size = new System.Drawing.Size(134, 89);
            this.btIF.TabIndex = 6;
            this.btIF.Text = "Calcular IF";
            this.btIF.UseVisualStyleBackColor = true;
            this.btIF.Click += new System.EventHandler(this.btIF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 508);
            this.Controls.Add(this.btIF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.btCalcularCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "EstruturaCondicionalDiaNoMes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalcularCase;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btIF;
    }
}

