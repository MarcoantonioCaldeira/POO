namespace Exercicio_08
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
            this.text_marca = new System.Windows.Forms.TextBox();
            this.text_modelo = new System.Windows.Forms.TextBox();
            this.text_datalancamento = new System.Windows.Forms.TextBox();
            this.text_precocusto = new System.Windows.Forms.TextBox();
            this.text_lcd = new System.Windows.Forms.TextBox();
            this.text_polegada = new System.Windows.Forms.TextBox();
            this.btn_mostrar_dados = new System.Windows.Forms.Button();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_marca
            // 
            this.text_marca.Location = new System.Drawing.Point(175, 48);
            this.text_marca.Name = "text_marca";
            this.text_marca.Size = new System.Drawing.Size(179, 20);
            this.text_marca.TabIndex = 0;
            // 
            // text_modelo
            // 
            this.text_modelo.Location = new System.Drawing.Point(175, 90);
            this.text_modelo.Name = "text_modelo";
            this.text_modelo.Size = new System.Drawing.Size(179, 20);
            this.text_modelo.TabIndex = 1;
            // 
            // text_datalancamento
            // 
            this.text_datalancamento.Location = new System.Drawing.Point(175, 135);
            this.text_datalancamento.Name = "text_datalancamento";
            this.text_datalancamento.Size = new System.Drawing.Size(179, 20);
            this.text_datalancamento.TabIndex = 2;
            // 
            // text_precocusto
            // 
            this.text_precocusto.Location = new System.Drawing.Point(173, 178);
            this.text_precocusto.Name = "text_precocusto";
            this.text_precocusto.Size = new System.Drawing.Size(179, 20);
            this.text_precocusto.TabIndex = 3;
            // 
            // text_lcd
            // 
            this.text_lcd.Location = new System.Drawing.Point(173, 224);
            this.text_lcd.Name = "text_lcd";
            this.text_lcd.Size = new System.Drawing.Size(181, 20);
            this.text_lcd.TabIndex = 4;
            // 
            // text_polegada
            // 
            this.text_polegada.Location = new System.Drawing.Point(173, 271);
            this.text_polegada.Name = "text_polegada";
            this.text_polegada.Size = new System.Drawing.Size(181, 20);
            this.text_polegada.TabIndex = 5;
            // 
            // btn_mostrar_dados
            // 
            this.btn_mostrar_dados.Location = new System.Drawing.Point(21, 336);
            this.btn_mostrar_dados.Name = "btn_mostrar_dados";
            this.btn_mostrar_dados.Size = new System.Drawing.Size(104, 39);
            this.btn_mostrar_dados.TabIndex = 6;
            this.btn_mostrar_dados.Text = "Mostrar Dados";
            this.btn_mostrar_dados.UseVisualStyleBackColor = true;
            this.btn_mostrar_dados.Click += new System.EventHandler(this.btn_mostrar_dados_Click);
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(131, 336);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(104, 39);
            this.btn_Calc.TabIndex = 7;
            this.btn_Calc.Text = "Calcular Preço da venda";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(264, 336);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(90, 39);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data de lançamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Preço de Custo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "LCD (tamanho)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "polegadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 387);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.btn_mostrar_dados);
            this.Controls.Add(this.text_polegada);
            this.Controls.Add(this.text_lcd);
            this.Controls.Add(this.text_precocusto);
            this.Controls.Add(this.text_datalancamento);
            this.Controls.Add(this.text_modelo);
            this.Controls.Add(this.text_marca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_marca;
        private System.Windows.Forms.TextBox text_modelo;
        private System.Windows.Forms.TextBox text_datalancamento;
        private System.Windows.Forms.TextBox text_precocusto;
        private System.Windows.Forms.TextBox text_lcd;
        private System.Windows.Forms.TextBox text_polegada;
        private System.Windows.Forms.Button btn_mostrar_dados;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

