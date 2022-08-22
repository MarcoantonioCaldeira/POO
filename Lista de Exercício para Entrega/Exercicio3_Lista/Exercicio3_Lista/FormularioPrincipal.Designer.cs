namespace Exercicio3_Lista
{
    partial class FormularioPrincipal
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
            this.combo_periodo = new System.Windows.Forms.ComboBox();
            this.combo_num_serie = new System.Windows.Forms.ComboBox();
            this.text_sigla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_visualisar = new System.Windows.Forms.Button();
            this.combo_ensino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Turmas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periodo:";
            // 
            // combo_periodo
            // 
            this.combo_periodo.FormattingEnabled = true;
            this.combo_periodo.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.combo_periodo.Location = new System.Drawing.Point(60, 112);
            this.combo_periodo.Name = "combo_periodo";
            this.combo_periodo.Size = new System.Drawing.Size(121, 21);
            this.combo_periodo.TabIndex = 2;
            // 
            // combo_num_serie
            // 
            this.combo_num_serie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.combo_num_serie.Cursor = System.Windows.Forms.Cursors.Default;
            this.combo_num_serie.FormattingEnabled = true;
            this.combo_num_serie.Items.AddRange(new object[] {
            "Primeiro ano ",
            "Segundo ano ",
            "Terceiro ano ",
            "Quarto ano",
            "Quinto ano"});
            this.combo_num_serie.Location = new System.Drawing.Point(61, 148);
            this.combo_num_serie.Name = "combo_num_serie";
            this.combo_num_serie.Size = new System.Drawing.Size(162, 21);
            this.combo_num_serie.TabIndex = 3;
            // 
            // text_sigla
            // 
            this.text_sigla.Location = new System.Drawing.Point(61, 183);
            this.text_sigla.Name = "text_sigla";
            this.text_sigla.Size = new System.Drawing.Size(162, 20);
            this.text_sigla.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sigla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serie:";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(21, 293);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(102, 38);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_visualisar
            // 
            this.btn_visualisar.Location = new System.Drawing.Point(129, 293);
            this.btn_visualisar.Name = "btn_visualisar";
            this.btn_visualisar.Size = new System.Drawing.Size(102, 38);
            this.btn_visualisar.TabIndex = 13;
            this.btn_visualisar.Text = "Visualizar";
            this.btn_visualisar.UseCompatibleTextRendering = true;
            this.btn_visualisar.UseVisualStyleBackColor = true;
            this.btn_visualisar.Click += new System.EventHandler(this.btn_visualisar_Click);
            // 
            // combo_ensino
            // 
            this.combo_ensino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.combo_ensino.Cursor = System.Windows.Forms.Cursors.Default;
            this.combo_ensino.FormattingEnabled = true;
            this.combo_ensino.Items.AddRange(new object[] {
            "Ensino Fundamental 1",
            "Ensino Fundamental 2",
            "Ensino Medio"});
            this.combo_ensino.Location = new System.Drawing.Point(104, 222);
            this.combo_ensino.Name = "combo_ensino";
            this.combo_ensino.Size = new System.Drawing.Size(162, 21);
            this.combo_ensino.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo de ensino:";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(380, 293);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(102, 38);
            this.btn_sair.TabIndex = 16;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseCompatibleTextRendering = true;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 361);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_ensino);
            this.Controls.Add(this.btn_visualisar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_sigla);
            this.Controls.Add(this.combo_num_serie);
            this.Controls.Add(this.combo_periodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_periodo;
        private System.Windows.Forms.ComboBox combo_num_serie;
        private System.Windows.Forms.TextBox text_sigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_visualisar;
        private System.Windows.Forms.ComboBox combo_ensino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sair;
    }
}

