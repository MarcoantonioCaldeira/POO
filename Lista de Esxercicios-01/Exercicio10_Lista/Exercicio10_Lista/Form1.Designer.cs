namespace Exercicio10_Lista
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
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(49, 62);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(163, 20);
            this.text_nome.TabIndex = 1;
            this.text_nome.TextChanged += new System.EventHandler(this.text_nome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dependentes:";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(126, 125);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(42, 17);
            this.rdb1.TabIndex = 3;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Sim";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(174, 125);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(45, 17);
            this.rdb2.TabIndex = 4;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Não";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(49, 247);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(93, 32);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo";
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.sexo.Location = new System.Drawing.Point(49, 191);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 7;
            this.sexo.SelectedIndexChanged += new System.EventHandler(this.sexo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 291);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sexo;
    }
}

