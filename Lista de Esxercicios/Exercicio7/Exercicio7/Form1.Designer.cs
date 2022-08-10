namespace Exercicio7
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
            this.label1 = new System.Windows.Forms.Label();
            this.textnum = new System.Windows.Forms.TextBox();
            this.radiob1 = new System.Windows.Forms.RadioButton();
            this.radiob2 = new System.Windows.Forms.RadioButton();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // textnum
            // 
            this.textnum.Location = new System.Drawing.Point(136, 36);
            this.textnum.Name = "textnum";
            this.textnum.Size = new System.Drawing.Size(166, 23);
            this.textnum.TabIndex = 1;
            // 
            // radiob1
            // 
            this.radiob1.AutoSize = true;
            this.radiob1.Location = new System.Drawing.Point(79, 87);
            this.radiob1.Name = "radiob1";
            this.radiob1.Size = new System.Drawing.Size(71, 19);
            this.radiob1.TabIndex = 2;
            this.radiob1.TabStop = true;
            this.radiob1.Text = "Sucessor";
            this.radiob1.UseVisualStyleBackColor = true;
            // 
            // radiob2
            // 
            this.radiob2.AutoSize = true;
            this.radiob2.Location = new System.Drawing.Point(79, 123);
            this.radiob2.Name = "radiob2";
            this.radiob2.Size = new System.Drawing.Size(83, 19);
            this.radiob2.TabIndex = 3;
            this.radiob2.TabStop = true;
            this.radiob2.Text = "Antecessor";
            this.radiob2.UseVisualStyleBackColor = true;
            this.radiob2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(79, 166);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(109, 37);
            this.btncalc.TabIndex = 4;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 213);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.radiob2);
            this.Controls.Add(this.radiob1);
            this.Controls.Add(this.textnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textnum;
        private RadioButton radiob1;
        private RadioButton radiob2;
        private Button btncalc;
    }
}