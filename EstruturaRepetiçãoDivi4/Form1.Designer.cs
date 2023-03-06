
namespace EstruturaRepetiçaoDivi4
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
            this.lboxNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "8.\tApresentar todos os números divisíveis por 4 que sejam menores que 200.";
            // 
            // btVerificar
            // 
            this.btVerificar.Location = new System.Drawing.Point(39, 105);
            this.btVerificar.Name = "btVerificar";
            this.btVerificar.Size = new System.Drawing.Size(130, 129);
            this.btVerificar.TabIndex = 1;
            this.btVerificar.Text = "Verificar";
            this.btVerificar.UseVisualStyleBackColor = true;
            this.btVerificar.Click += new System.EventHandler(this.btVerificar_Click);
            // 
            // lboxNumeros
            // 
            this.lboxNumeros.FormattingEnabled = true;
            this.lboxNumeros.ItemHeight = 26;
            this.lboxNumeros.Location = new System.Drawing.Point(240, 105);
            this.lboxNumeros.Name = "lboxNumeros";
            this.lboxNumeros.Size = new System.Drawing.Size(161, 186);
            this.lboxNumeros.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 462);
            this.Controls.Add(this.lboxNumeros);
            this.Controls.Add(this.btVerificar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVerificar;
        private System.Windows.Forms.ListBox lboxNumeros;
    }
}

