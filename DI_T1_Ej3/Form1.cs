#define TEST

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_T1_Ej3
{
    public partial class Form1 : Form
    {
        int cash;

        public Form1()
        {
            InitializeComponent();
            txbTragaperras1.Text = " -";
            txbTragaperras2.Text = " -";
            txbTragaperras3.Text = " -";

            this.cash = Convert.ToInt32(lblCredit.Text);
        }

        private void BtnCash_Click(object sender, EventArgs e)
        {
            this.cash += 10;
            lblCredit.Text = this.cash.ToString();
        }

        private void BtnGO_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(lblCredit.Text, out cash) && (cash -2) >= 0){

                cash -= 2;
                lblCredit.Text = cash.ToString();

                Random rdm = new Random();
                rdm.Next(1,8);

                txbTragaperras1.Text = rdm.Next(1, 8).ToString();
                txbTragaperras2.Text = rdm.Next(1, 8).ToString();
                txbTragaperras3.Text = rdm.Next(1, 8).ToString();

                if (txbTragaperras1.Text == txbTragaperras2.Text 
                    && txbTragaperras1.Text == txbTragaperras3.Text)
                {
                    lblPrice.Text = "Price: "+ 20;
                    cash += 20;
                }
                else if (txbTragaperras1.Text == txbTragaperras2.Text
                    || txbTragaperras1.Text == txbTragaperras3.Text
                    || txbTragaperras3.Text == txbTragaperras2.Text )
                {
#if !TEST
                    lblPrice.Text = "Price: " + 5;
                    cash += 5;
#elif TEST
                    lblPrice.Text = "Price: -" + 5;
                    cash -= 5;
                    //Aparecerá cash -5 porque es un premio negativo
#endif
                }
                else
                {
                    lblPrice.Text = "Price: " + 0;
                }

                lblCredit.Text = cash.ToString();

            }
        }
    }
}
