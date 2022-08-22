namespace Exercicio5_Lista
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
            this.text_quantidade = new System.Windows.Forms.TextBox();
            this.text_preco = new System.Windows.Forms.TextBox();
            this.rdb_produto1 = new System.Windows.Forms.RadioButton();
            this.rdb_produto2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.text_total = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(69, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qtde: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Unitário: ";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(118, 52);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(163, 20);
            this.text_nome.TabIndex = 3;
            // 
            // text_quantidade
            // 
            this.text_quantidade.Location = new System.Drawing.Point(118, 103);
            this.text_quantidade.Name = "text_quantidade";
            this.text_quantidade.Size = new System.Drawing.Size(163, 20);
            this.text_quantidade.TabIndex = 4;
            // 
            // text_preco
            // 
            this.text_preco.Location = new System.Drawing.Point(118, 168);
            this.text_preco.Name = "text_preco";
            this.text_preco.Size = new System.Drawing.Size(163, 20);
            this.text_preco.TabIndex = 5;
            // 
            // rdb_produto1
            // 
            this.rdb_produto1.AutoSize = true;
            this.rdb_produto1.Location = new System.Drawing.Point(18, 53);
            this.rdb_produto1.Name = "rdb_produto1";
            this.rdb_produto1.Size = new System.Drawing.Size(74, 17);
            this.rdb_produto1.TabIndex = 6;
            this.rdb_produto1.TabStop = true;
            this.rdb_produto1.Text = "Produto 1 ";
            this.rdb_produto1.UseVisualStyleBackColor = true;
            // 
            // rdb_produto2
            // 
            this.rdb_produto2.AutoSize = true;
            this.rdb_produto2.Location = new System.Drawing.Point(109, 53);
            this.rdb_produto2.Name = "rdb_produto2";
            this.rdb_produto2.Size = new System.Drawing.Size(71, 17);
            this.rdb_produto2.TabIndex = 7;
            this.rdb_produto2.TabStop = true;
            this.rdb_produto2.Text = "Produto 2";
            this.rdb_produto2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.rdb_produto1);
            this.groupBox1.Controls.Add(this.rdb_produto2);
            this.groupBox1.Location = new System.Drawing.Point(48, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(105, 100);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 9;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(17, 100);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(48, 386);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(75, 23);
            this.btn_total.TabIndex = 10;
            this.btn_total.Text = "Total";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // text_total
            // 
            this.text_total.Location = new System.Drawing.Point(129, 387);
            this.text_total.Name = "text_total";
            this.text_total.Size = new System.Drawing.Size(127, 20);
            this.text_total.TabIndex = 11;
            this.text_total.TextChanged += new System.EventHandler(this.text_total_TextChanged);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(206, 433);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 10;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 468);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.text_total);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.text_preco);
            this.Controls.Add(this.text_quantidade);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_quantidade;
        private System.Windows.Forms.TextBox text_preco;
        private System.Windows.Forms.RadioButton rdb_produto1;
        private System.Windows.Forms.RadioButton rdb_produto2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.Button btn_sair;
    }
}

