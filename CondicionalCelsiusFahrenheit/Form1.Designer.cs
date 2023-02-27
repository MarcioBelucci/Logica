
namespace CondicionalCelsiusFahrenheit
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btConverter = new System.Windows.Forms.Button();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(889, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "7.\tLer uma temperatura em graus Celsius e apresentá-la convertida em graus Fahren" +
    "heit. A fórmula de conversão é F = (9 * C + 160) / 5, sendo F a temperatura em F" +
    "ahrenheit e C a temperatura em Celsius.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura em ºC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperatura em ºF";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(96, 177);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 34);
            this.txtCelsius.TabIndex = 3;
            // 
            // btConverter
            // 
            this.btConverter.Location = new System.Drawing.Point(294, 153);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(136, 81);
            this.btConverter.TabIndex = 4;
            this.btConverter.Text = "Converter";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Enabled = false;
            this.txtFahrenheit.Location = new System.Drawing.Point(523, 177);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 34);
            this.txtFahrenheit.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.TextBox txtFahrenheit;
    }
}

