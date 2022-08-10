namespace Exercicio2_Lista
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
            this.checkDormir = new System.Windows.Forms.CheckBox();
            this.checkComer = new System.Windows.Forms.CheckBox();
            this.checkCinema = new System.Windows.Forms.CheckBox();
            this.checkLivro = new System.Windows.Forms.CheckBox();
            this.checkEstudar = new System.Windows.Forms.CheckBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "O que eu gosto de fazer:";
            // 
            // checkDormir
            // 
            this.checkDormir.AutoSize = true;
            this.checkDormir.Location = new System.Drawing.Point(45, 75);
            this.checkDormir.Name = "checkDormir";
            this.checkDormir.Size = new System.Drawing.Size(56, 17);
            this.checkDormir.TabIndex = 1;
            this.checkDormir.Text = "Dormir";
            this.checkDormir.UseVisualStyleBackColor = true;
            // 
            // checkComer
            // 
            this.checkComer.AutoSize = true;
            this.checkComer.Location = new System.Drawing.Point(45, 98);
            this.checkComer.Name = "checkComer";
            this.checkComer.Size = new System.Drawing.Size(56, 17);
            this.checkComer.TabIndex = 2;
            this.checkComer.Text = "Comer";
            this.checkComer.UseVisualStyleBackColor = true;
            // 
            // checkCinema
            // 
            this.checkCinema.AutoSize = true;
            this.checkCinema.Location = new System.Drawing.Point(45, 121);
            this.checkCinema.Name = "checkCinema";
            this.checkCinema.Size = new System.Drawing.Size(84, 17);
            this.checkCinema.TabIndex = 3;
            this.checkCinema.Text = "Ir ao cinema";
            this.checkCinema.UseVisualStyleBackColor = true;
            // 
            // checkLivro
            // 
            this.checkLivro.AutoSize = true;
            this.checkLivro.Location = new System.Drawing.Point(45, 144);
            this.checkLivro.Name = "checkLivro";
            this.checkLivro.Size = new System.Drawing.Size(80, 17);
            this.checkLivro.TabIndex = 4;
            this.checkLivro.Text = "Ler um livro";
            this.checkLivro.UseVisualStyleBackColor = true;
            // 
            // checkEstudar
            // 
            this.checkEstudar.AutoSize = true;
            this.checkEstudar.Location = new System.Drawing.Point(45, 167);
            this.checkEstudar.Name = "checkEstudar";
            this.checkEstudar.Size = new System.Drawing.Size(62, 17);
            this.checkEstudar.TabIndex = 5;
            this.checkEstudar.Text = "Estudar";
            this.checkEstudar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEstudar.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(45, 228);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(112, 39);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(285, 228);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Sair";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 378);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.checkEstudar);
            this.Controls.Add(this.checkLivro);
            this.Controls.Add(this.checkCinema);
            this.Controls.Add(this.checkComer);
            this.Controls.Add(this.checkDormir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkDormir;
        private System.Windows.Forms.CheckBox checkComer;
        private System.Windows.Forms.CheckBox checkCinema;
        private System.Windows.Forms.CheckBox checkLivro;
        private System.Windows.Forms.CheckBox checkEstudar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

