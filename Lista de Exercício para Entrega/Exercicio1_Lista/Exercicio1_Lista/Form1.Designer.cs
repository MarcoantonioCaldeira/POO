namespace Exercicio1_Lista
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_idade = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.group_nome_idade = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_mostrar_nome = new System.Windows.Forms.TextBox();
            this.text_mostrar_idade = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.group_nome_idade.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(101, 30);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(216, 20);
            this.text_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qual o seu nome?: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Idade: ";
            // 
            // text_idade
            // 
            this.text_idade.Location = new System.Drawing.Point(101, 69);
            this.text_idade.Name = "text_idade";
            this.text_idade.Size = new System.Drawing.Size(88, 20);
            this.text_idade.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_idade);
            this.groupBox1.Controls.Add(this.text_nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Empregado:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(158, 181);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(118, 34);
            this.btn_atualizar.TabIndex = 6;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // group_nome_idade
            // 
            this.group_nome_idade.Controls.Add(this.text_mostrar_idade);
            this.group_nome_idade.Controls.Add(this.text_mostrar_nome);
            this.group_nome_idade.Controls.Add(this.label1);
            this.group_nome_idade.Controls.Add(this.label4);
            this.group_nome_idade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.group_nome_idade.Location = new System.Drawing.Point(22, 236);
            this.group_nome_idade.Name = "group_nome_idade";
            this.group_nome_idade.Size = new System.Drawing.Size(440, 124);
            this.group_nome_idade.TabIndex = 6;
            this.group_nome_idade.TabStop = false;
            this.group_nome_idade.Text = "Dados do Empregado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade: ";
            // 
            // text_mostrar_nome
            // 
            this.text_mostrar_nome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.text_mostrar_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_mostrar_nome.Location = new System.Drawing.Point(50, 30);
            this.text_mostrar_nome.Name = "text_mostrar_nome";
            this.text_mostrar_nome.Size = new System.Drawing.Size(204, 13);
            this.text_mostrar_nome.TabIndex = 4;
            // 
            // text_mostrar_idade
            // 
            this.text_mostrar_idade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.text_mostrar_idade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_mostrar_idade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.text_mostrar_idade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.text_mostrar_idade.Location = new System.Drawing.Point(50, 69);
            this.text_mostrar_idade.Name = "text_mostrar_idade";
            this.text_mostrar_idade.Size = new System.Drawing.Size(92, 13);
            this.text_mostrar_idade.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 385);
            this.Controls.Add(this.group_nome_idade);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cadastro do Empregado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_nome_idade.ResumeLayout(false);
            this.group_nome_idade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_idade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.GroupBox group_nome_idade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_mostrar_idade;
        private System.Windows.Forms.TextBox text_mostrar_nome;
    }
}

