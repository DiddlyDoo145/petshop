using MaterialSkin.Controls;
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
    public partial class empOt : Form
    {
        private Conclass dbConnect;
        private MySqlDataReader myReader, myReader1, myReader2;
        private string jobid;
        public empOt()
        {
            InitializeComponent();
        }

        private void jobTitle_TextChanged(object sender, EventArgs e)
        {
            searchJob();
        }

        private void empOt_Load(object sender, EventArgs e)
        {
            OTRate();
        }
        #region load Data
        private void OTRate()
        {
            otDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT overtime_rate.otRate_id, position.position_desc, overtime_rate.otRate_pay, COUNT(employee.employee_id) AS Total_Employee FROM position LEFT JOIN employee ON position.position_id = employee.position_id LEFT JOIN overtime_rate ON position.position_id = overtime_rate.position_id WHERE position.position_desc != 'N/A' GROUP BY position.position_desc, overtime_rate.otRate_pay, overtime_rate.otRate_id", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            otDgv.DataSource = dt;
            dbConnect.CloseConnection();
        }
        private void searchJob()
        {
            otDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT overtime_rate.otRate_id, position.position_desc, overtime_rate.otRate_pay, COUNT(employee.employee_id) AS Total_Employee FROM position LEFT JOIN employee ON position.position_id = employee.position_id LEFT JOIN overtime_rate ON position.position_id = overtime_rate.position_id WHERE position.position_desc != 'N/A' AND CONCAT (position.position_desc) LIKE @item GROUP BY position.position_desc, overtime_rate.otRate_pay, overtime_rate.otRate_id ", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@item", "%" + jobTitle.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            otDgv.DataSource = dt;
            dbConnect.CloseConnection();
        }
        private void loadJob()
        {
            string name = otDgv.Rows[0].Cells[1].Value.ToString();
            string id = otDgv.Rows[0].Cells[0].Value.ToString();
            if (id == "")
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT position_id FROM position WHERE position_desc = @name", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@name", name);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    jobid = myReader["position_id"].ToString();
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO overtime_rate VALUES('', @rate, @job)", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@rate", otPay.Text);
                    cmd1.Parameters.AddWithValue("@job", jobid);
                    int insert = cmd1.ExecuteNonQuery();
                    if (insert > 0)
                    {
                        MaterialMessageBox.Show("Overtime pay inserted", "Added OT Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                dbConnect.CloseConnection();
                OTRate();
                otPay.Clear();
                jobTitle.Clear();
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE overtime_rate SET otRate_pay = @pay WHERE otRate_id = @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@pay", otPay.Text);
                cmd.Parameters.AddWithValue("@id", id);
                int update = cmd.ExecuteNonQuery();
                if(update > 0)
                {
                    MaterialMessageBox.Show("Overtime pay updated", "Updated OT Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                OTRate();
                otPay.Clear();
                jobTitle.Clear();
            }
        }
        #endregion
        private void payBtn_Click(object sender, EventArgs e)
        {
            if (jobTitle.TextLength == 0)
            {
                MaterialMessageBox.Show("Please choose a job title to set overtime pay", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (jobTitle.TextLength > 0 && otDgv.Rows.Count != 1)
            {
                MaterialMessageBox.Show("Please choose a specific job title to set overtime pay", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (jobTitle.TextLength > 0 && otDgv.Rows.Count == 1 && otPay.TextLength == 0)
            {
                MaterialMessageBox.Show("Please set an overtime pay", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                loadJob();
            }
        }
    }
}
