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
    public partial class attendance : UserControl
    {
        private Conclass dbConnect;
        private MySqlDataReader myReader, myReader1, myReader2;
        string salary, currentPayroll, OTRate, currentOThrs, addOThrs, totalOTpay, rateID, OTid;
        public Label _Name;
        public Label _Desc;
        public Label _No;
        public Label _Id;
        public PictureBox _Img;
        private DateTime _Date = DateTime.Now;
        public attendance()
        {
            InitializeComponent();
            _Name = empName;
            _Desc = empDesc;
            _No = empNo;
            _Id = empId;
        }
        #region Properties

        private Color _imgBack;
        private string _name;
        private string _id;
        private string _desc;
        private string _no;
        private Image _img;

        [Category("Custom Props")]
        public string employeeName
        {
            get { return _name; }
            set { _name = value; empName.Text = value; }
        }

        [Category("Custom Props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; empId.Text = value; }
        }

        [Category("Custom Props")]
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; empDesc.Text = value; }
        }

        [Category("Custom Props")]
        public string No
        {
            get { return _no; }
            set { _desc = value; empNo.Text = value; }
        }
        #endregion

        #region Attendance
        private void present_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attendance WHERE employee_id = @id AND attendance_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", empId.Text);
            cmd.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                MessageBox.Show("Employee attendance have already been marked for today", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string status = "Present";
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO attendance VALUES('', @empid, @date, @stat)", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@empid", empId.Text);
                cmd1.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
                cmd1.Parameters.AddWithValue("@stat", status);
                int insert = cmd1.ExecuteNonQuery();
                if (insert > 0)
                {
                    getSalary();
                    MessageBox.Show("Employee attendance set to present");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getSalary();
        }

        private void absent_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attendance WHERE employee_id = @id AND attendance_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", empId.Text);
            cmd.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                MessageBox.Show("Employee attendance have already been marked for today", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string status = "Absent";
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO attendance VALUES('', @empid, @date, @stat)", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@empid", empId.Text);
                cmd1.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
                cmd1.Parameters.AddWithValue("@stat", status);
                int insert = cmd1.ExecuteNonQuery();
                if (insert > 0)
                {
                    MessageBox.Show("Employee attendance set to absent");
                }
            }
        }

        private void timeOut_Click(object sender, EventArgs e)
        {
            string status = "Timed out";
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM attendance WHERE employee_id = @id AND attendance_date = @date AND attendance_status = @status", dbConnect.myconnect);
            cmd3.Parameters.AddWithValue("@id", empId.Text);
            cmd3.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
            cmd3.Parameters.AddWithValue("@status", status);
            myReader1 = cmd3.ExecuteReader();
            if (myReader1.Read())
            {
                MessageBox.Show("Employee have already been timed out for today", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DateTime timeOfDay = DateTime.Now;
                TimeSpan offWork = new TimeSpan(timeOfDay.Hour, timeOfDay.Minute, 0);
                DateTime timeOfClose = DateTime.Today.AddHours(17);
                TimeSpan closing = new TimeSpan(timeOfClose.Hour, timeOfClose.Minute, 0);
                TimeSpan difference = offWork - closing;
                int OTHour = difference.Hours;
                int OTMin = difference.Minutes;
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT overtime_rate.otRate_pay, overtime_rate.otRate_id FROM overtime_rate RIGHT JOIN position ON overtime_rate.position_id = position.position_id RIGHT JOIN employee ON position.position_id = employee.position_id WHERE employee.employee_id = @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", empId.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    OTRate = myReader["otRate_pay"].ToString();
                    rateID = myReader["otRate_id"].ToString();
                }
                dbConnect.CloseConnection();
                if (OTMin >= 45)
                {
                    OTHour++;
                }
                addOThrs = OTHour.ToString();
                getOThours();
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("UPDATE attendance SET attendance_status = @stat WHERE employee_id = @empid AND attendance_date = @date", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@empid", empId.Text);
                cmd1.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
                cmd1.Parameters.AddWithValue("@stat", status);
                int update = cmd1.ExecuteNonQuery();
                if (update > 0)
                {
                    MessageBox.Show("Employee timed out", "Timed out");
                }
            }
        }

        #endregion

        #region payroll
        private void getSalary()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT position.position_salary FROM position RIGHT JOIN employee ON position.position_id = employee.position_id WHERE employee.employee_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", empId.Text);
            myReader = cmd.ExecuteReader();
            if(myReader.Read())
            {
                salary = myReader["position_salary"].ToString();
            }
            dbConnect.CloseConnection();
            getPayroll();
            newPayroll();
        }
        private void getPayroll()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT payroll_total FROM payroll WHERE employee_id = @emp AND payroll_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@emp", empId.Text);
            cmd.Parameters.AddWithValue("@date", _Date.ToString("MM-yyyy"));
            myReader = cmd.ExecuteReader();
            if(myReader.Read())
            {
                currentPayroll = myReader["payroll_total"].ToString();
            }
            else
            {
                newMonthPayroll();
            }
            dbConnect.CloseConnection();
        }
        private void newMonthPayroll()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO payroll VALUES('', @newEmp, @ot, @newDate, '0')", dbConnect.myconnect);
            cmd1.Parameters.AddWithValue("@ot", OTid);
            cmd1.Parameters.AddWithValue("@newEmp", empId.Text);
            cmd1.Parameters.AddWithValue("@newDate", _Date.ToString("MM-yyyy"));
            cmd1.ExecuteNonQuery();
            getPayroll();
        }
        private void newPayroll()
        {
            int num1 = Convert.ToInt32(salary);
            int num2 = Convert.ToInt32(currentPayroll);
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE payroll SET payroll_total = @newTotal WHERE employee_id = @emp AND payroll_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@emp", empId.Text);
            cmd.Parameters.AddWithValue("@date", _Date.ToString("MM-yyyy"));
            cmd.Parameters.AddWithValue("@newTotal", Convert.ToString(num1 + num2));
            cmd.ExecuteNonQuery();
        }
        private void getOThours()
        {
            DateTime monthyear = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT overtime_id, overtime_hours FROM overtime WHERE employee_id = @id AND overtime_date = @date",dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", empId.Text);
            cmd.Parameters.AddWithValue("@date", monthyear.ToString("MM-yyyy"));
            myReader = cmd.ExecuteReader();
            if(myReader.Read())
            {
                OTid = myReader["overtime_id"].ToString();
                currentOThrs = myReader["overtime_hours"].ToString();
                dbConnect.CloseConnection();
                int num1 = Convert.ToInt32(currentOThrs);
                int num2 = Convert.ToInt32(addOThrs);
                int newOThrs = num1 + num2;
                int newTotal = newOThrs * Convert.ToInt32(OTRate);
                totalOTpay = newTotal.ToString();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("UPDATE overtime SET overtime_hours = @hours, overtime_total = @OTpay WHERE employee_id = @uid AND overtime_date = @udate", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@hours", newOThrs);
                cmd1.Parameters.AddWithValue("@OTpay", newTotal);
                cmd1.Parameters.AddWithValue("@uid", empId.Text);
                cmd1.Parameters.AddWithValue("@udate", monthyear.ToString("MM-yyyy"));
                cmd1.ExecuteNonQuery();
            }
            else
            {
                newOT();
            }
            getPayroll();
            updatePayroll();
        }
        private void newOT()
        {
            DateTime monthyear = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO overtime VALUES('', @rate, @id, '0', @date, '0')", dbConnect.myconnect);
            cmd1.Parameters.AddWithValue("@rate", rateID);
            cmd1.Parameters.AddWithValue("@id", empId.Text);
            cmd1.Parameters.AddWithValue("@date", monthyear.ToString("MM-yyyy"));
            cmd1.ExecuteNonQuery();
            getOThours();
        }
        private void updatePayroll()
        {
            DateTime monthyear = DateTime.Now;
            int num1 = Convert.ToInt32(currentPayroll);
            int num2 = Convert.ToInt32(addOThrs);
            int num3 = Convert.ToInt32(OTRate);
            int newPayroll = num1 + (num2 * num3);
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE payroll SET payroll_total = @payroll WHERE employee_id = @id AND payroll_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@payroll", newPayroll);
            cmd.Parameters.AddWithValue("@id", empId.Text);
            cmd.Parameters.AddWithValue("@date", monthyear.ToString("MM-yyyy"));
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
