namespace Exercicio_04
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
            this.text_nota1 = new System.Windows.Forms.TextBox();
            this.text_nota2 = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.group_menu = new System.Windows.Forms.GroupBox();
            this.group_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a primeira nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite a segunda nota:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(143, 76);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(172, 20);
            this.text_nome.TabIndex = 3;
            // 
            // text_nota1
            // 
            this.text_nota1.Location = new System.Drawing.Point(170, 147);
            this.text_nota1.Name = "text_nota1";
            this.text_nota1.Size = new System.Drawing.Size(145, 20);
            this.text_nota1.TabIndex = 4;
            // 
            // text_nota2
            // 
            this.text_nota2.Location = new System.Drawing.Point(170, 213);
            this.text_nota2.Name = "text_nota2";
            this.text_nota2.Size = new System.Drawing.Size(145, 20);
            this.text_nota2.TabIndex = 5;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(72, 35);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(122, 41);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular Media";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(207, 35);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(122, 42);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // group_menu
            // 
            this.group_menu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.group_menu.Controls.Add(this.btn_Calcular);
            this.group_menu.Controls.Add(this.btn_sair);
            this.group_menu.Location = new System.Drawing.Point(-14, 403);
            this.group_menu.Name = "group_menu";
            this.group_menu.Size = new System.Drawing.Size(419, 100);
            this.group_menu.TabIndex = 8;
            this.group_menu.TabStop = false;
            this.group_menu.Text = "Opções";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 502);
            this.Controls.Add(this.group_menu);
            this.Controls.Add(this.text_nota2);
            this.Controls.Add(this.text_nota1);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_nota1;
        private System.Windows.Forms.TextBox text_nota2;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.GroupBox group_menu;
    }
}

