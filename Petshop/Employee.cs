using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Practice1;

namespace Petshop
{
    public partial class Employee : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        private Form currentchildForm1;
        //Hii this is new!
        public Employee()
        {
            InitializeComponent();
        }
        #region kim
        public void OpenChildForm1(Form childForm, int xpos, int ypos)
        {
            if (currentchildForm1 != null)
            {
                currentchildForm1.Hide();
            }
            currentchildForm1 = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
/*            childForm.Size = new Size(1335, 665);*/
            childForm.FormBorderStyle = FormBorderStyle.None;
            /*            childForm.Location = new Point(xpos, ypos);*/
        }
        #endregion

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empAttendance(), 30, 110);
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empPayroll(), 30, 110);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            OpenChildForm1(new empManage(), 30, 110);

        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empAttendanceRecord(), 30, 110);
        }

        private void positionMngmntBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empPosition(), 30, 110);
        }

        private void oT_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empOt(), 30, 110);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            OpenChildForm1(new empAttendance(), 30, 110);
        }
    }
}
