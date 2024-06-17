using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class empManage : Form
    {
        string jobID, address, otrID, otID, jobSalary, shiftID;
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader, myReader1, myReader2;
        private string employeeId;
        private void empManage_Load(object sender, EventArgs e)
        {
            jobList();
            loadEmployee();
            jobTitle.SelectedIndex = 0;
            startShift.SelectedIndex = 0;
            endShift.SelectedIndex = 0;
            employeeId = "";
        }

        public empManage()
        {
            InitializeComponent();
        }
        #region load Data
        private void jobList()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT position_desc FROM position WHERE position_desc != 'N/A'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                jobTitle.Items.Add(myReader["position_desc"].ToString());
            }
            dbConnect.CloseConnection();
        }

        private void loadEmployee()
        {
            employees.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_id, position.position_desc, employee.employee_fname, employee.employee_lname, shift.shift_start, shift.shift_end, employee.employee_cNumber, employee.employee_ecNumber FROM employee RIGHT JOIN position ON employee.position_id = position.position_id RIGHT JOIN shift ON employee.shift_id = shift.shift_id WHERE employee.employee_id > '0' && position.position_desc != 'N/A'", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            employees.DataSource = dt;
            dbConnect.CloseConnection();
        }
        private void loadAddress()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd2 = new MySqlCommand("SELECT address_id FROM address WHERE address_city = @city AND address_muni = @municipality AND address_brgy = @brgy", dbConnect.myconnect);
            cmd2.Parameters.AddWithValue("@city", newCity.Text);
            cmd2.Parameters.AddWithValue("@municipality", newMunicipality.Text);
            cmd2.Parameters.AddWithValue("@brgy", newBarangay.Text);
            myReader2 = cmd2.ExecuteReader();
            if (myReader2.Read())
            {
                address = myReader2["address_id"].ToString();
                dbConnect.CloseConnection();
            }
            else
            {
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd3 = new MySqlCommand("INSERT INTO address VALUES (' ', @newCity, @newMuni, @newBrgy); SELECT LAST_INSERT_ID();", dbConnect.myconnect);
                cmd3.Parameters.AddWithValue("@newCity", newCity.Text);
                cmd3.Parameters.AddWithValue("@newMuni", newMunicipality.Text);
                cmd3.Parameters.AddWithValue("@newBrgy", newBarangay.Text);
                object result = cmd3.ExecuteScalar();
                int num = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                address = num.ToString();
                dbConnect.CloseConnection();
            }
        }

        private void retrieveAddress()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT address_id FROM employee WHERE employee_id = @empid", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@empid", employeeId);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                string addID = myReader["address_id"].ToString();
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("SELECT address_city, address_muni, address_brgy FROM address WHERE address_id = @address ", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@address", addID);
                myReader1 = cmd1.ExecuteReader();
                if (myReader1.Read())
                {
                    newCity.Text = myReader1["address_city"].ToString();
                    newMunicipality.Text = myReader1["address_muni"].ToString();
                    newBarangay.Text = myReader1["address_brgy"].ToString();
                }
            }
        }
        private void loadShift()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT shift_id FROM shift WHERE shift_start = @start AND shift_end = @end", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@start", startShift.SelectedIndex.ToString());
            cmd.Parameters.AddWithValue("@end", endShift.SelectedIndex.ToString());
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                shiftID = myReader["shift_id"].ToString();
            }
            else
            {
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO shift VALUES('', @nstart, @nend); SELECT LAST_INSERT_ID();", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@nstart", startShift.SelectedIndex.ToString());
                cmd1.Parameters.AddWithValue("@nend", endShift.SelectedIndex.ToString());
                object result = cmd1.ExecuteScalar();
                int num = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                shiftID = num.ToString();
                dbConnect.CloseConnection();
            }
        }
        #endregion
        #region Clicks
        private void employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {

            }
            else
            {
                employeeId = employees.Rows[e.RowIndex].Cells[0].Value.ToString();
                jobTitle.SelectedItem = employees.Rows[e.RowIndex].Cells[1].Value.ToString();
                firstName.Text = employees.Rows[e.RowIndex].Cells[2].Value.ToString();
                lastName.Text = employees.Rows[e.RowIndex].Cells[3].Value.ToString();
                startShift.SelectedItem = employees.Rows[e.RowIndex].Cells[4].Value.ToString();
                endShift.SelectedItem = employees.Rows[e.RowIndex].Cells[5].Value.ToString();
                contactNumber.Text = employees.Rows[e.RowIndex].Cells[6].Value.ToString();
                emergencyNumber.Text = employees.Rows[e.RowIndex].Cells[7].Value.ToString();
                retrieveAddress();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            firstName.Clear();
            lastName.Clear();
            contactNumber.Clear();
            emergencyNumber.Clear();
            jobTitle.SelectedIndex = 0;
            newBarangay.Clear();
            newCity.Clear();
            newMunicipality.Clear();
            employeeId = "";
        }
        #endregion
        #region CRUD
        private void empSearch_Click(object sender, EventArgs e)
        {
            employees.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_id, position.position_desc, employee.employee_fname, employee.employee_lname, shift.shift_start, shift.shift_end, employee.employee_cNumber, employee.employee_ecNumber FROM employee RIGHT JOIN position ON employee.position_id = position.position_id RIGHT JOIN shift ON employee.shift_id = shift.shift_id WHERE employee.employee_id > '0' AND CONCAT (employee.employee_fname, employee.employee_lname, position.position_desc) LIKE @item", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@item", "%" + empSearchBox.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            employees.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void empSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (empSearchBox.TextLength == 0)
            {
                empSearch_Click(null, null);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            if (firstName.TextLength == 0 || lastName.TextLength == 0 || contactNumber.TextLength == 0 || emergencyNumber.TextLength == 0 || newCity.TextLength == 0 || newMunicipality.TextLength == 0 || newBarangay.TextLength == 0 || jobTitle.SelectedIndex == 0 || startShift.SelectedIndex < 1 || endShift.SelectedIndex < 1 /*|| fbProfile.TextLength == 0*/)
            {
                MessageBox.Show("Fields with " + "'*'" + " are Required. Please Complete the Form.", "Notice!");
            }
            else if (employeeId != "")
            {
                MessageBox.Show("Employee already exist, update it", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE employee_fname = @firstName AND employee_lname = @lastName", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@firstName", firstName.Text);
                cmd.Parameters.AddWithValue("@lastName", lastName.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    MessageBox.Show("Employee Already Exist in the System", "Notice!");
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT position_id, position_salary FROM position WHERE position_desc = @job", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@job", jobTitle.SelectedItem);
                    myReader1 = cmd1.ExecuteReader();
                    if (myReader1.Read())
                    {
                        jobID = myReader1["position_id"].ToString();
                        jobSalary = myReader1["position_salary"].ToString();
                    }
                    dbConnect.CloseConnection();
                    loadAddress();
                    loadShift();
                    /*                    int age = DateTime.Today.Year - bDate.Value.Year;*/
                    /*                    MessageBox.Show("" + age);*/
                    /*                    if (imagelocation == "")
                                        {*/
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd4 = new MySqlCommand("INSERT INTO employee(employee_id, employee_fname, employee_lname, employee_cNumber, employee_ecNumber, position_id, shift_id, address_id) VALUES('', @firstName, @lastName, @contactNumber, @Enum, @JobID, @shift, @address); SELECT LAST_INSERT_ID();", dbConnect.myconnect);
                    cmd4.Parameters.AddWithValue("@firstName", firstName.Text);
                    cmd4.Parameters.AddWithValue("@lastName", lastName.Text);
                    cmd4.Parameters.AddWithValue("@contactNumber", contactNumber.Text);
                    cmd4.Parameters.AddWithValue("@Enum", emergencyNumber.Text);
                    cmd4.Parameters.AddWithValue("@JobID", jobID);
                    cmd4.Parameters.AddWithValue("@shift", shiftID);
                    cmd4.Parameters.AddWithValue("@address", address);
                    object result = cmd4.ExecuteScalar();
                    int num = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                    employeeId = num.ToString();
                    MessageBox.Show("New Employee Added Sucessfully");
                    firstName.Clear();
                    lastName.Clear();
                    contactNumber.Clear();
                    emergencyNumber.Clear();
                    jobTitle.SelectedIndex = 0;
                    startShift.SelectedIndex = 0;
                    endShift.SelectedIndex = 0;
                    newMunicipality.Clear();
                    newCity.Clear();
                    newBarangay.Clear();
                    loadEmployee();
                    retrieveOTR();
                }
            }
        }
        private void updateEmp_Click(object sender, EventArgs e)
        {
            if (firstName.TextLength == 0 || lastName.TextLength == 0 || contactNumber.TextLength == 0 || emergencyNumber.TextLength == 0 || newCity.TextLength == 0 || newMunicipality.TextLength == 0 || newBarangay.TextLength == 0 || jobTitle.SelectedIndex == 0 || startShift.SelectedIndex < 1 || endShift.SelectedIndex < 1/*|| fbProfile.TextLength == 0*/)
            {
                MessageBox.Show("Fields with " + "'*'" + " are Required. Please Complete the Form.", "Notice!");
            }
            else if (employeeId == "")
            {
                MessageBox.Show("Employee don't exist, add it", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE employee_fname = @firstName AND employee_lname = @lastName AND employee_id != @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", employeeId);
                cmd.Parameters.AddWithValue("@firstName", firstName.Text);
                cmd.Parameters.AddWithValue("@lastName", lastName.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    MessageBox.Show("Employee with the same name already exist in the System", "Notice!");
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT position_id FROM position WHERE position_desc = @job", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@job", jobTitle.SelectedItem);
                    object id = cmd1.ExecuteScalar();
                    int jID = (id == DBNull.Value) ? 0 : Convert.ToInt32(id);
                    jobID = jID.ToString();
                    dbConnect.CloseConnection();
                    loadAddress();
                    loadShift();
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd4 = new MySqlCommand("UPDATE employee SET employee_fname = @firstName, employee_lname = @lastName, position_id = @JobID, employee_cNumber = @contactNumber, employee_ecNumber = @Enum, shift_id = @shift, address_id = @address WHERE employee_id = @uempid", dbConnect.myconnect);
                    cmd4.Parameters.AddWithValue("@uempid", employeeId);
                    cmd4.Parameters.AddWithValue("@firstName", firstName.Text);
                    cmd4.Parameters.AddWithValue("@lastName", lastName.Text);
                    cmd4.Parameters.AddWithValue("@contactNumber", contactNumber.Text);
                    cmd4.Parameters.AddWithValue("@Enum", emergencyNumber.Text);
                    cmd4.Parameters.AddWithValue("@JobID", jobID);
                    cmd4.Parameters.AddWithValue("@shift", shiftID);
                    cmd4.Parameters.AddWithValue("@address", address);
                    int affectedColumn = cmd4.ExecuteNonQuery();
                    if (affectedColumn != 0)
                    {
                        MessageBox.Show("Employee information updated", "Update successful");
                        firstName.Clear();
                        lastName.Clear();
                        contactNumber.Clear();
                        emergencyNumber.Clear();
                        jobTitle.SelectedIndex = 0;
                        startShift.SelectedIndex = 0;
                        endShift.SelectedIndex = 0;
                        newMunicipality.Clear();
                        newCity.Clear();
                        newBarangay.Clear();
                        loadEmployee();
                        employeeId = "";
                    }
                }
            }
        }
        private void deleteEmp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE employee SET position_id = '6' WHERE employee_id = @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", employeeId);
                int delete = cmd.ExecuteNonQuery();
                if (delete > 0)
                {
                    MessageBox.Show("Employee deleted successfully", "Delete Successful");
                    firstName.Clear();
                    lastName.Clear();
                    contactNumber.Clear();
                    emergencyNumber.Clear();
                    jobTitle.SelectedIndex = 0;
                    startShift.SelectedIndex = 0;
                    endShift.SelectedIndex = 0;
                    newMunicipality.Clear();
                    newCity.Clear();
                    newBarangay.Clear();
                    loadEmployee();
                    employeeId = "";
                }
            }
        }
        #endregion
        #region ADD Payroll
        private void retrieveOTR()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT otRate_id FROM overtime_rate WHERE position_id = @Jid", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@Jid", jobID);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                otrID = myReader["otRate_id"].ToString();
            }
            dbConnect.CloseConnection();
            insertOT();
        }
        private void insertOT()
        {
            DateTime monthyear = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO overtime VALUES('', @otr, @empid, '0', @date, '0'); SELECT LAST_INSERT_ID();", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@otr", otrID);
            cmd.Parameters.AddWithValue("@empid", employeeId);
            cmd.Parameters.AddWithValue("@date", monthyear.ToString("MM-yyyy"));
            object result = cmd.ExecuteScalar();
            int num = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
            otID = num.ToString();
            dbConnect.CloseConnection();
            addPayroll();
        }
        private void addPayroll()
        {
            DateTime monthyear = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO payroll VALUES('', @employee, @otid, @salary, @date)", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@employee", employeeId);
            cmd.Parameters.AddWithValue("@otid", otID);
            cmd.Parameters.AddWithValue("@date", monthyear.ToString("MM-yyyy"));
            cmd.Parameters.AddWithValue("@salary", jobSalary);
            cmd.ExecuteNonQuery();
        }
        #endregion
        #region EDIT Payroll

        #endregion
        #region Overtime
        private void getOT()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd= new MySqlCommand("SELECT employee_id FROM employee", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while(myReader.Read())
            {
                employeeId = myReader["employee_id"].ToString();
                DateTime monthyear = DateTime.Now;
                MySqlCommand cmd1 = new MySqlCommand("SELECT employee_id FROM overtime WHERE overtime.employee_id = @id AND overtime.overtime_date != '07-2024'", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@id", employeeId);
                cmd1.Parameters.AddWithValue("@date", monthyear.ToString("MM-yyyy"));
                myReader1 = cmd1.ExecuteReader();
                if (myReader1.Read())
                {
                    insertOT();
                }
            }
        }
        #endregion
    }
}
