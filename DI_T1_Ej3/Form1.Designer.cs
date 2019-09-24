namespace DI_T1_Ej3
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
            this.btnGO = new System.Windows.Forms.Button();
            this.txbTragaperras1 = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.txbTragaperras2 = new System.Windows.Forms.TextBox();
            this.txbTragaperras3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(239, 37);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(44, 23);
            this.btnGO.TabIndex = 0;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.BtnGO_Click);
            // 
            // txbTragaperras1
            // 
            this.txbTragaperras1.Enabled = false;
            this.txbTragaperras1.Location = new System.Drawing.Point(108, 25);
            this.txbTragaperras1.Name = "txbTragaperras1";
            this.txbTragaperras1.Size = new System.Drawing.Size(22, 22);
            this.txbTragaperras1.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(183, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(214, 9);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(24, 17);
            this.lblCredit.TabIndex = 5;
            this.lblCredit.Text = "50";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(12, 12);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(75, 48);
            this.btnCash.TabIndex = 6;
            this.btnCash.Text = "More cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.BtnCash_Click);
            // 
            // txbTragaperras2
            // 
            this.txbTragaperras2.Enabled = false;
            this.txbTragaperras2.Location = new System.Drawing.Point(147, 25);
            this.txbTragaperras2.Name = "txbTragaperras2";
            this.txbTragaperras2.Size = new System.Drawing.Size(22, 22);
            this.txbTragaperras2.TabIndex = 7;
            // 
            // txbTragaperras3
            // 
            this.txbTragaperras3.Enabled = false;
            this.txbTragaperras3.Location = new System.Drawing.Point(186, 25);
            this.txbTragaperras3.Name = "txbTragaperras3";
            this.txbTragaperras3.Size = new System.Drawing.Size(22, 22);
            this.txbTragaperras3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(314, 107);
            this.Controls.Add(this.txbTragaperras3);
            this.Controls.Add(this.txbTragaperras2);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbTragaperras1);
            this.Controls.Add(this.btnGO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tragaperras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txbTragaperras1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.TextBox txbTragaperras2;
        private System.Windows.Forms.TextBox txbTragaperras3;
    }
}

