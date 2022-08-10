namespace Exercicio9_Lista
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
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_nota = new System.Windows.Forms.TextBox();
            this.btn_conceito = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome do aluno:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(26, 74);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(190, 20);
            this.text_nome.TabIndex = 1;
            this.text_nome.TextChanged += new System.EventHandler(this.text_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a nota do aluno:";
            // 
            // text_nota
            // 
            this.text_nota.Location = new System.Drawing.Point(26, 150);
            this.text_nota.Name = "text_nota";
            this.text_nota.Size = new System.Drawing.Size(126, 20);
            this.text_nota.TabIndex = 3;
            // 
            // btn_conceito
            // 
            this.btn_conceito.Location = new System.Drawing.Point(26, 201);
            this.btn_conceito.Name = "btn_conceito";
            this.btn_conceito.Size = new System.Drawing.Size(103, 41);
            this.btn_conceito.TabIndex = 4;
            this.btn_conceito.Text = "Calcular conceito";
            this.btn_conceito.UseVisualStyleBackColor = true;
            this.btn_conceito.Click += new System.EventHandler(this.btn_conceito_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_conceito);
            this.Controls.Add(this.text_nota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nota;
        private System.Windows.Forms.Button btn_conceito;
        private System.Windows.Forms.Button button1;
    }
}

