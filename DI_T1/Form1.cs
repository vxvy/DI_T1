using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.ForeColor = Color.Black;
                lblResultado.Text = "= "+ (Convert.ToDouble(txbSum1.Text) + Convert.ToDouble(txbSum2.Text));

            }
            catch (FormatException fe)
            {
                string msg;
                if (txbSum1.Text=="" || txbSum2.Text == "")
                {
                    msg = "= Ninguno de los campos puede estar vacío";
                }
                else
                {
                    msg = "= No se pueden sumar letras";
                }
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = msg;
            }
        }
    }
}
