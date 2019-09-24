namespace DI_T1_Ej5
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
            this.txbNuevoTitulo = new System.Windows.Forms.TextBox();
            this.btnChangeTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNuevoTitulo
            // 
            this.txbNuevoTitulo.Location = new System.Drawing.Point(12, 12);
            this.txbNuevoTitulo.Name = "txbNuevoTitulo";
            this.txbNuevoTitulo.Size = new System.Drawing.Size(260, 22);
            this.txbNuevoTitulo.TabIndex = 0;
            // 
            // btnChangeTitle
            // 
            this.btnChangeTitle.Location = new System.Drawing.Point(12, 40);
            this.btnChangeTitle.Name = "btnChangeTitle";
            this.btnChangeTitle.Size = new System.Drawing.Size(75, 48);
            this.btnChangeTitle.TabIndex = 1;
            this.btnChangeTitle.Text = "Change title";
            this.btnChangeTitle.UseVisualStyleBackColor = true;
            this.btnChangeTitle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 91);
            this.Controls.Add(this.btnChangeTitle);
            this.Controls.Add(this.txbNuevoTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tema1 - Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNuevoTitulo;
        private System.Windows.Forms.Button btnChangeTitle;
    }
}

