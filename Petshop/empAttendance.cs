using MySql.Data.MySqlClient;
using Practice1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Petshop
{
    public partial class empAttendance : Form
    {
        private Conclass dbConnect;
        private MySqlDataReader myReader, myReader1, myReader2;
        string day;
        public empAttendance()
        {
            InitializeComponent();
        }

        private void empOne_Load(object sender, EventArgs e)
        {
            attendanceFl.Controls.Clear();
            loadFL();
            loadEmp();
        }
        private void loadFL()
        {
            int currentDay = (int)DateTime.Now.DayOfWeek + 1;
            attendanceFl.Controls.Clear();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_id, employee.employee_fname, employee.employee_lname, employee.employee_cNumber, position.position_desc FROM employee INNER JOIN position ON employee.position_id = position.position_id INNER JOIN shift ON employee.shift_id = shift.shift_id WHERE employee.employee_id > '0' AND employee.position_id != '6' AND (shift.shift_start <= @shift AND shift.shift_end >= @shift) OR (shift.shift_start > shift.shift_end AND (@shift >= shift.shift_start OR @shift <= shift.shift_end))", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@shift", currentDay.ToString());
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int rowcount = 1;
                attendance[] employeeAttendance = new attendance[rowcount];
                for (int i = 0; i < employeeAttendance.Length; i++)
                {
 /*                   byte[] img = (byte[])(myReader["empImg"]);
                    MemoryStream ms = new MemoryStream(img);*/
                    int controlCount = attendanceFl.Controls.Count;
                    employeeAttendance[i] = new attendance();
                    employeeAttendance[i].employeeName = myReader["employee_fname"].ToString() + " " + myReader["employee_lname"].ToString();
                    employeeAttendance[i].Desc = myReader["position_desc"].ToString();
                    employeeAttendance[i].No = myReader["employee_cNumber"].ToString();
                    employeeAttendance[i].Id = myReader["employee_id"].ToString();
                    attendanceFl.Controls.Add(employeeAttendance[i]);
                }
                rowcount++;
            }
        }
        private void loadEmp()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT position_desc, employee_fname, employee_lname, shift_start, shift_end, employee_cNumber FROM employee INNER JOIN position ON employee.position_id = position.position_id INNER JOIN shift ON employee.shift_id = shift.shift_id WHERE employee.position_id != '6'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int start = Convert.ToInt32(myReader["shift_start"]);
                int end = Convert.ToInt32(myReader["shift_end"]);
                string position = myReader["position_desc"].ToString();
                string firstname = myReader["employee_fname"].ToString();
                string lastname = myReader["employee_lname"].ToString();
                string number = myReader["employee_cNumber"].ToString();
                getDay(start);
                string begin = day;
                getDay(end);
                string finish = day;
                employeeComplete.Rows.Add(position, firstname, lastname, begin, finish, number);
            }
        }
        private void getDay( int number)
        {
            switch (number)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
            }
        }
    }
}
