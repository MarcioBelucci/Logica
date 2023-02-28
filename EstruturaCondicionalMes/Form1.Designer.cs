
namespace EstruturaCondicionalMes
{
    partial class fmEstruturaCondicionalMes
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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbIF = new System.Windows.Forms.GroupBox();
            this.gbCase = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResultadocase = new System.Windows.Forms.Label();
            this.cbMescase = new System.Windows.Forms.ComboBox();
            this.gbIF.SuspendLayout();
            this.gbCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elaborar um sistema onde o usúario digita o número do mês e exibir o nome do mês " +
    "correspondente";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(203, 59);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 32);
            this.cbMes.TabIndex = 1;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(226, 117);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(50, 24);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "Mês";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número do Mês";
            // 
            // gbIF
            // 
            this.gbIF.Controls.Add(this.label2);
            this.gbIF.Controls.Add(this.lbResultado);
            this.gbIF.Controls.Add(this.cbMes);
            this.gbIF.Location = new System.Drawing.Point(56, 145);
            this.gbIF.Name = "gbIF";
            this.gbIF.Size = new System.Drawing.Size(383, 161);
            this.gbIF.TabIndex = 5;
            this.gbIF.TabStop = false;
            this.gbIF.Text = "IF";
            // 
            // gbCase
            // 
            this.gbCase.Controls.Add(this.label3);
            this.gbCase.Controls.Add(this.lbResultadocase);
            this.gbCase.Controls.Add(this.cbMescase);
            this.gbCase.Location = new System.Drawing.Point(56, 324);
            this.gbCase.Name = "gbCase";
            this.gbCase.Size = new System.Drawing.Size(383, 161);
            this.gbCase.TabIndex = 6;
            this.gbCase.TabStop = false;
            this.gbCase.Text = "CASE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número do Mês";
            // 
            // lbResultadocase
            // 
            this.lbResultadocase.AutoSize = true;
            this.lbResultadocase.Location = new System.Drawing.Point(226, 117);
            this.lbResultadocase.Name = "lbResultadocase";
            this.lbResultadocase.Size = new System.Drawing.Size(50, 24);
            this.lbResultadocase.TabIndex = 2;
            this.lbResultadocase.Text = "Mês";
            // 
            // cbMescase
            // 
            this.cbMescase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMescase.FormattingEnabled = true;
            this.cbMescase.Location = new System.Drawing.Point(203, 59);
            this.cbMescase.Name = "cbMescase";
            this.cbMescase.Size = new System.Drawing.Size(121, 32);
            this.cbMescase.TabIndex = 1;
            this.cbMescase.SelectedIndexChanged += new System.EventHandler(this.cbMescase_SelectedIndexChanged);
            // 
            // fmEstruturaCondicionalMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 518);
            this.Controls.Add(this.gbCase);
            this.Controls.Add(this.gbIF);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "fmEstruturaCondicionalMes";
            this.Text = "EstruturaCondicionalMês";
            this.Load += new System.EventHandler(this.fmEstruturaCondicionalMes_Load);
            this.gbIF.ResumeLayout(false);
            this.gbIF.PerformLayout();
            this.gbCase.ResumeLayout(false);
            this.gbCase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbIF;
        private System.Windows.Forms.GroupBox gbCase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResultadocase;
        private System.Windows.Forms.ComboBox cbMescase;
    }
}

