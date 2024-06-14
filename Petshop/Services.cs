using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
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
    public partial class Services : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        string serviceID;
        public Services()
        {
            InitializeComponent();
            populategv();
        }

        private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT service_id, service_name, service_price, strCategory_desc FROM services JOIN storecategory ON services.strCategory_id = storecategory.strCategory_id WHERE service_price > 0", dbConnect.myconnect); 
            mySqlDataAdapter.Fill(dt);
            ServicesTable.DataSource = dt;
            ServicesTable.Columns[0].Visible = false;
           
        }

        private void Services_Load(object sender, EventArgs e)
        {
         
        }

      
      

      

      
        private void AddProduct_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(servicename.Text.Trim()))
            {
                errorProvider1.SetError(servicename, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(servicename, string.Empty);
            }
            if (string.IsNullOrEmpty(SPrice.Text.Trim()))
            {
                errorProvider2.SetError(SPrice, "Please Input this field");
                return;
            }
            else
            {
                errorProvider2.SetError(SPrice, string.Empty);
            }

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM services WHERE service_name = @uname AND service_price = 0", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@uname", servicename.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE services SET service_price = @usprice WHERE service_name = @un AND service_price = 0", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@un", servicename.Text);
                cmd.Parameters.AddWithValue("@usprice", SPrice.Text);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("New Service Added Successfully", "Success");
                populategv();
                servicename.Clear();
                SPrice.Clear();
                Key = 0;
                return;
            }
            else
            {

                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT * FROM services WHERE service_name = @Sname", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@Sname", servicename.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read() == true)
                {
                    MaterialMessageBox.Show("Service Already Exist", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    servicename.Clear();
                    SPrice.Clear();
                    Key = 0;
                }
                else
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("INSERT INTO services (service_name, service_price, strCategory_id) VALUES (@Sname, @Sprice, '2')", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@Sname", servicename.Text);
                    cmd.Parameters.AddWithValue("@Sprice", SPrice.Text);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("New Service Added Successfully", "Success");
                    populategv();
                    servicename.Clear();
                    SPrice.Clear();
                    Key = 0;
                }

            }

        }

        private void SPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        int Key = 0;
        private void ServicesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                servicename.Text = ServicesTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                SPrice.Text = ServicesTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (servicename.Text == "")
                {
                    serviceID = "";
                }
                else
                {
                    serviceID = ServicesTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if(serviceID == "")
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT service_id FROM services WHERE service_name = @UN", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@UN", servicename.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read() == true)
                {
                    serviceID = myReader["service_id"].ToString();
                    
                }
            }     
              if (MaterialMessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE services SET service_name = @n, service_price = @p WHERE service_id = @ID", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@ID", serviceID);
                    cmd.Parameters.AddWithValue("@n", servicename.Text);
                    cmd.Parameters.AddWithValue("@p", SPrice.Text);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("Updated Successfully", "Success");
                    populategv();
                    servicename.Clear();
                    SPrice.Clear();
                    Key = 0;
                }
            
            else
            {
                MaterialMessageBox.Show("Please Select Data to Update", "Notice!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serviceID == "")
            {
                MaterialMessageBox.Show("Please Select Data to Delete", "Notice!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MaterialMessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE services SET service_price = 0 WHERE service_ID = @seID", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@seID", serviceID);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Deleted Successfully", "Success");
                populategv();
                servicename.Clear();
                SPrice.Clear();
                Key = 0;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT service_id, service_name, service_price, strCategory_desc FROM services JOIN storecategory ON services.strCategory_id = storecategory.strCategory_id WHERE service_name LIKE '%"+search.Text+ "%' AND service_price > 0 OR strCategory_desc LIKE '%" + search.Text+ "%' AND service_price > 0", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ServicesTable.DataSource = dt;
            ServicesTable.Columns[0].Visible = false;
          
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            servicename.Clear();
            SPrice.Clear();
            Key = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
