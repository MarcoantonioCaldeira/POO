namespace Exemplo_Aula06
{
    partial class Frm_Cadastro_Pessoas
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
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(94, 80);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(236, 20);
            this.text_nome.TabIndex = 2;
            // 
            // text_idade
            // 
            this.text_idade.Location = new System.Drawing.Point(93, 157);
            this.text_idade.Name = "text_idade";
            this.text_idade.Size = new System.Drawing.Size(236, 20);
            this.text_idade.TabIndex = 3;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(53, 261);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(114, 40);
            this.btn_Salvar.TabIndex = 4;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Enabled = false;
            this.btn_Imprimir.Location = new System.Drawing.Point(229, 261);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(114, 40);
            this.btn_Imprimir.TabIndex = 5;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // Frm_Cadastro_Pessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 383);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.text_idade);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Cadastro_Pessoas";
            this.Text = "Cadastro de pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_idade;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Imprimir;
    }
}

