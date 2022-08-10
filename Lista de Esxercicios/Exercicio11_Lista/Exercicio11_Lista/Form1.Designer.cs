namespace Exercicio11_Lista
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.digitar_num1 = new System.Windows.Forms.TextBox();
            this.digitar_num2 = new System.Windows.Forms.TextBox();
            this.digitar_num3 = new System.Windows.Forms.TextBox();
            this.re_num1 = new System.Windows.Forms.TextBox();
            this.re_num2 = new System.Windows.Forms.TextBox();
            this.re_num3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // digitar_num1
            // 
            this.digitar_num1.Location = new System.Drawing.Point(32, 22);
            this.digitar_num1.Name = "digitar_num1";
            this.digitar_num1.Size = new System.Drawing.Size(91, 20);
            this.digitar_num1.TabIndex = 1;
            // 
            // digitar_num2
            // 
            this.digitar_num2.Location = new System.Drawing.Point(32, 65);
            this.digitar_num2.Name = "digitar_num2";
            this.digitar_num2.Size = new System.Drawing.Size(91, 20);
            this.digitar_num2.TabIndex = 2;
            // 
            // digitar_num3
            // 
            this.digitar_num3.Location = new System.Drawing.Point(32, 105);
            this.digitar_num3.Name = "digitar_num3";
            this.digitar_num3.Size = new System.Drawing.Size(91, 20);
            this.digitar_num3.TabIndex = 3;
            // 
            // re_num1
            // 
            this.re_num1.Location = new System.Drawing.Point(337, 22);
            this.re_num1.Name = "re_num1";
            this.re_num1.Size = new System.Drawing.Size(91, 20);
            this.re_num1.TabIndex = 4;
            // 
            // re_num2
            // 
            this.re_num2.Location = new System.Drawing.Point(337, 65);
            this.re_num2.Name = "re_num2";
            this.re_num2.Size = new System.Drawing.Size(91, 20);
            this.re_num2.TabIndex = 5;
            // 
            // re_num3
            // 
            this.re_num3.Location = new System.Drawing.Point(337, 105);
            this.re_num3.Name = "re_num3";
            this.re_num3.Size = new System.Drawing.Size(91, 20);
            this.re_num3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "E";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(451, 147);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.re_num3);
            this.Controls.Add(this.re_num2);
            this.Controls.Add(this.re_num1);
            this.Controls.Add(this.digitar_num3);
            this.Controls.Add(this.digitar_num2);
            this.Controls.Add(this.digitar_num1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox digitar_num1;
        private System.Windows.Forms.TextBox digitar_num2;
        private System.Windows.Forms.TextBox digitar_num3;
        private System.Windows.Forms.TextBox re_num1;
        private System.Windows.Forms.TextBox re_num2;
        private System.Windows.Forms.TextBox re_num3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

