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
    public partial class empManage : Form
    {
        string imagelocation = "";
        string jobID, address;
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader, myReader1, myReader2;
        private string employeeId;
        private void empManage_Load(object sender, EventArgs e)
        {
            jobList();
            loadEmployee();
            jobTitle.SelectedIndex = 0;
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
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_id, position.position_desc, employee.employee_fname, employee.employee_lname, employee.employee_cNumber, employee.employee_ecNumber FROM employee RIGHT JOIN position ON employee.position_id = position.position_id WHERE employee.employee_id > '0'", dbConnect.myconnect);
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
            cmd2.Parameters.AddWithValue("@city", addCity.Text);
            cmd2.Parameters.AddWithValue("@municipality", addMuni.Text);
            cmd2.Parameters.AddWithValue("@brgy", addBrgy.Text);
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
                cmd3.Parameters.AddWithValue("@newCity", addCity.Text);
                cmd3.Parameters.AddWithValue("@newMuni", addMuni.Text);
                cmd3.Parameters.AddWithValue("@newBrgy", addBrgy.Text);
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
                    addCity.Text = myReader1["address_city"].ToString();
                    addMuni.Text = myReader1["address_muni"].ToString();
                    addBrgy.Text = myReader1["address_brgy"].ToString();
                }
            }
        }
        #endregion

        private void employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeId = employees.Rows[e.RowIndex].Cells[0].Value.ToString();
            jobTitle.SelectedItem = employees.Rows[e.RowIndex].Cells[1].Value.ToString();
            fName.Text = employees.Rows[e.RowIndex].Cells[2].Value.ToString();
            sName.Text = employees.Rows[e.RowIndex].Cells[3].Value.ToString();
            cNum.Text = employees.Rows[e.RowIndex].Cells[4].Value.ToString();
            eCnum.Text = employees.Rows[e.RowIndex].Cells[5].Value.ToString();
            retrieveAddress();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fName.Clear();
            sName.Clear();
            cNum.Clear();
            eCnum.Clear();
            jobTitle.SelectedIndex = 0;
            addBrgy.Clear();
            addCity.Clear();
            addMuni.Clear();
            employeeId = "";
        }

        #region CRUD
        #region img
        /*        private void addImg_Click(object sender, EventArgs e)
                {
                    OpenFileDialog openfd = new OpenFileDialog();
                    openfd.Filter = "Select Image(*.jpg; *.jpeg; *.gif;) | *.jpg; *.jpeg; *.gif;";
                    if (openfd.ShowDialog() == DialogResult.OK)
                    {
                        imagelocation = openfd.FileName.ToString();
                        empImg.ImageLocation = imagelocation;
                    }
                }*/
        #endregion
        private void empSearch_Click(object sender, EventArgs e)
        {
            employees.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee.employee_id, position.position_desc, employee.employee_fname, employee.employee_lname, employee.employee_cNumber, employee.employee_ecNumber FROM employee RIGHT JOIN position ON employee.position_id = position.position_id WHERE employee.employee_id > '0' AND CONCAT (employee.employee_fname, employee.employee_lname, position.position_desc) LIKE @item", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@item", "%" + empSearchBox.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            employees.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            if (fName.TextLength == 0 || sName.TextLength == 0 || cNum.TextLength == 0 || eCnum.TextLength == 0 || addCity.TextLength == 0 || addMuni.TextLength == 0 || addBrgy.TextLength == 0 || jobTitle.SelectedIndex == 0 /*|| fbProfile.TextLength == 0*/)
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE employee_fname = @fname AND employee_lname = @sname", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@fname", fName.Text);
                cmd.Parameters.AddWithValue("@sname", sName.Text);
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
                    MySqlCommand cmd1 = new MySqlCommand("SELECT position_id FROM position WHERE position_desc = @job", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@job", jobTitle.SelectedItem);
                    object id = cmd1.ExecuteScalar();
                    int jID = (id == DBNull.Value) ? 0 : Convert.ToInt32(id);
                    jobID = jID.ToString();
                    dbConnect.CloseConnection();
                    loadAddress();
                    /*                    int age = DateTime.Today.Year - bDate.Value.Year;*/
                    /*                    MessageBox.Show("" + age);*/
                    /*                    if (imagelocation == "")
                                        {*/
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd4 = new MySqlCommand("INSERT INTO employee(employee_id, employee_fname, employee_lname, employee_cNumber, employee_ecNumber, position_id, address_id) VALUES('', @Fname, @Sname, @Cnum, @Enum, @JobID, @address)", dbConnect.myconnect);
                    cmd4.Parameters.AddWithValue("@Fname", fName.Text);
                    cmd4.Parameters.AddWithValue("@Sname", sName.Text);
                    cmd4.Parameters.AddWithValue("@Cnum", cNum.Text);
                    cmd4.Parameters.AddWithValue("@Enum", eCnum.Text);
                    cmd4.Parameters.AddWithValue("@JobID", jobID);
                    cmd4.Parameters.AddWithValue("@address", address);
                    int affectedColumn = cmd4.ExecuteNonQuery();
                    if (affectedColumn != 0)
                    {
                        MessageBox.Show("New Employee Added Sucessfully");
                        fName.Clear();
                        sName.Clear();
                        cNum.Clear();
                        eCnum.Clear();
                        jobTitle.SelectedIndex = 0;
                        addMuni.Clear();
                        addCity.Clear();
                        addBrgy.Clear();
                        loadEmployee();
                    }
                    #region img1
                    /*                    }*/
                    /*                    else
                                        {
                                            byte[] img = null;
                                            FileStream Stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
                                            BinaryReader brs = new BinaryReader(Stream);
                                            img = brs.ReadBytes((int)Stream.Length);
                                            dbConnect.CloseConnection();
                                            dbConnect = new Conclass();
                                            dbConnect.OpenConnection();
                                            MySqlCommand cmd4 = new MySqlCommand("INSERT INTO employee VALUES('', @Img,@Fname, @Cnum, @Enum, @Fb, @Age, @Bdate, @JobID, @address)", dbConnect.myconnect);
                                            cmd4.Parameters.AddWithValue("@Img", img);
                                            cmd4.Parameters.AddWithValue("@Fname", fName.Text);
                                            cmd4.Parameters.AddWithValue("@Mname", mName.Text);
                                            cmd4.Parameters.AddWithValue("@Sname", sName.Text);
                                            cmd4.Parameters.AddWithValue("@Cnum", cNum.Text);
                                            cmd4.Parameters.AddWithValue("@Enum", eCnum.Text);
                                            cmd4.Parameters.AddWithValue("@Fb", fbProfile.Text);
                                            cmd4.Parameters.AddWithValue("@Age", age);
                                            cmd4.Parameters.AddWithValue("@Bdate", bDate.Value.ToString("yyyy-MM-dd"));
                                            cmd4.Parameters.AddWithValue("@JobID", jobID);
                                            cmd4.Parameters.AddWithValue("@address", address);
                                            int affectedColumn = cmd4.ExecuteNonQuery();
                                            if (affectedColumn != 0)
                                            {
                                                MessageBox.Show("New Employee Added Sucessfully");
                                            }
                                        }*/
                    #endregion
                }
            }
        }
        private void updateEmp_Click(object sender, EventArgs e)
        {
            if (fName.TextLength == 0 || sName.TextLength == 0 || cNum.TextLength == 0 || eCnum.TextLength == 0 || addCity.TextLength == 0 || addMuni.TextLength == 0 || addBrgy.TextLength == 0 || jobTitle.SelectedIndex == 0 /*|| fbProfile.TextLength == 0*/)
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE employee_fname = @fname AND employee_lname = @sname AND employee_id != @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", employeeId);
                cmd.Parameters.AddWithValue("@fname", fName.Text);
                cmd.Parameters.AddWithValue("@sname", sName.Text);
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
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd4 = new MySqlCommand("UPDATE employee SET employee_fname = @Fname, employee_lname = @Sname, position_id = @JobID, employee_cNumber = @Cnum, employee_ecNumber = @Enum, address_id = @address WHERE employee_id = @uempid", dbConnect.myconnect);
                    cmd4.Parameters.AddWithValue("@uempid", employeeId);
                    cmd4.Parameters.AddWithValue("@Fname", fName.Text);
                    cmd4.Parameters.AddWithValue("@Sname", sName.Text);
                    cmd4.Parameters.AddWithValue("@Cnum", cNum.Text);
                    cmd4.Parameters.AddWithValue("@Enum", eCnum.Text);
                    cmd4.Parameters.AddWithValue("@JobID", jobID);
                    cmd4.Parameters.AddWithValue("@address", address);
                    int affectedColumn = cmd4.ExecuteNonQuery();
                    if (affectedColumn != 0)
                    {
                        MessageBox.Show("Employee information updated", "Update successful");
                        fName.Clear();
                        sName.Clear();
                        cNum.Clear();
                        eCnum.Clear();
                        jobTitle.SelectedIndex = 0;
                        addMuni.Clear();
                        addCity.Clear();
                        addBrgy.Clear();
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM employee WHERE employee_id = @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", employeeId);
                int delete = cmd.ExecuteNonQuery();
                if (delete > 0)
                {
                    MessageBox.Show("Employee deleted successfully", "Delete Successful");
                    fName.Clear();
                    sName.Clear();
                    cNum.Clear();
                    eCnum.Clear();
                    jobTitle.SelectedIndex = 0;
                    addMuni.Clear();
                    addCity.Clear();
                    addBrgy.Clear();
                    loadEmployee();
                    employeeId = "";
                }
            }
        }
        #endregion
    }
}
