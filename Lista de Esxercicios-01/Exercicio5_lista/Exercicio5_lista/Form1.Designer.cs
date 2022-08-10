namespace Exercicio5_lista
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
            this.btn_clique = new System.Windows.Forms.Button();
            this.text_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_clique
            // 
            this.btn_clique.Location = new System.Drawing.Point(46, 116);
            this.btn_clique.Name = "btn_clique";
            this.btn_clique.Size = new System.Drawing.Size(109, 23);
            this.btn_clique.TabIndex = 0;
            this.btn_clique.Text = "Clique aqui";
            this.btn_clique.UseVisualStyleBackColor = true;
            this.btn_clique.Click += new System.EventHandler(this.btn_clique_Click);
            // 
            // text_result
            // 
            this.text_result.Location = new System.Drawing.Point(161, 119);
            this.text_result.Name = "text_result";
            this.text_result.Size = new System.Drawing.Size(181, 20);
            this.text_result.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 312);
            this.Controls.Add(this.text_result);
            this.Controls.Add(this.btn_clique);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clique;
        private System.Windows.Forms.TextBox text_result;
    }
}

