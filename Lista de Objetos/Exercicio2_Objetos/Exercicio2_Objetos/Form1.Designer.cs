namespace Exercicio2_Objetos
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
            this.label3 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_preco = new System.Windows.Forms.TextBox();
            this.text_quant = new System.Windows.Forms.TextBox();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_venda = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.list_produtos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_quant_compra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de estoque:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(77, 64);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(236, 20);
            this.text_nome.TabIndex = 3;
            // 
            // text_preco
            // 
            this.text_preco.Location = new System.Drawing.Point(77, 132);
            this.text_preco.Name = "text_preco";
            this.text_preco.Size = new System.Drawing.Size(236, 20);
            this.text_preco.TabIndex = 4;
            // 
            // text_quant
            // 
            this.text_quant.Location = new System.Drawing.Point(163, 206);
            this.text_quant.Name = "text_quant";
            this.text_quant.Size = new System.Drawing.Size(150, 20);
            this.text_quant.TabIndex = 5;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(373, 12);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(118, 39);
            this.btn_cadastro.TabIndex = 6;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // btn_venda
            // 
            this.btn_venda.Location = new System.Drawing.Point(373, 122);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(118, 39);
            this.btn_venda.TabIndex = 8;
            this.btn_venda.Text = "Efetuar Venda";
            this.btn_venda.UseVisualStyleBackColor = true;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(373, 64);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(118, 39);
            this.btn_listar.TabIndex = 9;
            this.btn_listar.Text = "Listar Todos os refrigerantes";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(373, 176);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(118, 39);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir Refrigerante";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(373, 221);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(118, 39);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button6_Click);
            // 
            // list_produtos
            // 
            this.list_produtos.FormattingEnabled = true;
            this.list_produtos.Location = new System.Drawing.Point(39, 250);
            this.list_produtos.Name = "list_produtos";
            this.list_produtos.Size = new System.Drawing.Size(274, 95);
            this.list_produtos.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Selecione o Refrigerante e realize a sua compra:";
            // 
            // text_quant_compra
            // 
            this.text_quant_compra.Location = new System.Drawing.Point(275, 388);
            this.text_quant_compra.Name = "text_quant_compra";
            this.text_quant_compra.Size = new System.Drawing.Size(216, 20);
            this.text_quant_compra.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 477);
            this.Controls.Add(this.text_quant_compra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.list_produtos);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_venda);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.text_quant);
            this.Controls.Add(this.text_preco);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_preco;
        private System.Windows.Forms.TextBox text_quant;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ListBox list_produtos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_quant_compra;
    }
}

