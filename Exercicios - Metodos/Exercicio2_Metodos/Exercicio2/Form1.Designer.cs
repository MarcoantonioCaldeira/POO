namespace Exercicio2
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
            this.text_lado = new System.Windows.Forms.TextBox();
            this.btn_area = new System.Windows.Forms.Button();
            this.btn_perimetro = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do lado: ";
            // 
            // text_lado
            // 
            this.text_lado.Location = new System.Drawing.Point(140, 112);
            this.text_lado.Name = "text_lado";
            this.text_lado.Size = new System.Drawing.Size(147, 20);
            this.text_lado.TabIndex = 1;
            this.text_lado.TextChanged += new System.EventHandler(this.text_lado_TextChanged);
            // 
            // btn_area
            // 
            this.btn_area.Location = new System.Drawing.Point(33, 263);
            this.btn_area.Name = "btn_area";
            this.btn_area.Size = new System.Drawing.Size(116, 46);
            this.btn_area.TabIndex = 2;
            this.btn_area.Text = "Calcular Area";
            this.btn_area.UseVisualStyleBackColor = true;
            this.btn_area.Click += new System.EventHandler(this.btn_area_Click);
            // 
            // btn_perimetro
            // 
            this.btn_perimetro.Location = new System.Drawing.Point(171, 263);
            this.btn_perimetro.Name = "btn_perimetro";
            this.btn_perimetro.Size = new System.Drawing.Size(116, 46);
            this.btn_perimetro.TabIndex = 3;
            this.btn_perimetro.Text = "Calcular Perimetro";
            this.btn_perimetro.UseVisualStyleBackColor = true;
            this.btn_perimetro.Click += new System.EventHandler(this.btn_perimetro_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(396, 276);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(97, 33);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 338);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_perimetro);
            this.Controls.Add(this.btn_area);
            this.Controls.Add(this.text_lado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo Quaodrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_lado;
        private System.Windows.Forms.Button btn_area;
        private System.Windows.Forms.Button btn_perimetro;
        private System.Windows.Forms.Button btn_sair;
    }
}

