namespace Exercicio_Aula_012
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
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_codigo = new System.Windows.Forms.TextBox();
            this.text_quantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dep1 = new System.Windows.Forms.Button();
            this.btn_dep2 = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(112, 191);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(218, 20);
            this.text_nome.TabIndex = 0;
            // 
            // text_codigo
            // 
            this.text_codigo.Location = new System.Drawing.Point(112, 95);
            this.text_codigo.Name = "text_codigo";
            this.text_codigo.Size = new System.Drawing.Size(180, 20);
            this.text_codigo.TabIndex = 1;
            // 
            // text_quantidade
            // 
            this.text_quantidade.Location = new System.Drawing.Point(112, 144);
            this.text_quantidade.Name = "text_quantidade";
            this.text_quantidade.Size = new System.Drawing.Size(180, 20);
            this.text_quantidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quant emp:";
            // 
            // btn_dep1
            // 
            this.btn_dep1.Location = new System.Drawing.Point(59, 300);
            this.btn_dep1.Name = "btn_dep1";
            this.btn_dep1.Size = new System.Drawing.Size(117, 34);
            this.btn_dep1.TabIndex = 6;
            this.btn_dep1.Text = "Departamento 1";
            this.btn_dep1.UseVisualStyleBackColor = true;
            this.btn_dep1.Click += new System.EventHandler(this.btn_dep1_Click);
            // 
            // btn_dep2
            // 
            this.btn_dep2.Location = new System.Drawing.Point(199, 300);
            this.btn_dep2.Name = "btn_dep2";
            this.btn_dep2.Size = new System.Drawing.Size(117, 34);
            this.btn_dep2.TabIndex = 7;
            this.btn_dep2.Text = "Departamento 2";
            this.btn_dep2.UseVisualStyleBackColor = true;
            this.btn_dep2.Click += new System.EventHandler(this.btn_dep2_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(409, 300);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(117, 34);
            this.btn_imprimir.TabIndex = 8;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 360);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_dep2);
            this.Controls.Add(this.btn_dep1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_quantidade);
            this.Controls.Add(this.text_codigo);
            this.Controls.Add(this.text_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_codigo;
        private System.Windows.Forms.TextBox text_quantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dep1;
        private System.Windows.Forms.Button btn_dep2;
        private System.Windows.Forms.Button btn_imprimir;
    }
}

