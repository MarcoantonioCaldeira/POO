namespace Exercicio_02
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
            this.text_cor = new System.Windows.Forms.TextBox();
            this.text_circunferencia = new System.Windows.Forms.TextBox();
            this.text_material = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Circunferencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material:";
            // 
            // text_cor
            // 
            this.text_cor.Location = new System.Drawing.Point(80, 73);
            this.text_cor.Name = "text_cor";
            this.text_cor.Size = new System.Drawing.Size(170, 20);
            this.text_cor.TabIndex = 3;
            // 
            // text_circunferencia
            // 
            this.text_circunferencia.Location = new System.Drawing.Point(132, 132);
            this.text_circunferencia.Name = "text_circunferencia";
            this.text_circunferencia.Size = new System.Drawing.Size(118, 20);
            this.text_circunferencia.TabIndex = 4;
            // 
            // text_material
            // 
            this.text_material.Location = new System.Drawing.Point(101, 185);
            this.text_material.Name = "text_material";
            this.text_material.Size = new System.Drawing.Size(149, 20);
            this.text_material.TabIndex = 5;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(101, 316);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(112, 40);
            this.btn_gravar.TabIndex = 6;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 416);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.text_material);
            this.Controls.Add(this.text_circunferencia);
            this.Controls.Add(this.text_cor);
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
        private System.Windows.Forms.TextBox text_cor;
        private System.Windows.Forms.TextBox text_circunferencia;
        private System.Windows.Forms.TextBox text_material;
        private System.Windows.Forms.Button btn_gravar;
    }
}

