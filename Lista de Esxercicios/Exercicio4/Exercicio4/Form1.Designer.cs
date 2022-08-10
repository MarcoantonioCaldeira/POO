namespace Exercicio4
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
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_num1 = new System.Windows.Forms.TextBox();
            this.text_num2 = new System.Windows.Forms.TextBox();
            this.text_num3 = new System.Windows.Forms.TextBox();
            this.text_num4 = new System.Windows.Forms.TextBox();
            this.btn_Media = new System.Windows.Forms.Button();
            this.text_re = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(71, 39);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(53, 13);
            this.num1.TabIndex = 0;
            this.num1.Text = "Numero1:";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(71, 72);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(53, 13);
            this.num2.TabIndex = 1;
            this.num2.Text = "Numero2:";
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.Location = new System.Drawing.Point(71, 105);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(53, 13);
            this.num3.TabIndex = 2;
            this.num3.Text = "Numero3:";
            // 
            // num4
            // 
            this.num4.AutoSize = true;
            this.num4.Location = new System.Drawing.Point(71, 140);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(53, 13);
            this.num4.TabIndex = 3;
            this.num4.Text = "Numero4:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // text_num1
            // 
            this.text_num1.Location = new System.Drawing.Point(130, 36);
            this.text_num1.Name = "text_num1";
            this.text_num1.Size = new System.Drawing.Size(165, 20);
            this.text_num1.TabIndex = 5;
            // 
            // text_num2
            // 
            this.text_num2.Location = new System.Drawing.Point(130, 69);
            this.text_num2.Name = "text_num2";
            this.text_num2.Size = new System.Drawing.Size(165, 20);
            this.text_num2.TabIndex = 6;
            // 
            // text_num3
            // 
            this.text_num3.Location = new System.Drawing.Point(130, 105);
            this.text_num3.Name = "text_num3";
            this.text_num3.Size = new System.Drawing.Size(165, 20);
            this.text_num3.TabIndex = 7;
            // 
            // text_num4
            // 
            this.text_num4.Location = new System.Drawing.Point(130, 137);
            this.text_num4.Name = "text_num4";
            this.text_num4.Size = new System.Drawing.Size(165, 20);
            this.text_num4.TabIndex = 8;
            // 
            // btn_Media
            // 
            this.btn_Media.Location = new System.Drawing.Point(74, 213);
            this.btn_Media.Name = "btn_Media";
            this.btn_Media.Size = new System.Drawing.Size(100, 32);
            this.btn_Media.TabIndex = 9;
            this.btn_Media.Text = "Media";
            this.btn_Media.UseVisualStyleBackColor = true;
            this.btn_Media.Click += new System.EventHandler(this.btn_Media_Click);
            // 
            // text_re
            // 
            this.text_re.Location = new System.Drawing.Point(189, 220);
            this.text_re.Name = "text_re";
            this.text_re.Size = new System.Drawing.Size(177, 20);
            this.text_re.TabIndex = 10;
            this.text_re.TextChanged += new System.EventHandler(this.text_re_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 321);
            this.Controls.Add(this.text_re);
            this.Controls.Add(this.btn_Media);
            this.Controls.Add(this.text_num4);
            this.Controls.Add(this.text_num3);
            this.Controls.Add(this.text_num2);
            this.Controls.Add(this.text_num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_num1;
        private System.Windows.Forms.TextBox text_num2;
        private System.Windows.Forms.TextBox text_num3;
        private System.Windows.Forms.TextBox text_num4;
        private System.Windows.Forms.Button btn_Media;
        private System.Windows.Forms.TextBox text_re;
    }
}

