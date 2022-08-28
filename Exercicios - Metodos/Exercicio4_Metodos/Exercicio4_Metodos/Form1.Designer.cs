namespace Exercicio4_Metodos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_num1 = new System.Windows.Forms.TextBox();
            this.text_num2 = new System.Windows.Forms.TextBox();
            this.text_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_adicao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.group_operacoes = new System.Windows.Forms.GroupBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.group_operacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o primeiro numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o segundo numero:";
            // 
            // text_num1
            // 
            this.text_num1.Location = new System.Drawing.Point(175, 74);
            this.text_num1.Name = "text_num1";
            this.text_num1.Size = new System.Drawing.Size(166, 20);
            this.text_num1.TabIndex = 2;
            // 
            // text_num2
            // 
            this.text_num2.Location = new System.Drawing.Point(175, 151);
            this.text_num2.Name = "text_num2";
            this.text_num2.Size = new System.Drawing.Size(166, 20);
            this.text_num2.TabIndex = 3;
            // 
            // text_resultado
            // 
            this.text_resultado.Location = new System.Drawing.Point(175, 276);
            this.text_resultado.Name = "text_resultado";
            this.text_resultado.Size = new System.Drawing.Size(166, 20);
            this.text_resultado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // btn_adicao
            // 
            this.btn_adicao.Location = new System.Drawing.Point(6, 19);
            this.btn_adicao.Name = "btn_adicao";
            this.btn_adicao.Size = new System.Drawing.Size(75, 39);
            this.btn_adicao.TabIndex = 6;
            this.btn_adicao.Text = "Adição";
            this.btn_adicao.UseVisualStyleBackColor = true;
            this.btn_adicao.Click += new System.EventHandler(this.btn_adicao_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Location = new System.Drawing.Point(87, 19);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(75, 39);
            this.btn_subtracao.TabIndex = 7;
            this.btn_subtracao.Text = "Subtração";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Location = new System.Drawing.Point(168, 19);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(82, 39);
            this.btn_multiplicacao.TabIndex = 8;
            this.btn_multiplicacao.Text = "Multiplicação";
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(256, 19);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(92, 39);
            this.btn_divisao.TabIndex = 9;
            this.btn_divisao.Text = "Divisão";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // group_operacoes
            // 
            this.group_operacoes.Controls.Add(this.btn_adicao);
            this.group_operacoes.Controls.Add(this.btn_divisao);
            this.group_operacoes.Controls.Add(this.btn_subtracao);
            this.group_operacoes.Controls.Add(this.btn_multiplicacao);
            this.group_operacoes.Location = new System.Drawing.Point(12, 332);
            this.group_operacoes.Name = "group_operacoes";
            this.group_operacoes.Size = new System.Drawing.Size(387, 71);
            this.group_operacoes.TabIndex = 10;
            this.group_operacoes.TabStop = false;
            this.group_operacoes.Text = "Operações";
            this.group_operacoes.Enter += new System.EventHandler(this.group_operacoes_Enter);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(285, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 28);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 415);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.group_operacoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_resultado);
            this.Controls.Add(this.text_num2);
            this.Controls.Add(this.text_num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.group_operacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_num1;
        private System.Windows.Forms.TextBox text_num2;
        private System.Windows.Forms.TextBox text_resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_adicao;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.GroupBox group_operacoes;
        private System.Windows.Forms.Button btn_fechar;
    }
}

