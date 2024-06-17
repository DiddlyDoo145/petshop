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
        string petID;
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
            mySqlDataAdapter = new MySqlDataAdapter("SELECT service_id, service_name, service_price, pet_type, pet_size, strCategory_desc FROM services JOIN pet ON services.pet_id = pet.pet_id JOIN storecategory ON services.strCategory_id = storecategory.strCategory_id WHERE service_price > 0", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ServicesTable.DataSource = dt;
            ServicesTable.Columns[0].Visible = false;

        }

        private void Services_Load(object sender, EventArgs e)
        {
            serviceID = "";
            petType.SelectedIndex = 0;
            petSize.SelectedIndex = 0;

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pet_type FROM pet", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["pet_type"].ToString();

                if (!petType.Items.Contains(itemName))
                {
                    petType.Items.Add(itemName);

                }
            }
        }

        private void petType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pet_id FROM pet WHERE pet_type = @ptnm", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@ptnm", petType.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                petID = myReader["pet_id"].ToString();
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(serviceName.Text.Trim()))
            {
                errorProvider1.SetError(serviceName, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(serviceName, string.Empty);
            }
            if (petType.Text == "SELECT CATEGORY")
            {
                errorProvider2.SetError(petType, "Please Input this field");
                return;
            }
            else
            {
                errorProvider2.SetError(petType, string.Empty);
            }
            if (petSize.Text == "SELECT CATEGORY")
            {
                errorProvider3.SetError(petSize, "Please Input this field");
                return;
            }
            else
            {
                errorProvider3.SetError(petSize, string.Empty);
            }
            if (string.IsNullOrEmpty(servicePrice.Text.Trim()))
            {
                errorProvider4.SetError(servicePrice, "Please Input this field");
                return;
            }
            else
            {
                errorProvider4.SetError(servicePrice, string.Empty);
            }
          
          

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM services WHERE service_name = @uname  AND pet_id = @uids AND pet_size = @pSe AND service_price = 0", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@uids", petID);
            cmd.Parameters.AddWithValue("@pSe", petSize.Text);
            cmd.Parameters.AddWithValue("@uname", serviceName.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE services SET service_price = @usprice WHERE service_name = @un AND pet_id = @uid AND pet_size = @pS  AND service_price = 0", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@uid", petID);
                cmd.Parameters.AddWithValue("@pS", petSize.Text);
                cmd.Parameters.AddWithValue("@un", serviceName.Text);
                cmd.Parameters.AddWithValue("@usprice", servicePrice.Text);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("New Service Added Successfully", "Success");
                populategv();
                serviceName.Clear();
                servicePrice.Clear();
                petType.SelectedIndex = 0;
                petSize.SelectedIndex = 0;
                serviceID = "";
                return;
            }
            else
            {

                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT * FROM services WHERE service_name = @Sname", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@Sname", serviceName.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read() == true)
                {
                    MaterialMessageBox.Show("Service Already Exist", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    serviceName.Clear();
                    servicePrice.Clear();
                    serviceID = "";
                }
                else
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("INSERT INTO services (service_name, service_price, pet_id, pet_size, strCategory_id) VALUES (@Sname, @servicePrice, @pID, @ptS, '2')", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@Sname", serviceName.Text);
                    cmd.Parameters.AddWithValue("@servicePrice", servicePrice.Text);
                    cmd.Parameters.AddWithValue("@pID", petID);
                    cmd.Parameters.AddWithValue("@ptS", petSize.Text);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("New Service Added Successfully", "Success");
                    populategv();
                    serviceName.Clear();
                    servicePrice.Clear();
                    petType.SelectedIndex = 0;
                    petSize.SelectedIndex = 0;
                    serviceID = "";
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
                serviceName.Text = ServicesTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                servicePrice.Text = ServicesTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                petType.Text = ServicesTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                petSize.Text = ServicesTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (serviceName.Text == "")
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
            if (serviceID != "")
            {

                if (MaterialMessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE services SET service_name = @n, service_price = @p, pet_id = @pid, pet_size = @psize  WHERE service_id = @ID", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@ID", serviceID);
                    cmd.Parameters.AddWithValue("@n", serviceName.Text);
                    cmd.Parameters.AddWithValue("@p", servicePrice.Text);
                    cmd.Parameters.AddWithValue("@pid", petID);
                    cmd.Parameters.AddWithValue("@psize", petSize.Text);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("Updated Successfully", "Success");
                    populategv();
                    serviceName.Clear();
                    servicePrice.Clear();
                    petType.SelectedIndex = 0;
                    petSize.SelectedIndex = 0;
                    serviceID = "";
                }
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
                serviceName.Clear();
                servicePrice.Clear();
                petType.SelectedIndex = 0;
                petSize.SelectedIndex = 0;
                serviceID = "";
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT service_id, service_name, service_price, pet_type, pet_size, strCategory_desc FROM services JOIN pet ON services.pet_id = pet.pet_id JOIN storecategory ON services.strCategory_id = storecategory.strCategory_id WHERE service_name LIKE '%" + search.Text + "%' AND service_price > 0 OR pet_type LIKE '%"+search.Text+ "%' AND service_price > 0 OR pet_size LIKE '%"+search.Text+ "%' AND service_price > 0 OR strCategory_desc LIKE '%" + search.Text + "%' AND service_price > 0", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ServicesTable.DataSource = dt;
            ServicesTable.Columns[0].Visible = false;

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            serviceName.Clear();
            servicePrice.Clear();
            serviceID = "";
            petType.SelectedIndex = 0;
            petSize.SelectedIndex = 0;
            populategv();
        }

        private void servicename_TextChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT service_id FROM services WHERE service_name = @UN", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@UN", serviceName.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                serviceID = myReader["service_id"].ToString();

            }
        }

      
    }
}
