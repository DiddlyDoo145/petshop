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
            childForm.Dock = DockStyle.None;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            childForm.Size = new Size(1335, 672);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Location = new Point(xpos, ypos);
        }
        #endregion

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empAttendance(), 5, 110);
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empPayroll(), 5, 110);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm1(new empManage(), 5, 110);
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empAttendanceRecord(), 5, 110);
        }

        private void positionMngmntBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new empPosition(), 5, 110);
        }
    }
}
