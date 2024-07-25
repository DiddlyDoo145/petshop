using MaterialSkin.Controls;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Petshop
{
    public partial class Home : Form
    {
        private Form currentchildForm;
        private Form currentchildblur;
        public static Home instance;
        public bool isEmpty = false, isActive = false, isOpen = false;

        public Home()
        {
            InitializeComponent();
            instance = this;
        }
        public void OpenChildForm(Form childForm, int xpos, int ypos)
        {
            if (currentchildForm != null)
            {
                currentchildForm.Hide();
            }
            currentchildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            /*childForm.Size = new Size(*//*Convert.ToInt32(childForm.Width * 1.155), Convert.ToInt32(childForm.Height * 1.096 - 5)*//*1400, 782);*/
            childForm.FormBorderStyle = FormBorderStyle.None;
            /*childForm.Location = new Point(xpos, ypos);*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkcheckout();
            if (isOpen == true)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "BlurBg")
                    {
                        f.BringToFront();
                        break;
                    }
                }
            }
            else
            {
                if (isActive == true)
                {
                    checkCashier();
                    if (isEmpty == true)
                    {
                        closeForm();
                        OpenChildForm(new Employee(), 175, 100);
                        BlurBg bbg = new BlurBg();
                        bbg.Size = new Size(1400, 782);
                        bbg.Visible = true;
                        bbg.BringToFront();
                        BlurBg.instance.pickCashier = false;
                        BlurBg.instance.employeeManage = true;
                        BlurBg.instance.BlurBg_Load(null, null);
                    }
                    else
                    {
                        MaterialMessageBox.Show("Please complete the transaction before leaving", "Notice");
                    }
                }
                else
                {
                    closeForm();
                    OpenChildForm(new Employee(), 175, 100);
                    BlurBg bbg = new BlurBg();
                    bbg.Size = new Size(1400, 782);
                    bbg.Visible = true;
                    bbg.BringToFront();
                    BlurBg.instance.pickCashier = false;
                    BlurBg.instance.employeeManage = true;
                    BlurBg.instance.BlurBg_Load(null, null);
                }
            }
        }

        private void product_Click(object sender, EventArgs e)
        {
            checkcheckout();
            if (isOpen == true)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "BlurBg")
                    {
                        f.BringToFront();
                        break;
                    }
                }
            }
            else
            {
                if (isActive == true)
                {
                    checkCashier();
                    if (isEmpty == true)
                    {
                        OpenChildForm(new Product(), 175, 100);
                        closeForm();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Please complete the transaction before leaving", "Notice");
                    }
                }
                else
                {
                    OpenChildForm(new Product(), 175, 100);
                    closeForm();
                }
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
            if(isActive == true)
            {
                if(isEmpty == true)
                {
                    OpenChildForm(new Analytics(), 175, 100);
                    closeForm();
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "Login")
                        {
                            f.Close();
                            break;
                        }
                    }
                }
            }
            else
            {
                OpenChildForm(new Analytics(), 175, 100);
                closeForm();
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "Login")
                    {
                        f.Close();
                        break;
                    }
                }
            }
        }
        private void analytics_Click(object sender, EventArgs e)
        {
            checkcheckout();
            if (isOpen == true)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "BlurBg")
                    {
                        f.BringToFront();
                        break;
                    }
                }
            }
            else
            {
                if (isActive == true)
                {
                    checkCashier();
                    if (isEmpty == true)
                    {
                        OpenChildForm(new Analytics(), 175, 100);
                        closeForm();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Please complete the transaction before leaving", "Notice");
                    }
                }
                else
                {
                    OpenChildForm(new Analytics(), 175, 100);
                    closeForm();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkcheckout();
            if (isOpen == true)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "BlurBg")
                    {
                        f.BringToFront();
                        break;
                    }
                }
            }
            else
            {
                isActive = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "Cashier")
                    {
                        isActive = true;
                        checkCashier();
                        if (isEmpty == true)
                        {
                            Cashier.instance.Cashier_Load(null, null);
                        }
                        else
                        {
                            MaterialMessageBox.Show("Please complete the transaction before refreshing", "Notice");
                            break;
                        }
                    }
                    isActive = false;
                }
                if (!isActive)
                {
                    isActive = true;
                    closeForm();
                    OpenChildForm(new Cashier(), 175, 100);
                    BlurBg bbg = new BlurBg();
                    bbg.Size = new Size(1400, 782);
                    bbg.Visible = true;
                    bbg.BringToFront();
                    BlurBg.instance.pickCashier = true;
                    BlurBg.instance.employeeManage = false;
                    BlurBg.instance.BlurBg_Load(null, null);
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            checkcheckout();
            if (isOpen == true)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "BlurBg")
                    {
                        f.BringToFront();
                        break;
                    }
                }
            }
            else
            {
                if (isActive == true)
                {
                    checkCashier();
                    if (isEmpty == true)
                    {
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f.Name == "BlurBg")
                            {
                                f.BringToFront();
                                break;
                            }
                        }
                        if (MaterialMessageBox.Show("Are you sure you want to Log-Out?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "BlurBg")
                                {
                                    f.BringToFront();
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        MaterialMessageBox.Show("Please complete the transaction before leaving", "Notice");
                    }
                }
                else
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "BlurBg")
                        {
                            f.BringToFront();
                            break;
                        }
                    }
                    if (MaterialMessageBox.Show("Are you sure you want to Log-Out?", "Notice!", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f.Name == "BlurBg")
                            {
                                f.BringToFront();
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void closeForm()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "assignCashier")
                {
                    f.Close();
                    break;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "EmpCODEPIN")
                {
                    f.Close();
                    break;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "BlurBg")
                {
                    f.Close();
                    break;
                }
            }
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "checkoutTotal")
                {
                    f.Close();
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkCashier();
            timer1.Stop();
        }

        private void checkCashier()
        {
            int total = Cashier.instance.receiptDgv.Rows.Count;
            if(total > 0)
            {
                isEmpty = false;
            }
            else
            {
                isEmpty = true;
            }
        }
        private void checkcheckout()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "checkoutTotal")
                {
                    isOpen = true;
                }
                else
                {
                    isOpen = false;
                }
            }
        }
    }
}
  