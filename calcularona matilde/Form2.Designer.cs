namespace calcularona_matilde
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnPro = new System.Windows.Forms.Button();
            this.BtnRaiz = new System.Windows.Forms.Button();
            this.BtnExp = new System.Windows.Forms.Button();
            this.BtnFac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNum1
            // 
            this.textNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textNum1.Location = new System.Drawing.Point(330, 36);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 22);
            this.textNum1.TabIndex = 0;
            // 
            // textNum2
            // 
            this.textNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textNum2.Location = new System.Drawing.Point(187, 36);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 22);
            this.textNum2.TabIndex = 1;
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSuma.Location = new System.Drawing.Point(119, 64);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 3;
            this.BtnSuma.Text = "suma";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnResta
            // 
            this.BtnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnResta.Location = new System.Drawing.Point(426, 64);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(75, 23);
            this.BtnResta.TabIndex = 4;
            this.BtnResta.Text = "Resta";
            this.BtnResta.UseVisualStyleBackColor = false;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDiv.Location = new System.Drawing.Point(103, 119);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(75, 23);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "Division";
            this.BtnDiv.UseVisualStyleBackColor = false;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnPro
            // 
            this.BtnPro.BackColor = System.Drawing.Color.Olive;
            this.BtnPro.Location = new System.Drawing.Point(440, 138);
            this.BtnPro.Name = "BtnPro";
            this.BtnPro.Size = new System.Drawing.Size(75, 23);
            this.BtnPro.TabIndex = 6;
            this.BtnPro.Text = "Producto";
            this.BtnPro.UseVisualStyleBackColor = false;
            this.BtnPro.Click += new System.EventHandler(this.BtnPro_Click);
            // 
            // BtnRaiz
            // 
            this.BtnRaiz.BackColor = System.Drawing.Color.Red;
            this.BtnRaiz.Location = new System.Drawing.Point(157, 189);
            this.BtnRaiz.Name = "BtnRaiz";
            this.BtnRaiz.Size = new System.Drawing.Size(75, 23);
            this.BtnRaiz.TabIndex = 7;
            this.BtnRaiz.Text = "Raiz";
            this.BtnRaiz.UseVisualStyleBackColor = false;
            this.BtnRaiz.Click += new System.EventHandler(this.BtnRaiz_Click);
            // 
            // BtnExp
            // 
            this.BtnExp.BackColor = System.Drawing.Color.Olive;
            this.BtnExp.Location = new System.Drawing.Point(374, 189);
            this.BtnExp.Name = "BtnExp";
            this.BtnExp.Size = new System.Drawing.Size(75, 23);
            this.BtnExp.TabIndex = 8;
            this.BtnExp.Text = "Exponente";
            this.BtnExp.UseVisualStyleBackColor = false;
            this.BtnExp.Click += new System.EventHandler(this.BtnExp_Click);
            // 
            // BtnFac
            // 
            this.BtnFac.BackColor = System.Drawing.Color.Gray;
            this.BtnFac.Location = new System.Drawing.Point(274, 230);
            this.BtnFac.Name = "BtnFac";
            this.BtnFac.Size = new System.Drawing.Size(75, 30);
            this.BtnFac.TabIndex = 9;
            this.BtnFac.Text = "Factorial";
            this.BtnFac.UseVisualStyleBackColor = false;
            this.BtnFac.Click += new System.EventHandler(this.BtnFac_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFac);
            this.Controls.Add(this.BtnExp);
            this.Controls.Add(this.BtnRaiz);
            this.Controls.Add(this.BtnPro);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnPro;
        private System.Windows.Forms.Button BtnRaiz;
        private System.Windows.Forms.Button BtnExp;
        private System.Windows.Forms.Button BtnFac;
    }
}