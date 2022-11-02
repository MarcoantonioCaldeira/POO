namespace Exercicio1_Vetores
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
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_idade = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(97, 91);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(225, 20);
            this.text_nome.TabIndex = 2;
            // 
            // text_idade
            // 
            this.text_idade.Location = new System.Drawing.Point(97, 157);
            this.text_idade.Name = "text_idade";
            this.text_idade.Size = new System.Drawing.Size(225, 20);
            this.text_idade.TabIndex = 3;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(65, 275);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(100, 41);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(216, 275);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(100, 41);
            this.btn_gravar.TabIndex = 5;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(322, 275);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(100, 41);
            this.btn_listar.TabIndex = 6;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 358);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.text_idade);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_idade;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_listar;
    }
}

