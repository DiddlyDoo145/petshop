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
    public partial class empAttendanceRecord : Form
    {
        private Conclass dbConnect;
        private MySqlDataReader myReader, myReader1, myReader2;
        public empAttendanceRecord()
        {
            InitializeComponent();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            specificDate.Value = DateTime.Now;
            retrieveRecord();
        }

        private void specificDate_ValueChanged(object sender, EventArgs e)
        {
            specifyDate();
        }

        private void empAttendanceRecord_Load(object sender, EventArgs e)
        {
            retrieveRecord();
        }
        private void retrieveRecord()
        {
            DateTime tooday = DateTime.Now;
            records.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_fname, employee.employee_lname, attendance.attendance_date, attendance.attendance_status FROM employee RIGHT JOIN attendance ON employee.employee_id = attendance.employee_id WHERE attendance.attendance_date = @today ORDER BY attendance.attendance_date ASC", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@today", tooday.ToString("MM-dd-yyyy"));
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            records.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void specifyDate()
        {
            records.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_fname, employee.employee_lname, attendance.attendance_date, attendance.attendance_status FROM employee RIGHT JOIN attendance ON employee.employee_id = attendance.employee_id WHERE attendance.attendance_date = @specific ORDER BY attendance.attendance_date ASC", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@specific", specificDate.Value.ToString("MM-dd-yyyy"));
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            records.DataSource = dt;
            dbConnect.CloseConnection();
        }
    }
}
