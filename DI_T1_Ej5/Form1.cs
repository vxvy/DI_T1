using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T1_Ej5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Quieres cambiar el título por "+txbNuevoTitulo.Text+"?",
                "title",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (dr==DialogResult.Yes) {
                this.Text = txbNuevoTitulo.Text;
            }
        }
    }
}