
namespace Tabuada
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
            this.txtTabuada = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lboxTabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTabuada
            // 
            this.txtTabuada.Location = new System.Drawing.Point(60, 25);
            this.txtTabuada.Name = "txtTabuada";
            this.txtTabuada.Size = new System.Drawing.Size(100, 20);
            this.txtTabuada.TabIndex = 0;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(76, 106);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(84, 74);
            this.btCalcular.TabIndex = 1;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lboxTabuada
            // 
            this.lboxTabuada.FormattingEnabled = true;
            this.lboxTabuada.Location = new System.Drawing.Point(216, 25);
            this.lboxTabuada.Name = "lboxTabuada";
            this.lboxTabuada.Size = new System.Drawing.Size(233, 225);
            this.lboxTabuada.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 375);
            this.Controls.Add(this.lboxTabuada);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtTabuada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTabuada;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.ListBox lboxTabuada;
    }
}

