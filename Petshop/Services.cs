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
            mySqlDataAdapter = new MySqlDataAdapter("SELECT service_id, service_name, service_price, sCategory_name, strCategory_desc, pet_type, room_size FROM services JOIN servicescategory ON services.sCategory_id = servicescategory.sCategory_id JOIN storecategory ON services.strCategory_id = storecategory.strCategory_id JOIN pet ON services.pet_id = pet.pet_id JOIN room ON services.room_id = room.room_id JOIN roomdesc ON room.desc_id = roomdesc.desc_id", dbConnect.myconnect);
            
            mySqlDataAdapter.Fill(dt);
            ServicesTable.DataSource = dt;
            ServicesTable.Columns[0].Visible = false;
           
        }

        private void Services_Load(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT sCategory_name FROM servicescategory", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["sCategory_name"].ToString();

                if (!serviceCategory.Items.Contains(itemName))
                {
                    serviceCategory.Items.Add(itemName);

                }
            }
           
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pet_type FROM pet", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["pet_type"].ToString();

                if (!pet.Items.Contains(itemName))
                {
                    pet.Items.Add(itemName);

                }
            }
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT room_size FROM roomdesc JOIN room ON roomdesc.desc_id = room.desc_id", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["room_size"].ToString();

                if (!room.Items.Contains(itemName))
                {
                    room.Items.Add(itemName);

                }
            }
            serviceCategory.SelectedIndex = 0;
            pet.SelectedIndex = 0;
            room.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pet_id FROM pet WHERE pet_type = '"+pet.Text+"'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                pet_ID.Text = myReader["pet_id"].ToString();
            }
        }

      

        private void serviceCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT sCategory_id FROM servicescategory WHERE sCategory_name = '"+serviceCategory.Text+"'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                serviceCategory_ID.Text = myReader["sCategory_id"].ToString();
            }
        }

        private void room_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT room_id FROM room JOIN roomdesc ON room.desc_id = roomdesc.desc_id WHERE room_size = '"+room.Text+"'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if ( myReader.Read() == true)
            {
                room_ID.Text = myReader["room_id"].ToString();
            }
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
            if (serviceCategory.Text == "SELECT CATEGORY")
            {
                errorProvider3.SetError(serviceCategory, "Please Input this field");
                return;
            }
            else
            {
                errorProvider3.SetError(serviceCategory, string.Empty);
            }
            if (pet.Text == "SELECT CATEGORY")
            {
                errorProvider4.SetError(pet, "Please Input this field");
                return;
            }
            else
            {
                errorProvider4.SetError(pet, string.Empty);
            }
            if (room.Text == "SELECT CATEGORY")
            {
                errorProvider5.SetError(room, "Please Input this field");
                return;
            }
            else
            {
                errorProvider5.SetError(room, string.Empty);
            }

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("INSERT INTO services (service_name, service_price, sCategory_id, strCategory_id, pet_id, room_id) VALUES (@Sname, @Sprice, @scID, '2', @pID, @rmID)", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@Sname", servicename.Text);
            cmd.Parameters.AddWithValue("@Sprice", SPrice.Text);
            cmd.Parameters.AddWithValue("@scID", serviceCategory_ID.Text);
            cmd.Parameters.AddWithValue("@pID", pet_ID.Text);
            cmd.Parameters.AddWithValue("@rmID", room_ID.Text);
            cmd.ExecuteNonQuery();
            MaterialMessageBox.Show("New Services Added Successfully", "Success");
            populategv();
            servicename.Clear();
            SPrice.Clear();
            serviceCategory_ID.ResetText();
            pet_ID.ResetText();
            room_ID.ResetText();
            serviceCategory.SelectedIndex = 0;
            pet.SelectedIndex = 0;
            room.SelectedIndex = 0;
            Key = 0;
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

            servicename.Text = ServicesTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            SPrice.Text = ServicesTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            serviceCategory.Text = ServicesTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            pet.Text = ServicesTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            room.Text = ServicesTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (servicename.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ServicesTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MaterialMessageBox.Show("Please Select Data to Update", "Notice!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
           else if (MaterialMessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE services SET service_name = @n, service_price = @p, sCategory_id = @SID, pet_id = @petID, room_id = @rmID WHERE service_id = @ID", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@ID", Key);
                cmd.Parameters.AddWithValue("@n", servicename.Text);
                cmd.Parameters.AddWithValue("@p", SPrice.Text);
                cmd.Parameters.AddWithValue("@SID", serviceCategory_ID.Text);
                cmd.Parameters.AddWithValue("@petID", pet_ID.Text);
                cmd.Parameters.AddWithValue("@rmID", room_ID.Text);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Updated Successfully", "Success");
                populategv();
                servicename.Clear();
                SPrice.Clear();
                serviceCategory_ID.ResetText();
                pet_ID.ResetText();
                room_ID.ResetText();
                service_ID.ResetText();
                serviceCategory.SelectedIndex = 0;
                pet.SelectedIndex = 0;
                room.SelectedIndex = 0;
                Key = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MaterialMessageBox.Show("Please Select Data to Delete", "Notice!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MaterialMessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("DELETE FROM services WHERE service_ID = @seID", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@seID", Key);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Deleted Successfully", "Success");
                populategv();
                servicename.Clear();
                SPrice.Clear();
                serviceCategory_ID.ResetText();
                pet_ID.ResetText();
                room_ID.ResetText();
                service_ID.ResetText();
                serviceCategory.SelectedIndex = 0;
                pet.SelectedIndex = 0;
                room.SelectedIndex = 0;
                Key = 0;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT service_id, service_name, service_price, sCategory_name, strCategory_desc, pet_type, room_size FROM services JOIN servicescategory ON services.sCategory_id = servicescategory.sCategory_id JOIN storecategory ON services.strCategory_id = storecategory.strCategory_id JOIN pet ON services.pet_id = pet.pet_id JOIN room ON services.room_id = room.room_id JOIN roomdesc ON room.desc_id = roomdesc.desc_id WHERE service_name LIKE '%"+search.Text+ "%' OR sCategory_name LIKE '%"+search.Text+ "' OR strCategory_desc LIKE '%"+search.Text+ "%' OR pet_type LIKE '%"+search.Text+"%' OR room_size LIKE '%"+search.Text+"%'", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ServicesTable.DataSource = dt;
            ServicesTable.Columns[0].Visible = false;
          
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            servicename.Clear();
            SPrice.Clear();
            serviceCategory_ID.ResetText();
            pet_ID.ResetText();
            room_ID.ResetText();
            Key = 0;
            serviceCategory.SelectedIndex = 0;
            pet.SelectedIndex = 0;
            room.SelectedIndex = 0;
        }
      
    }
}
