namespace Exercicio_03
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
            this.btn_calcular_area = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do lado:";
            // 
            // text_lado
            // 
            this.text_lado.Location = new System.Drawing.Point(169, 124);
            this.text_lado.Name = "text_lado";
            this.text_lado.Size = new System.Drawing.Size(145, 20);
            this.text_lado.TabIndex = 1;
            // 
            // btn_calcular_area
            // 
            this.btn_calcular_area.Location = new System.Drawing.Point(136, 219);
            this.btn_calcular_area.Name = "btn_calcular_area";
            this.btn_calcular_area.Size = new System.Drawing.Size(111, 38);
            this.btn_calcular_area.TabIndex = 2;
            this.btn_calcular_area.Text = "Calcular Area";
            this.btn_calcular_area.UseVisualStyleBackColor = true;
            this.btn_calcular_area.Click += new System.EventHandler(this.btn_calcular_area_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 331);
            this.Controls.Add(this.btn_calcular_area);
            this.Controls.Add(this.text_lado);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_lado;
        private System.Windows.Forms.Button btn_calcular_area;
    }
}

