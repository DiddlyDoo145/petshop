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
        public Employee()
        {


            InitializeComponent();

        }
        private void DisplayEmployees()
        {
            
            dbConnect = new Conclass();
            dbConnect.OpenConnection();

            string Query = "SELECT * FROM Employees";
            MySqlDataAdapter sda = new MySqlDataAdapter(Query, Con);



            EmployeeDGV.DataSource = ds.Tables[0];
            string Query = "SELECT * FROM employees";
            dbConnect.CloseConnection();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (EmpNameTxt.Text == "" || EmpAddressTxt.Text == "" || EmpPhoneTxt.Text == "" || EmpPasswordTxt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("INSERT INTO employees (EmpName, EmpAddress, EmpDOB, EmpPhone, EmpPass) values(@EN, @EA, @ED, @EP, @EPa)", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@EN", EmpNameTxt.Text);
                    cmd.Parameters.AddWithValue("@EA", EmpAddressTxt.Text);
                    cmd.Parameters.AddWithValue("@ED", EmpDOBdtp.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", EmpPhoneTxt.Text);
                    cmd.Parameters.AddWithValue("@EPa", EmpPasswordTxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    dbConnect.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
