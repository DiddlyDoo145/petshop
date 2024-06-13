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
    public partial class empPayroll : Form
    {
        private Conclass dbConnect;
        private MySqlDataReader myReader, myReader1, myReader2;

        private void empPayroll_Load(object sender, EventArgs e)
        {
            DateTime monthyear = DateTime.Now;
            loadPayroll(monthyear);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DateTime monthyear = DateTime.Now;
            loadPayroll(monthyear);
            dateTimePicker1.Value = monthyear;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime monthyear = dateTimePicker1.Value;
            loadPayroll(monthyear);
        }

        public empPayroll()
        {
            InitializeComponent();
        }
        private void loadPayroll(DateTime monthyear)
        {

            payrollDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT payroll.payroll_id, employee.employee_fname, employee.employee_lname, overtime.overtime_hours, position.position_salary, payroll.payroll_total FROM payroll RIGHT JOIN overtime ON payroll.overtime_id = overtime.overtime_id RIGHT JOIN employee ON overtime.employee_id = employee.employee_id RIGHT JOIN position ON employee.position_id = position.position_id WHERE employee.employee_id > '0' AND position.position_desc != 'N/A' AND payroll.payroll_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@date", monthyear.ToString("MM-yyyy"));
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            payrollDgv.DataSource = dt;
            dbConnect.CloseConnection();
        }

    }
}
