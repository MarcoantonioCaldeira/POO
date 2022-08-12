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
            this.rdb_1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turma1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turma2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_visualisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.text_sigla.Location = new System.Drawing.Point(62, 183);
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
            // rdb_1
            // 
            this.rdb_1.AutoSize = true;
            this.rdb_1.Location = new System.Drawing.Point(6, 22);
            this.rdb_1.Name = "rdb_1";
            this.rdb_1.Size = new System.Drawing.Size(130, 17);
            this.rdb_1.TabIndex = 7;
            this.rdb_1.TabStop = true;
            this.rdb_1.Text = "Ensino Fundamental 1";
            this.rdb_1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(6, 46);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(133, 17);
            this.rdb2.TabIndex = 8;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Ensino Fundamental 2 ";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(6, 70);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(89, 17);
            this.rdb3.TabIndex = 9;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "Ensino Medio";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_1);
            this.groupBox1.Controls.Add(this.rdb3);
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Location = new System.Drawing.Point(21, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ensino";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(272, 293);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(102, 38);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turmasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turma1ToolStripMenuItem,
            this.turma2ToolStripMenuItem});
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // turma1ToolStripMenuItem
            // 
            this.turma1ToolStripMenuItem.Name = "turma1ToolStripMenuItem";
            this.turma1ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.turma1ToolStripMenuItem.Text = "Turma 1";
            // 
            // turma2ToolStripMenuItem
            // 
            this.turma2ToolStripMenuItem.Name = "turma2ToolStripMenuItem";
            this.turma2ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.turma2ToolStripMenuItem.Text = "Turma  2";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // btn_visualisar
            // 
            this.btn_visualisar.Enabled = false;
            this.btn_visualisar.Location = new System.Drawing.Point(380, 293);
            this.btn_visualisar.Name = "btn_visualisar";
            this.btn_visualisar.Size = new System.Drawing.Size(102, 38);
            this.btn_visualisar.TabIndex = 13;
            this.btn_visualisar.Text = "Visualizar";
            this.btn_visualisar.UseCompatibleTextRendering = true;
            this.btn_visualisar.UseVisualStyleBackColor = true;
            this.btn_visualisar.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 361);
            this.Controls.Add(this.btn_visualisar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_sigla);
            this.Controls.Add(this.combo_num_serie);
            this.Controls.Add(this.combo_periodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdb_1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Button btn_visualisar;
        private System.Windows.Forms.ToolStripMenuItem turma1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turma2ToolStripMenuItem;
    }
}

