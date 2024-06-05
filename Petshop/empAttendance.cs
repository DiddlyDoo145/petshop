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
        public empAttendance()
        {
            InitializeComponent();
        }

        private void empOne_Load(object sender, EventArgs e)
        {
            employee();
        }
        private void employee()
        {
            attendanceFl.Controls.Clear();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_id, employee.employee_fname, employee.employee_lname, position.position_desc FROM employee RIGHT JOIN position ON employee.position_id = position.position_id WHERE employee.employee_id > '0'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int rowcount = 1;
                attendance[] employeeAttendance = new attendance[rowcount];
                for (int i = 0; i < employeeAttendance.Length; i++)
                {
/*                    byte[] img = (byte[])(myReader["empImg"]);
                    MemoryStream ms = new MemoryStream(img);*/
                    int controlCount = attendanceFl.Controls.Count;
                    employeeAttendance[i] = new attendance();
                    employeeAttendance[i].employeeName = myReader["employee_fname"].ToString() + " " + myReader["employee_lname"].ToString();
                    employeeAttendance[i].Desc = myReader["position_desc"].ToString();
                    employeeAttendance[i].Id = myReader["employee_id"].ToString();
                    attendanceFl.Controls.Add(employeeAttendance[i]);
                }
                rowcount++;
            }
        }
    }
}
