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
using System.Windows.Forms.DataVisualization.Charting;

namespace Petshop
{
    public partial class ServiceTransac : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        string petID;
        string serviceID;
        string employeeID;
        string serviceName;
        string StID;
        public ServiceTransac()
        {
            InitializeComponent();
            populategv();
        }

        private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT  sTransac_id, Owner, pet_type, service_name, petSize, servicetype, sTransac_total, employee_fname, date FROM servicetransaction JOIN pet ON servicetransaction.pet_id = pet.pet_id JOIN services ON servicetransaction.service_id = services.service_id JOIN employee ON servicetransaction.employee_id = employee.employee_id WHERE sTransac_total > 0", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            serviceTtble.DataSource = dt;
            serviceTtble.Columns[0].Visible = false;
            dbConnect.CloseConnection();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(owner.Text.Trim()))
            {
                errorProvider1.SetError(owner, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(owner, string.Empty);
            }
            if (pettype.SelectedIndex == 0)
            {
                errorProvider2.SetError(pettype, "Please Pet");
                return;
            }
            else
            {
                errorProvider2.SetError(pettype, string.Empty);
            }
            if (ServicesSelect.SelectedIndex == 0)
            {
                errorProvider7.SetError(ServicesSelect, "Please Input this field");
                return;
            }
            else
            {
                errorProvider7.SetError(ServicesSelect, string.Empty);
            }

            if (petSize.SelectedIndex == 0)
            {
                errorProvider4.SetError(petSize, "Please Input this field");
                return;
            }
            else
            {
                errorProvider4.SetError(petSize, string.Empty);
            }

            if (string.IsNullOrEmpty(cost.Text.Trim()))
            {
                errorProvider5.SetError(cost, "Please Input this field");
                return;
            }
            else
            {
                errorProvider5.SetError(cost, string.Empty);
            }

            if (employee.SelectedIndex == 0)
            {
                errorProvider4.SetError(employee, "Please Input this field");
                return;
            }
            else
            {
                errorProvider4.SetError(employee, string.Empty);
            }
            /*  dbConnect = new Conclass();
              dbConnect.OpenConnection();
              cmd = new MySqlCommand("SELECT * FROM servicetransaction", );*/
            if (ServicesSelect.Text == "Full Groom")
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("INSERT INTO servicetransaction (Owner, pet_id, servicetype, petSize, service_id, sTransac_total, employee_id, date) VALUES (@O, @pt, @fg, @ptsize, '23', @ST, @Ei, @date)", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@O", owner.Text);
                cmd.Parameters.AddWithValue("@pt", petID);
                cmd.Parameters.AddWithValue("@fg", ServicesSelect.Text);
                cmd.Parameters.AddWithValue("@ptsize", petSize.Text);
                cmd.Parameters.AddWithValue("@ST", cost.Text);
                cmd.Parameters.AddWithValue("@Ei", employeeID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Success Added", "Success");
                owner.Clear();
                pettype.SelectedIndex = 0;
                petID = "";
                serviceType.SelectedIndex = 0;
                serviceID = "";
                cost.Clear();
                petSize.SelectedIndex = 0;
                employee.SelectedIndex = 0;
                employeeID = "";
                ServicesSelect.SelectedIndex = 0;
                populategv();
                dbConnect.CloseConnection();
            }
            else if (ServicesSelect.Text == "Not Full Groom")
            {
                if (serviceType.SelectedIndex == 0)
                {
                    errorProvider3.SetError(serviceType, "Please Input this field");
                    return;
                }
                else
                {
                    errorProvider3.SetError(serviceType, string.Empty);
                }

                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("INSERT INTO servicetransaction (Owner, pet_id, servicetype, petSize, service_id, sTransac_total, employee_id, date) VALUES (@O, @pt, 'Not Full Groom', @ptsize, @S, @ST, @Ei, @date)", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@O", owner.Text);
                cmd.Parameters.AddWithValue("@pt", petID);
                cmd.Parameters.AddWithValue("@ptsize", petSize.Text);
                cmd.Parameters.AddWithValue("@S", serviceID);
                cmd.Parameters.AddWithValue("@ST", cost.Text);
                cmd.Parameters.AddWithValue("@Ei", employeeID);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString());
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Success Added", "Success");
                owner.Clear();
                pettype.SelectedIndex = 0;
                petID = "";
                serviceType.SelectedIndex = 0;
                serviceID = "";
                cost.Clear();
                petSize.SelectedIndex = 0;
                employee.SelectedIndex = 0;
                employeeID = "";
                ServicesSelect.SelectedIndex = 0;
                populategv();
                dbConnect.CloseConnection();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (ServicesSelect.Text == "Full Groom")
            {
                if (MaterialMessageBox.Show("Are you sure you want to update this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE servicetransaction SET Owner = @ow, pet_id = @pID, servicetype = @srtype, petSize = @PTS, service_id = '23', sTransac_total = @ct, employee_id = @epID WHERE sTransac_id = @STID", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@STID", StID);
                    cmd.Parameters.AddWithValue("@ow", owner.Text);
                    cmd.Parameters.AddWithValue("@pID", petID);
                    cmd.Parameters.AddWithValue("@srtype", ServicesSelect.Text);
                    cmd.Parameters.AddWithValue("@PTS", petSize.Text);
                    cmd.Parameters.AddWithValue("@ct", cost.Text);
                    cmd.Parameters.AddWithValue("@epID", employeeID);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("Updated Succcessfully", "Success");
                    owner.Clear();
                    pettype.SelectedIndex = 0;
                    petID = "";
                    serviceType.SelectedIndex = 0;
                    serviceID = "";
                    cost.Clear();
                    petSize.SelectedIndex = 0;
                    employee.SelectedIndex = 0;
                    employeeID = "";
                    StID = "0";
                    ServicesSelect.SelectedIndex = 0;
                    populategv();
                    dbConnect.CloseConnection();
                }
            }
            else if (ServicesSelect.Text == "Not Full Groom")
            {
                if (MaterialMessageBox.Show("Are you sure you want to update this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE servicetransaction SET Owner = @ow, pet_id = @pID, servicetype = @srtype, petSize = @PTS, service_id = @sEID, sTransac_total = @ct, employee_id = @epID WHERE sTransac_id = @STID", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@STID", StID);
                    cmd.Parameters.AddWithValue("@ow", owner.Text);
                    cmd.Parameters.AddWithValue("@pID", petID);
                    cmd.Parameters.AddWithValue("@srtype", ServicesSelect.Text);
                    cmd.Parameters.AddWithValue("@PTS", petSize.Text);
                    cmd.Parameters.AddWithValue("@sEID", serviceID);
                    cmd.Parameters.AddWithValue("@ct", cost.Text);
                    cmd.Parameters.AddWithValue("@epID", employeeID);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("Updated Succcessfully", "Success");
                    owner.Clear();
                    pettype.SelectedIndex = 0;
                    petID = "";
                    serviceType.SelectedIndex = 0;
                    serviceID = "";
                    cost.Clear();
                    petSize.SelectedIndex = 0;
                    employee.SelectedIndex = 0;
                    employeeID = "";
                    StID = "0";
                    ServicesSelect.SelectedIndex = 0;
                    populategv();
                    dbConnect.CloseConnection();
                }
            }
            else if (StID == "0")
            {
                MaterialMessageBox.Show("Please Select Data To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (StID == "0")
            {
                MaterialMessageBox.Show("Please Select Data To Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MaterialMessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE servicetransaction SET sTransac_total = 0 WHERE sTransac_id = @TID", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@TID", StID);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("Deleted Successfully", "Notice");
                    owner.Clear();
                    pettype.SelectedIndex = 0;
                    petID = "";
                    serviceType.SelectedIndex = 0;
                    serviceID = "";
                    cost.Clear();
                    petSize.SelectedIndex = 0;
                    employee.SelectedIndex = 0;
                    employeeID = "";
                    StID = "0";
                    ServicesSelect.SelectedIndex = 0;
                    populategv();
                    dbConnect.CloseConnection();
                }
            }
        }

        private void ServiceTransac_Load(object sender, EventArgs e)
        {
            StID = "";
            StID = "0";
            ServicesSelect.SelectedIndex = 0;
            pettype.SelectedIndex = 0;
            petID = "";
            serviceType.SelectedIndex = 0;
            serviceID = "";
            petSize.SelectedIndex = 0;
            employee.SelectedIndex = 0;
            employeeID = "";

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pet_type FROM pet", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string petName = myReader["pet_type"].ToString();

                if (!pettype.Items.Contains(petName))
                {
                    pettype.Items.Add(petName);

                }
            }



            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT employee_fname FROM employee", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["employee_fname"].ToString();

                if (!employee.Items.Contains(itemName))
                {
                    employee.Items.Add(itemName);

                }
            }
        }

        private void pettype_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pet_id FROM pet WHERE pet_type = @pt", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@pt", pettype.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                petID = myReader["pet_id"].ToString();
            }

            if (ServicesSelect.Text == "Full Groom")
            {
                serviceType.Visible = false;
                petSize.Items.Clear();
                petSize.Items.Add("SELECT SIZE");
                petSize.SelectedIndex = 0;
                cost.Clear();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT petSize FROM fullgroom JOIN pet ON fullgroom.pet_id = pet.pet_id WHERE pet_type = @ptname AND service_type = @stype", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@ptname", pettype.Text);
                cmd.Parameters.AddWithValue("@stype", ServicesSelect.Text);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string petsize = myReader["petSize"].ToString();

                    if (!petSize.Items.Contains(petsize))
                    {
                        petSize.Items.Add(petsize);
                    }
                }
            }
            else
            {

                serviceType.Items.Clear();
                petSize.Items.Clear();
                serviceType.Items.Add("SELECT SERVICE");
                serviceType.SelectedIndex = 0;
                petSize.SelectedIndex = 0;
                cost.Clear();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT service_name FROM services JOIN pet ON services.pet_id = pet.pet_id WHERE pet_type = @pname AND service_name != 'NULL'", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@pname", pettype.Text);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    serviceName = myReader["service_name"].ToString();

                    if (!serviceType.Items.Contains(serviceName))
                    {
                        serviceType.Items.Add(serviceName);
                    }
                }
                myReader.Close();
                dbConnect.CloseConnection();
            }
        }

        private void ServicesSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServicesSelect.Text == "Full Groom")
            {
                serviceType.Visible = false;
                services.Visible = false;
                petSize.Items.Clear();
                petSize.Items.Add("SELECT SIZE");
                petSize.SelectedIndex = 0;
                cost.Clear();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT petSize FROM fullgroom JOIN pet ON fullgroom.pet_id = pet.pet_id WHERE pet_type = @ptname AND service_type = @stype", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@ptname", pettype.Text);
                cmd.Parameters.AddWithValue("@stype", ServicesSelect.Text);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string petsize = myReader["petSize"].ToString();

                    if (!petSize.Items.Contains(petsize))
                    {
                        petSize.Items.Add(petsize);
                    }
                }
            }
            else if (ServicesSelect.Text == "Not Full Groom")
            {
                serviceType.Visible = true;
                services.Visible = true;
            }
        }

        private void serviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT service_id FROM services WHERE service_name = @Stype", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@Stype", serviceType.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                serviceID = myReader["service_id"].ToString();
            }

            petSize.Items.Clear();
            petSize.Items.Add("SELECT SIZE");
            petSize.SelectedIndex = 0;
            cost.Clear();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pet_size FROM services JOIN pet ON services.pet_id = pet.pet_id WHERE pet_type = @ptname AND service_name = @sname", dbConnect.myconnect);

            cmd.Parameters.AddWithValue("@ptname", pettype.Text);
            cmd.Parameters.AddWithValue("@sname", serviceType.Text);

            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string petsize = myReader["pet_size"].ToString();

                if (!petSize.Items.Contains(petsize))
                {
                    petSize.Items.Add(petsize);
                }
            }

            myReader.Close();
            dbConnect.CloseConnection();
        }

       

        private void petSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ServicesSelect.Text == "Full Groom")
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT price FROM fullgroom WHERE pet_id = @pID AND petSize = @pS", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@pID", petID);
                cmd.Parameters.AddWithValue("@pS", petSize.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read() == true)
                {
                    cost.Text = myReader["price"].ToString();
                }
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT service_price FROM services WHERE service_name = @seName AND pet_id = @pID AND pet_size = @pS", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@seName", serviceType.Text);
                cmd.Parameters.AddWithValue("@pID", petID);
                cmd.Parameters.AddWithValue("@pS", petSize.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read() == true)
                {
                    cost.Text = myReader["service_price"].ToString();
                }
            }
        }

        private void employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT employee_id FROM employee WHERE employee_fname = @em", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@em", employee.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                employeeID = myReader["employee_id"].ToString();
            }
        }

        private void serviceTtble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                owner.Text = serviceTtble.Rows[e.RowIndex].Cells[1].Value.ToString();
                pettype.Text = serviceTtble.Rows[e.RowIndex].Cells[2].Value.ToString();
                serviceType.Text = serviceTtble.Rows[e.RowIndex].Cells[3].Value.ToString();
                petSize.Text = serviceTtble.Rows[e.RowIndex].Cells[4].Value.ToString();
                cost.Text = serviceTtble.Rows[e.RowIndex].Cells[6].Value.ToString();
                employee.Text = serviceTtble.Rows[e.RowIndex].Cells[7].Value.ToString();
                ServicesSelect.Text = serviceTtble.Rows[e.RowIndex].Cells[5].Value.ToString();
                if (StID == "")
                {
                    StID = "";
                }
                else
                {
                    StID = serviceTtble.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
        }
    }
}
