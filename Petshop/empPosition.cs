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
    public partial class empPosition : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader, myReader1, myReader2;
        private string jobid;
        public empPosition()
        {
            InitializeComponent();
        }

        private void empPosition_Load(object sender, EventArgs e)
        {
            jobList();
            jobid = "";
        }
        
        private void jobDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {

            }
            else
            {
                jobid = jobDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                jobTitle.Text = jobDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                jobSalary.Text = jobDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            jobid = "";
            jobTitle.Clear();
            jobSalary.Clear();
        }

        private void jobList()
        {
            jobDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT position_id, position_desc, position_salary FROM position WHERE position_desc != 'N/A'", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            jobDgv.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            jobDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT position_id, position_desc, position_salary FROM position WHERE CONCAT (position_desc) LIKE @item AND position_desc != 'N/A'", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@item", "%" + jobSearchBox.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            if(dt.Rows.Count == 0)
            {

            }
            else
            {
                da.Fill(dt);
                jobDgv.DataSource = dt;
            }
            dbConnect.CloseConnection();
        }
        private void changePosition()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE employee SET position_id = '6' WHERE position_id = @jobID", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@jobID", jobid);
            cmd.ExecuteNonQuery();
            dbConnect.CloseConnection();
        }
        private void deleteOT()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("UPDATE overtime_rate SET position_id = '6', otRate_pay = '0' WHERE position_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", jobid);
            cmd.ExecuteNonQuery();
            dbConnect.CloseConnection();
        }
        #region CRUD
        private void addJobBtn_Click(object sender, EventArgs e)
        {
            if(jobTitle.TextLength == 0 || jobSalary.TextLength == 0)
            {
                MessageBox.Show("Please complete the form", "Notice!");
            }
            else
            {
                if (jobid == "")
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("SELECT position_id FROM position WHERE position_desc = @title", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@title", jobTitle.Text);
                    myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        MessageBox.Show("Job already exist", "Existing Job");
                        dbConnect.CloseConnection();
                    }
                    else
                    {
                        dbConnect.CloseConnection();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd1 = new MySqlCommand("INSERT INTO position VALUES('', @title, @salary)", dbConnect.myconnect);
                        cmd1.Parameters.AddWithValue("@title", jobTitle.Text);
                        cmd1.Parameters.AddWithValue("@salary", jobSalary.Text);
                        int insert = cmd1.ExecuteNonQuery();
                        if (insert > 0)
                        {
                            MessageBox.Show("Job inserted successfully", "Success!");
                        }
                        dbConnect.CloseConnection();
                        jobTitle.Clear();
                        jobSalary.Clear();
                        jobList();
                    }
                }
                else
                {
                    MessageBox.Show("Product already exist, update it", "Notice");
                }
            }
        }

        private void updateJobBtn_Click(object sender, EventArgs e)
        {
            if (jobTitle.TextLength == 0 || jobSalary.TextLength == 0)
            {
                MessageBox.Show("Please complete the form", "Notice!");
            }
            else
            {
                if (jobid == "")
                {
                    MessageBox.Show("Product doesn't exist in the system, add it", "Notice!");
                }
                else
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("SELECT position_desc FROM position WHERE position_desc = @title AND position_id != @id", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@title", jobTitle.Text);
                    cmd.Parameters.AddWithValue("@id", jobid);
                    myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        MessageBox.Show("A position with the same title already exist", "Notice!");
                    }
                    else
                    {
                        dbConnect.CloseConnection();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd1 = new MySqlCommand("UPDATE position SET position_desc = @utitle, position_salary = @usalary WHERE position_id = @uid", dbConnect.myconnect);
                        cmd1.Parameters.AddWithValue("@uid", jobid);
                        cmd1.Parameters.AddWithValue("@utitle", jobTitle.Text);
                        cmd1.Parameters.AddWithValue("@usalary", jobSalary.Text);
                        int update = cmd1.ExecuteNonQuery();
                        if (update > 0)
                        {
                            MessageBox.Show("Position updated successfully", "Update Successful");
                            dbConnect.CloseConnection();
                            jobList();
                            jobTitle.Clear();
                            jobSalary.Clear();
                            jobid = "";
                        }
                    }
                }
            }
        }
        private void deleteJobBtn_Click(object sender, EventArgs e)
        {
            if(jobid == "")
            {
                MessageBox.Show("Select a job to delete", "Notice!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this job title?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("All employee under this title will be labeled N/A. Proceed?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        changePosition();
                        deleteOT();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM position WHERE position_id = @id", dbConnect.myconnect);
                        cmd.Parameters.AddWithValue("@id", jobid);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Job successfully deleted", "Delete successful");
                        jobTitle.Clear();
                        jobSalary.Clear();
                        dbConnect.CloseConnection();
                        jobList();
                    }
                }
            }
        }
        #endregion
    }
}
