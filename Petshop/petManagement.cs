using MaterialSkin.Controls;
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
    public partial class petManagement : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        string ID;
        public petManagement()
        {
            InitializeComponent();
        }

        private void petManagement_Load(object sender, EventArgs e)
        {
            getpetPrice();
            sizeCb.SelectedIndex = 0;
        }
        private void getpetPrice()
        {
            petDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT pet.pet_type, petsize.pet_size, petsize.ptsize_price FROM pet JOIN petsize ON pet.pet_id = petsize.pet_id WHERE petsize.ptsize_price > '0' ORDER BY pet.pet_type ASC", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            petDgv.DataSource = dt;
            dbConnect.CloseConnection();
        }
        #region CRUD
        private void addPrice_Click(object sender, EventArgs e)
        {
            if(petType.TextLength == 0 || petPrice.TextLength == 0 || sizeCb.SelectedIndex < 1)
            {
                MaterialMessageBox.Show("Pet complete the form", "Notice");
            }
            else
            {
                getPet();
                getPriceInsert();
                getpetPrice();
                petType.Clear();
                petPrice.Clear();
                sizeCb.SelectedIndex = 0;
            }
        }
        private void updatePrice_Click(object sender, EventArgs e)
        {
            if (petType.TextLength == 0 || petPrice.TextLength == 0 || sizeCb.SelectedIndex < 1)
            {
                MaterialMessageBox.Show("Pet complete the form", "Notice");
            }
            else
            {
                getPet();
                getPriceUpdate();
                getpetPrice();
                petType.Clear();
                petPrice.Clear();
                sizeCb.SelectedIndex = 0;
            }
        }
        private void deletePrice_Click(object sender, EventArgs e)
        {
            if (petType.TextLength == 0 || sizeCb.SelectedIndex < 1)
            {
                MaterialMessageBox.Show("Pet complete the form", "Notice");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT pet_id FROM pet WHERE pet_type = @type", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@type", petType.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    ID = myReader["pet_id"].ToString();
                    getPriceDelete();
                    getpetPrice();
                    petType.Clear();
                    petPrice.Clear();
                    sizeCb.SelectedIndex = 0;
                }
                else
                {
                    MaterialMessageBox.Show("Pet type doesn't exist in the system", "Notice");
                }
            }
        }
        #endregion
        #region READ
        private void getPet()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT pet_id FROM pet WHERE pet_type = @type", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@type", petType.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                ID = myReader["pet_id"].ToString();
            }
            else
            {
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO pet VALUES('', @newType); SELECT LAST_INSERT_ID();", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@newType", petType.Text);
                object result = cmd1.ExecuteScalar();
                int num = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                ID = num.ToString();
            }
            dbConnect.CloseConnection();
        }
        private void getPriceInsert()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT ptsize_id, ptsize_price FROM petsize WHERE pet_size = @size AND pet_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@size", sizeCb.SelectedItem);
            cmd.Parameters.AddWithValue("@id", ID);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                string existID = myReader["ptsize_id"].ToString();
                string price = myReader["ptsize_price"].ToString();
                if (price == "0")
                {
                    myReader.Close();
                    MySqlCommand cmd1 = new MySqlCommand("UPDATE petsize SET ptsize_price = @updatePrice WHERE ptsize_id = @existing", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@updatePrice", petPrice.Text);
                    cmd1.Parameters.AddWithValue("@existing", existID);
                    int update = cmd1.ExecuteNonQuery();
                    if (update > 0)
                    {
                        MaterialMessageBox.Show("Price inserted", "Success");
                    }
                }
                else
                {
                    if (MaterialMessageBox.Show("Price for the said size is already set. Update it?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                    {
                        myReader.Close();
                        MySqlCommand cmd1 = new MySqlCommand("UPDATE petsize SET ptsize_price = @updatePrice WHERE ptsize_id = @existing", dbConnect.myconnect);
                        cmd1.Parameters.AddWithValue("@updatePrice", petPrice.Text);
                        cmd1.Parameters.AddWithValue("@existing", existID);
                        int update = cmd1.ExecuteNonQuery();
                        if (update > 0)
                        {
                            MaterialMessageBox.Show("Price updated", "Success");
                        }
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                myReader.Close();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO petsize VALUES('', @newSize, @newPrice, @newID)", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@newSize", sizeCb.SelectedItem);
                cmd1.Parameters.AddWithValue("@newPrice", petPrice.Text);
                cmd1.Parameters.AddWithValue("@newID", ID);
                int insert = cmd1.ExecuteNonQuery();
                if(insert > 0)
                {
                    MaterialMessageBox.Show("Price inserted", "Success");
                }
            }
        }
        private void getPriceUpdate()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT ptsize_id FROM petsize WHERE pet_size = @size AND pet_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@size", sizeCb.SelectedItem);
            cmd.Parameters.AddWithValue("@id", ID);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                string existID = myReader["ptsize_id"].ToString();
                myReader.Close();
                MySqlCommand cmd1 = new MySqlCommand("UPDATE petsize SET ptsize_price = @updatePrice WHERE ptsize_id = @existing", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@updatePrice", petPrice.Text);
                cmd1.Parameters.AddWithValue("@existing", existID);
                int update = cmd1.ExecuteNonQuery();
                if (update > 0)
                {
                    MaterialMessageBox.Show("Price updated", "Success");
                }
            }
            else
            {
                if (MaterialMessageBox.Show("Price for the said size is not set yet. Insert it?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                {
                    myReader.Close();
                    MySqlCommand cmd1 = new MySqlCommand("INSERT INTO petsize VALUES('', @newSize, @newPrice, @newID)", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@newSize", sizeCb.SelectedItem);
                    cmd1.Parameters.AddWithValue("@newPrice", petPrice.Text);
                    cmd1.Parameters.AddWithValue("@newID", ID);
                    int insert = cmd1.ExecuteNonQuery();
                    if (insert > 0)
                    {
                        MaterialMessageBox.Show("Price inserted", "Success");
                    }
                }
            }
        }
        private void getPriceDelete()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT ptsize_id FROM petsize WHERE pet_size = @size AND pet_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@size", sizeCb.SelectedItem);
            cmd.Parameters.AddWithValue("@id", ID);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                string existID = myReader["ptsize_id"].ToString();
                if (MaterialMessageBox.Show("Are you sure you want to delete this pet size?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                {
                    myReader.Close();
                    MySqlCommand cmd1 = new MySqlCommand("UPDATE petsize SET ptsize_price = '0' WHERE ptsize_id = @existing", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@updatePrice", petPrice.Text);
                    cmd1.Parameters.AddWithValue("@existing", existID);
                    int delete = cmd1.ExecuteNonQuery();
                    if (delete > 0)
                    {
                        MaterialMessageBox.Show("Size deleted", "Success");
                    }
                }
            }
        }
        #endregion

        private void petDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            petType.Text = petDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            sizeCb.SelectedItem = petDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            petPrice.Text = petDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            petType.ResetText();
            petPrice.ResetText();
            sizeCb.SelectedIndex = 0;
        }
    }
}
