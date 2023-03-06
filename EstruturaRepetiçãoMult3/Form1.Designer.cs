
namespace EstruturaRepetiçãoMult3
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
            this.lboxLista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "5.\tFaça um programa em C# que imprima todos os múltiplos de 3, entre 1 e 100.";
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(30, 84);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(108, 97);
            this.btVerificar.TabIndex = 1;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // lboxLista
            // 
            this.lboxLista.FormattingEnabled = true;
            this.lboxLista.ItemHeight = 27;
            this.lboxLista.Location = new System.Drawing.Point(224, 89);
            this.lboxLista.Name = "lboxLista";
            this.lboxLista.Size = new System.Drawing.Size(230, 220);
            this.lboxLista.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 423);
            this.Controls.Add(this.lboxLista);
            this.Controls.Add(this.btVerificar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.ListBox lboxLista;
    }
}

