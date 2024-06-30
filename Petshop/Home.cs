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

        private void product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product(), 175, 100);
            closeForm();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new petManagement(), 175, 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Analytics(), 175, 100);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), 175, 100);
        }

        private void Home_Load(object sender, EventArgs e)
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
        private void analytics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Analytics(), 175, 100);
            closeForm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
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

        private void pictureBox7_Click(object sender, EventArgs e)
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
        }
    }
}
