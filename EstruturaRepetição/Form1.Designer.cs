﻿
namespace estrutura_de_repeticao
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
            this.lbox = new System.Windows.Forms.ListBox();
            this.bt_while = new System.Windows.Forms.Button();
            this.bt_dowhile = new System.Windows.Forms.Button();
            this.bt_for = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listar os numeros de 01 a 50.";
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(191, 55);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(115, 368);
            this.lbox.TabIndex = 1;
            // 
            // bt_while
            // 
            this.bt_while.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_while.Location = new System.Drawing.Point(15, 75);
            this.bt_while.Name = "bt_while";
            this.bt_while.Size = new System.Drawing.Size(75, 62);
            this.bt_while.TabIndex = 2;
            this.bt_while.Text = "While";
            this.bt_while.UseVisualStyleBackColor = true;
            this.bt_while.Click += new System.EventHandler(this.bt_while_Click);
            // 
            // bt_dowhile
            // 
            this.bt_dowhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dowhile.Location = new System.Drawing.Point(15, 143);
            this.bt_dowhile.Name = "bt_dowhile";
            this.bt_dowhile.Size = new System.Drawing.Size(75, 62);
            this.bt_dowhile.TabIndex = 3;
            this.bt_dowhile.Text = "Do While";
            this.bt_dowhile.UseVisualStyleBackColor = true;
            this.bt_dowhile.Click += new System.EventHandler(this.bt_dowhile_Click);
            // 
            // bt_for
            // 
            this.bt_for.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_for.Location = new System.Drawing.Point(15, 211);
            this.bt_for.Name = "bt_for";
            this.bt_for.Size = new System.Drawing.Size(75, 62);
            this.bt_for.TabIndex = 4;
            this.bt_for.Text = "For";
            this.bt_for.UseVisualStyleBackColor = true;
            this.bt_for.Click += new System.EventHandler(this.bt_for_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "While Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "For par";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 62);
            this.button3.TabIndex = 7;
            this.button3.Text = "For Inverso";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "For 5 em 5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 62);
            this.button5.TabIndex = 9;
            this.button5.Text = "For 5 em 5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 447);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_for);
            this.Controls.Add(this.bt_dowhile);
            this.Controls.Add(this.bt_while);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Button bt_while;
        private System.Windows.Forms.Button bt_dowhile;
        private System.Windows.Forms.Button bt_for;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

