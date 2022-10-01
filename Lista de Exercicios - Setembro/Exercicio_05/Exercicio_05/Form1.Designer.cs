namespace Exercicio_05
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
            this.text_idade = new System.Windows.Forms.TextBox();
            this.text_anos = new System.Windows.Forms.TextBox();
            this.text_salario = new System.Windows.Forms.TextBox();
            this.btn_f1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade do Funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anos de serviço:";
            // 
            // text_idade
            // 
            this.text_idade.Location = new System.Drawing.Point(154, 77);
            this.text_idade.Name = "text_idade";
            this.text_idade.Size = new System.Drawing.Size(140, 20);
            this.text_idade.TabIndex = 3;
            // 
            // text_anos
            // 
            this.text_anos.Location = new System.Drawing.Point(130, 137);
            this.text_anos.Name = "text_anos";
            this.text_anos.Size = new System.Drawing.Size(164, 20);
            this.text_anos.TabIndex = 4;
            // 
            // text_salario
            // 
            this.text_salario.Location = new System.Drawing.Point(86, 195);
            this.text_salario.Name = "text_salario";
            this.text_salario.Size = new System.Drawing.Size(208, 20);
            this.text_salario.TabIndex = 5;
            // 
            // btn_f1
            // 
            this.btn_f1.Location = new System.Drawing.Point(12, 418);
            this.btn_f1.Name = "btn_f1";
            this.btn_f1.Size = new System.Drawing.Size(83, 37);
            this.btn_f1.TabIndex = 6;
            this.btn_f1.Text = "Funcionario 1";
            this.btn_f1.UseVisualStyleBackColor = true;
            this.btn_f1.Click += new System.EventHandler(this.btn_f1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(110, 418);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(83, 37);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "Funcionario 2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(219, 418);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 37);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 481);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_f1);
            this.Controls.Add(this.text_salario);
            this.Controls.Add(this.text_anos);
            this.Controls.Add(this.text_idade);
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
        private System.Windows.Forms.TextBox text_idade;
        private System.Windows.Forms.TextBox text_anos;
        private System.Windows.Forms.TextBox text_salario;
        private System.Windows.Forms.Button btn_f1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_sair;
    }
}

