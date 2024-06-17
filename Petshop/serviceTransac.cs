using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class EmpCODEPIN : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);
        public EmpCODEPIN()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void EmpCODEPIN_Load(object sender, EventArgs e)
        {
            this.TabIndex = 0;
            secondPin.Enabled = false;
            thirdPin.Enabled = false;
            fourthPin.Enabled = false;
        }

        private void firstPin_TextChanged(object sender, EventArgs e)
        {
            if(firstPin.TextLength > 0)
            {
                this.TabIndex = 1;
                secondPin.Enabled = true;
                firstPin.Enabled = false;
            }
        }

        private void secondPin_TextChanged(object sender, EventArgs e)
        {
            if (secondPin.TextLength > 0)
            {
                this.TabIndex = 2;
                thirdPin.Enabled = true;
                secondPin.Enabled = false;
            }
            else if (secondPin.TextLength == 0)
            {
                firstPin.Enabled = true;
                secondPin.Enabled = false;
                this.TabIndex = 0;
            }
        }

        private void thirdPin_TextChanged(object sender, EventArgs e)
        {
            if (thirdPin.TextLength > 0)
            {
                this.TabIndex = 3;
                fourthPin.Enabled = true;
                thirdPin.Enabled = false;
            }
            else if(thirdPin.TextLength == 0)
            {
                secondPin.Enabled = true;
                thirdPin.Enabled = false;
                this.TabIndex = 1;
            }
        }

        private void fourthPin_TextChanged(object sender, EventArgs e)
        {
            if (fourthPin.TextLength > 0)
            {
                if (firstPin.Text == "1" && secondPin.Text == "2" && thirdPin.Text == "3" && fourthPin.Text == "4")
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "BlurBg")
                        {
                            f.Close();
                            break;
                        }
                    }
                    this.Close();
                }
                else
                {
                    MaterialMessageBox.Show("Incorrect Pincode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(fourthPin.Text.Length == 0)
            {
                thirdPin.Enabled = true;
                fourthPin.Enabled = false;
                this.TabIndex = 2;
            }
        }
    }
}
