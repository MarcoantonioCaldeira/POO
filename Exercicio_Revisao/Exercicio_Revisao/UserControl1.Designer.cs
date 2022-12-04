namespace Exercicio_Revisao
{
    partial class UserControl1
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

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_adicao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_num1 = new System.Windows.Forms.TextBox();
            this.text_num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_adicao
            // 
            this.btn_adicao.Location = new System.Drawing.Point(351, 44);
            this.btn_adicao.Name = "btn_adicao";
            this.btn_adicao.Size = new System.Drawing.Size(109, 36);
            this.btn_adicao.TabIndex = 0;
            this.btn_adicao.Text = "Adição";
            this.btn_adicao.UseVisualStyleBackColor = true;
            this.btn_adicao.Click += new System.EventHandler(this.btn_adicao_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Location = new System.Drawing.Point(351, 105);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(109, 36);
            this.btn_subtracao.TabIndex = 1;
            this.btn_subtracao.Text = "Subtração";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Location = new System.Drawing.Point(351, 168);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(109, 36);
            this.btn_multiplicacao.TabIndex = 2;
            this.btn_multiplicacao.Text = "Multiplicação";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(351, 227);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(109, 36);
            this.btn_divisao.TabIndex = 3;
            this.btn_divisao.Text = "Divisao";
            this.btn_divisao.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite um numero:";
            // 
            // text_num1
            // 
            this.text_num1.Location = new System.Drawing.Point(140, 116);
            this.text_num1.Name = "text_num1";
            this.text_num1.Size = new System.Drawing.Size(153, 20);
            this.text_num1.TabIndex = 5;
            // 
            // text_num2
            // 
            this.text_num2.Location = new System.Drawing.Point(150, 177);
            this.text_num2.Name = "text_num2";
            this.text_num2.Size = new System.Drawing.Size(153, 20);
            this.text_num2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digite outro numero:";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_num2);
            this.Controls.Add(this.text_num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_adicao);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(523, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adicao;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_num1;
        private System.Windows.Forms.TextBox text_num2;
        private System.Windows.Forms.Label label2;
    }
}
