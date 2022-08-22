namespace Exercicio3_Metodos
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
            this.text_base = new System.Windows.Forms.TextBox();
            this.text_altura = new System.Windows.Forms.TextBox();
            this.btn_mostrardados = new System.Windows.Forms.Button();
            this.btn_carea = new System.Windows.Forms.Button();
            this.text_area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_perimetro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor da base: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor da altura:";
            // 
            // text_base
            // 
            this.text_base.Location = new System.Drawing.Point(181, 89);
            this.text_base.Name = "text_base";
            this.text_base.Size = new System.Drawing.Size(175, 20);
            this.text_base.TabIndex = 2;
            // 
            // text_altura
            // 
            this.text_altura.Location = new System.Drawing.Point(181, 135);
            this.text_altura.Name = "text_altura";
            this.text_altura.Size = new System.Drawing.Size(175, 20);
            this.text_altura.TabIndex = 3;
            // 
            // btn_mostrardados
            // 
            this.btn_mostrardados.Location = new System.Drawing.Point(68, 316);
            this.btn_mostrardados.Name = "btn_mostrardados";
            this.btn_mostrardados.Size = new System.Drawing.Size(96, 45);
            this.btn_mostrardados.TabIndex = 4;
            this.btn_mostrardados.Text = "Mostrar Dados";
            this.btn_mostrardados.UseVisualStyleBackColor = true;
            this.btn_mostrardados.Click += new System.EventHandler(this.btn_mostrardados_Click);
            // 
            // btn_carea
            // 
            this.btn_carea.Location = new System.Drawing.Point(170, 316);
            this.btn_carea.Name = "btn_carea";
            this.btn_carea.Size = new System.Drawing.Size(87, 45);
            this.btn_carea.TabIndex = 6;
            this.btn_carea.Text = "Calcular";
            this.btn_carea.UseVisualStyleBackColor = true;
            this.btn_carea.Click += new System.EventHandler(this.btn_carea_Click);
            // 
            // text_area
            // 
            this.text_area.Location = new System.Drawing.Point(181, 204);
            this.text_area.Name = "text_area";
            this.text_area.Size = new System.Drawing.Size(175, 20);
            this.text_area.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor da area:";
            // 
            // text_perimetro
            // 
            this.text_perimetro.Location = new System.Drawing.Point(181, 252);
            this.text_perimetro.Name = "text_perimetro";
            this.text_perimetro.Size = new System.Drawing.Size(175, 20);
            this.text_perimetro.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor do perimetro:";
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(341, 316);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 45);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 373);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_perimetro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_area);
            this.Controls.Add(this.btn_carea);
            this.Controls.Add(this.btn_mostrardados);
            this.Controls.Add(this.text_altura);
            this.Controls.Add(this.text_base);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculo do Retâgulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_base;
        private System.Windows.Forms.TextBox text_altura;
        private System.Windows.Forms.Button btn_mostrardados;
        private System.Windows.Forms.Button btn_carea;
        private System.Windows.Forms.TextBox text_area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_perimetro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sair;
    }
}

