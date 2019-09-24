namespace DI_T1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSuma = new System.Windows.Forms.Button();
            this.txbSum1 = new System.Windows.Forms.TextBox();
            this.txbSum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(86, 40);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // txbSum1
            // 
            this.txbSum1.Location = new System.Drawing.Point(12, 12);
            this.txbSum1.Name = "txbSum1";
            this.txbSum1.Size = new System.Drawing.Size(100, 22);
            this.txbSum1.TabIndex = 1;
            // 
            // txbSum2
            // 
            this.txbSum2.Location = new System.Drawing.Point(140, 12);
            this.txbSum2.Name = "txbSum2";
            this.txbSum2.Size = new System.Drawing.Size(100, 22);
            this.txbSum2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "+";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(246, 15);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 17);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(273, 77);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSum2);
            this.Controls.Add(this.txbSum1);
            this.Controls.Add(this.btnSuma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sumador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txbSum1;
        private System.Windows.Forms.TextBox txbSum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}

