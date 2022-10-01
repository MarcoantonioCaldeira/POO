namespace Exercicio_06
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
            this.btn_clique_aqui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clique_aqui
            // 
            this.btn_clique_aqui.Location = new System.Drawing.Point(102, 264);
            this.btn_clique_aqui.Name = "btn_clique_aqui";
            this.btn_clique_aqui.Size = new System.Drawing.Size(123, 49);
            this.btn_clique_aqui.TabIndex = 0;
            this.btn_clique_aqui.Text = "Clique aqui";
            this.btn_clique_aqui.UseVisualStyleBackColor = true;
            this.btn_clique_aqui.Click += new System.EventHandler(this.btn_clique_aqui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ver a frase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clique_aqui);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clique_aqui;
        private System.Windows.Forms.Label label1;
    }
}

