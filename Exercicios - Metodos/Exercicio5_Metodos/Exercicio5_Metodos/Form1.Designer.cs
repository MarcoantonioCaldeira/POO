namespace Exercicio5_Metodos
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
            this.text_salario = new System.Windows.Forms.TextBox();
            this.btn_novosalario = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.text_novosalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aumento de salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(34, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do funcionario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(34, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do salario atual:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(176, 131);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(144, 20);
            this.text_nome.TabIndex = 3;
            // 
            // text_salario
            // 
            this.text_salario.Location = new System.Drawing.Point(180, 194);
            this.text_salario.Name = "text_salario";
            this.text_salario.Size = new System.Drawing.Size(140, 20);
            this.text_salario.TabIndex = 4;
            // 
            // btn_novosalario
            // 
            this.btn_novosalario.Location = new System.Drawing.Point(37, 391);
            this.btn_novosalario.Name = "btn_novosalario";
            this.btn_novosalario.Size = new System.Drawing.Size(98, 44);
            this.btn_novosalario.TabIndex = 5;
            this.btn_novosalario.Text = "Calcular novo Valor";
            this.btn_novosalario.UseVisualStyleBackColor = true;
            this.btn_novosalario.Click += new System.EventHandler(this.btn_novosalario_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(240, 391);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(80, 44);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // text_novosalario
            // 
            this.text_novosalario.Location = new System.Drawing.Point(180, 279);
            this.text_novosalario.Name = "text_novosalario";
            this.text_novosalario.Size = new System.Drawing.Size(140, 20);
            this.text_novosalario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(89, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Novo salario:";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(156, 391);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(80, 44);
            this.btn_imprimir.TabIndex = 9;
            this.btn_imprimir.Text = "Imprimir dados";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(359, 447);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_novosalario);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_novosalario);
            this.Controls.Add(this.text_salario);
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
        private System.Windows.Forms.TextBox text_salario;
        private System.Windows.Forms.Button btn_novosalario;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox text_novosalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_imprimir;
    }
}

