namespace Exercicio8_Lista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textname1 = new System.Windows.Forms.TextBox();
            this.textname2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.radioSoma = new System.Windows.Forms.RadioButton();
            this.radioSubtracao = new System.Windows.Forms.RadioButton();
            this.radioDivisao = new System.Windows.Forms.RadioButton();
            this.radioMultiplicacao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textname1
            // 
            this.textname1.Location = new System.Drawing.Point(78, 84);
            this.textname1.Name = "textname1";
            this.textname1.Size = new System.Drawing.Size(179, 23);
            this.textname1.TabIndex = 0;
            // 
            // textname2
            // 
            this.textname2.Location = new System.Drawing.Point(78, 113);
            this.textname2.Name = "textname2";
            this.textname2.Size = new System.Drawing.Size(179, 23);
            this.textname2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.SystemColors.Menu;
            this.textResultado.Location = new System.Drawing.Point(78, 189);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(179, 23);
            this.textResultado.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 30);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // radioSoma
            // 
            this.radioSoma.AutoSize = true;
            this.radioSoma.Location = new System.Drawing.Point(6, 35);
            this.radioSoma.Name = "radioSoma";
            this.radioSoma.Size = new System.Drawing.Size(55, 19);
            this.radioSoma.TabIndex = 7;
            this.radioSoma.TabStop = true;
            this.radioSoma.Text = "Soma";
            this.radioSoma.UseVisualStyleBackColor = true;
            // 
            // radioSubtracao
            // 
            this.radioSubtracao.AutoSize = true;
            this.radioSubtracao.Location = new System.Drawing.Point(6, 59);
            this.radioSubtracao.Name = "radioSubtracao";
            this.radioSubtracao.Size = new System.Drawing.Size(78, 19);
            this.radioSubtracao.TabIndex = 8;
            this.radioSubtracao.TabStop = true;
            this.radioSubtracao.Text = "Subtração";
            this.radioSubtracao.UseVisualStyleBackColor = true;
            // 
            // radioDivisao
            // 
            this.radioDivisao.AutoSize = true;
            this.radioDivisao.Location = new System.Drawing.Point(6, 84);
            this.radioDivisao.Name = "radioDivisao";
            this.radioDivisao.Size = new System.Drawing.Size(63, 19);
            this.radioDivisao.TabIndex = 9;
            this.radioDivisao.TabStop = true;
            this.radioDivisao.Text = "Divisão";
            this.radioDivisao.UseVisualStyleBackColor = true;
            // 
            // radioMultiplicacao
            // 
            this.radioMultiplicacao.AutoSize = true;
            this.radioMultiplicacao.Location = new System.Drawing.Point(6, 109);
            this.radioMultiplicacao.Name = "radioMultiplicacao";
            this.radioMultiplicacao.Size = new System.Drawing.Size(97, 19);
            this.radioMultiplicacao.TabIndex = 10;
            this.radioMultiplicacao.TabStop = true;
            this.radioMultiplicacao.Text = "Multiplicação";
            this.radioMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSoma);
            this.groupBox1.Controls.Add(this.radioMultiplicacao);
            this.groupBox1.Controls.Add(this.radioSubtracao);
            this.groupBox1.Controls.Add(this.radioDivisao);
            this.groupBox1.Location = new System.Drawing.Point(303, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 278);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textname2);
            this.Controls.Add(this.textname1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textname1;
        private TextBox textname2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textResultado;
        private Button btnCalcular;
        private RadioButton radioSoma;
        private RadioButton radioSubtracao;
        private RadioButton radioDivisao;
        private RadioButton radioMultiplicacao;
        private GroupBox groupBox1;
    }
}