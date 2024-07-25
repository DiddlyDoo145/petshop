using Google.Protobuf.WellKnownTypes;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Practice1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class checkoutTotal : Form
    {
        public static checkoutTotal instance;
        public checkoutTotal()
        {
            InitializeComponent();
            instance = this;
        }

        private void customerCash_TextChanged(object sender, EventArgs e)
        {
            if(customerCash.TextLength == 0)
            {
                sukli.Text = "Insufficient";
            }
            else
            {
                int num1 = Convert.ToInt32(orderTotal.Text);
                int num2 = Convert.ToInt32(customerCash.Text);
                int total = num2 - num1;
                if (total < 0)
                {
                    sukli.Text = "Insufficient";
                }
                else
                {
                    sukli.Text = total.ToString();
                }
            }
        }

        private void customerCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void receiptPrint_Click(object sender, EventArgs e)
        {
            if(sukli.Text == "Insufficient" || customerCash.TextLength == 0)
            {
                return;
            }
            else
            {
                Home.instance.closeForm();
            }
        }
    }
}
