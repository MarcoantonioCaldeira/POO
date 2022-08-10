namespace Exercicio6_lista
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
            this.btn_resultado = new System.Windows.Forms.Button();
            this.text_resultado = new System.Windows.Forms.TextBox();
            this.text_num = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(70, 180);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(123, 49);
            this.btn_resultado.TabIndex = 0;
            this.btn_resultado.Text = "Fatorial";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // text_resultado
            // 
            this.text_resultado.Location = new System.Drawing.Point(208, 195);
            this.text_resultado.Name = "text_resultado";
            this.text_resultado.Size = new System.Drawing.Size(180, 20);
            this.text_resultado.TabIndex = 1;
            // 
            // text_num
            // 
            this.text_num.Location = new System.Drawing.Point(168, 108);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(180, 20);
            this.text_num.TabIndex = 2;
            this.text_num.TextChanged += new System.EventHandler(this.text_num_TextChanged);
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(67, 111);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(95, 13);
            this.label_num.TabIndex = 3;
            this.label_num.Text = "Digite um numero: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 339);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.text_resultado);
            this.Controls.Add(this.btn_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.TextBox text_resultado;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.Label label_num;
    }
}

