namespace Exercicio1_Objetos
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
            this.btn_inserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_esvaziar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_preco = new System.Windows.Forms.TextBox();
            this.text_saldo = new System.Windows.Forms.TextBox();
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(380, 32);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(91, 40);
            this.btn_inserir.TabIndex = 0;
            this.btn_inserir.Text = "Inserir produto";
            this.btn_inserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Listar Produtos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(380, 124);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(91, 40);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir produto";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_esvaziar
            // 
            this.btn_esvaziar.Location = new System.Drawing.Point(380, 170);
            this.btn_esvaziar.Name = "btn_esvaziar";
            this.btn_esvaziar.Size = new System.Drawing.Size(91, 40);
            this.btn_esvaziar.TabIndex = 3;
            this.btn_esvaziar.Text = "Esvaziar Lista";
            this.btn_esvaziar.UseVisualStyleBackColor = true;
            this.btn_esvaziar.Click += new System.EventHandler(this.btn_esvaziar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(380, 216);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(91, 40);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saldo";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(97, 78);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(224, 20);
            this.text_nome.TabIndex = 8;
            // 
            // text_preco
            // 
            this.text_preco.Location = new System.Drawing.Point(97, 124);
            this.text_preco.Name = "text_preco";
            this.text_preco.Size = new System.Drawing.Size(224, 20);
            this.text_preco.TabIndex = 9;
            // 
            // text_saldo
            // 
            this.text_saldo.Location = new System.Drawing.Point(97, 167);
            this.text_saldo.Name = "text_saldo";
            this.text_saldo.Size = new System.Drawing.Size(224, 20);
            this.text_saldo.TabIndex = 10;
            // 
            // list_produtos
            // 
            this.list_produtos.FormattingEnabled = true;
            this.list_produtos.Location = new System.Drawing.Point(59, 216);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(262, 95);
            this.list_produtos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 337);
            this.Controls.Add(this.list_produtos);
            this.Controls.Add(this.text_saldo);
            this.Controls.Add(this.text_preco);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_esvaziar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_inserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_esvaziar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_preco;
        private System.Windows.Forms.TextBox text_saldo;
        private System.Windows.Forms.ListBox list_produtos;
    }
}

