using Google.Protobuf.WellKnownTypes;
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
    public partial class Cashier : Form
    {
        public static Cashier instance;
        private Form currentchildForm1;
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        string soldPer, availing, productID, serviceID, transactTotal, qty, petID, pSizeID;
        int stock = 0, price, multiplier;
        bool full, shouldhandle = true;
        public Cashier()
        {
            InitializeComponent();
            instance = this;
            petType.KeyPress += petType_KeyPress;
/*            checkCashier();*/
        }
        public void Cashier_Load(object sender, EventArgs e)
        {
            qtyCategory.Text = "KILO";
            soldPer = "KILO";
            loadProduct();
            productPanel.BringToFront();
            availing = "Product";
            petSize.SelectedIndex = 0;
            full = false;
        }

        #region Child Form
        private void OpenChildForm1(Form childForm, int xpos, int ypos)
        {
            if (currentchildForm1 != null)
            {
                currentchildForm1.Hide();
            }
            currentchildForm1 = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            /*            childForm.Size = new Size(Convert.ToInt32(childForm.Width * 1.155), Convert.ToInt32(childForm.Height * 1.096));*/
            childForm.FormBorderStyle = FormBorderStyle.None;
            /*            childForm.Location = new Point(xpos, ypos);*/
        }
        #endregion

        #region checkReceipt
        private void checkCashier()
        {
            int total = receiptDgv.Rows.Count;
            if (total > 0)
            {
                Home.instance.isEmpty = false;
            }
            else
            {
                Home.instance.isEmpty = true;
            }
        }
        #endregion

        #region Clicks
        private void productCategory_Click(object sender, EventArgs e)
        {
            //OpenChildForm1(new ProductTransac(), 30, 135);
            loadProduct();
            productName.Clear();
            productPrice.Clear();
            productQty.Text = "00";
            productPanel.BringToFront();
            servicePanel.SendToBack();
            availing = "Product";
        }

        private void services_Click(object sender, EventArgs e)
        {
            //OpenChildForm1(new ServiceTransac(), 30, 135);
            loadService();
            productPanel.SendToBack();
            servicePanel.BringToFront();
            serviceName.Clear();
            servicePrice.Clear();
            petType.Clear();
            petSize.SelectedIndex = 0;
            availing = "Service";
            full = true;
            fullGroom_CheckedChanged(null, null);
        } 
        private void qtyCategory_Click(object sender, EventArgs e)
        {
            if(qtyCategory.Text == "KILO")
            {
                soldPer = "SACK";
                qtyCategory.Text = "SACK";
                multiplier = 20;
                if(productQty.TextLength < 1)
                {

                }
                else
                {
                    int current = Convert.ToInt32(productQty.Text) * multiplier;
                    if (stock < current)
                    {
                        MaterialMessageBox.Show("Stock insufficient", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (stock.ToString().Length < 2)
                        {
                            productQty.Text = "0" + stock.ToString();
                        }
                        else
                        {
                            productQty.Text = stock.ToString();
                        }
                        soldPer = "KILO";
                        qtyCategory.Text = "KILO";
                        multiplier = 1;
                    }
                }
            }
            else
            {
                soldPer = "KILO";
                qtyCategory.Text = "KILO";
                multiplier = 1;
                if(productQty.TextLength < 1)
                {

                }
                else
                {
                    int current = Convert.ToInt32(productQty.Text) * multiplier;
                    if (stock < current)
                    {
                        MaterialMessageBox.Show("Stock insufficient", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (stock.ToString().Length < 2)
                        {
                            productQty.Text = "0" + stock.ToString();
                        }
                        else
                        {
                            productQty.Text = stock.ToString();
                        }
                    }
                }
            }
        }
        #endregion

        #region loadData
        private void loadProduct()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT product.product_name, productcategory.pCategory_name, product.product_stock, product.product_price FROM product JOIN productcategory ON product.pCategory_id = productcategory.pCategory_id WHERE productcategory.pCategory_name != 'NULL' AND product.product_stock > '0'", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            cashierDgv.DataSource = dt;
            cashierDgv.Columns[0].Visible = true;
            DataGridViewColumn column0 = cashierDgv.Columns["product_name"];
            cashierDgv.Columns[0].HeaderText = "Product Name";
            cashierDgv.Columns[1].HeaderText = "Category Name";
            cashierDgv.Columns[2].HeaderText = "Available Stocks";
            cashierDgv.Columns[3].HeaderText = "Product Price";
            dbConnect.CloseConnection();
        }
        private void loadService()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT services.service_name, services.service_price, pet.pet_type FROM services JOIN pet ON services.pet_id = pet.pet_id WHERE services.service_price > '0' AND service_name != 'Full Groom'", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            cashierDgv.DataSource = dt;
            cashierDgv.Columns[0].Visible = true;
            DataGridViewColumn column0 = cashierDgv.Columns["service_name"];
            cashierDgv.Columns[0].HeaderText = "Service Name";
            cashierDgv.Columns[1].HeaderText = "Service Price";
            cashierDgv.Columns[2].HeaderText = "Pet Type";
            dbConnect.CloseConnection();
        }
        #endregion

        #region Key Press
        private void productName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }

        private void productQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press
            }
        }
        private void petType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (shouldhandle == true)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        #endregion

        #region QTY Addition Subtraction
        private void addQty_Click(object sender, EventArgs e)
        {
            int current = Convert.ToInt32(productQty.Text);
            if(current == stock)
            {
                MaterialMessageBox.Show("Stock reached", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                current++;
                if (current.ToString().Length < 2)
                {
                    productQty.Text = "0" + current.ToString();
                }
                else
                {
                    productQty.Text = current.ToString();
                }
            }
        }

        private void subQty_Click(object sender, EventArgs e)
        {
            if(productQty.Text == "01")
            {

            }
            else
            {
                int current = Convert.ToInt32(productQty.Text);
                current--;
                if (current.ToString().Length < 2)
                {
                    productQty.Text = "0" + current.ToString();
                }
                else
                {
                    productQty.Text = current.ToString();
                }
            }
        }
        #endregion

        #region Get Service ID & Price
        private void getServiceId()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT service_id FROM services WHERE service_name = @name AND service_price = @price", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@name", serviceName.Text);
            cmd.Parameters.AddWithValue("@price", servicePrice.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                serviceID = myReader["service_id"].ToString();
            }
            dbConnect.CloseConnection();
        }
        private void getPrice()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT petsize.ptsize_price FROM petsize JOIN pet ON petsize.pet_id = pet.pet_id WHERE petsize.pet_size = @size AND pet.pet_type = @petType", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@petType", petType.Text);
            cmd.Parameters.AddWithValue("@size", petSize.SelectedItem);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                price = Convert.ToInt32(myReader["ptsize_price"].ToString());
            }
            else
            {
                MaterialMessageBox.Show("Size for such pet type doesn't exist in the system", "Notice", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        #endregion

        #region Get Product ID
        private void getProductId()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT product_id FROM product WHERE product_name = @name AND product_price = @price", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@name", productName.Text);
            cmd.Parameters.AddWithValue("@price", productPrice.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                productID = myReader["product_id"].ToString();
            }
            dbConnect.CloseConnection();
        }

        #endregion

        #region Get Pet ID
        private void getPetID()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT pet_id FROM pet WHERE pet_type = @type", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@type", petType.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                petID = myReader["pet_id"].ToString();
            }
        }
        private void getPetSize()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT ptsize_id FROM petsize WHERE pet_size = @size AND pet_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@size", petSize.Text);
            cmd.Parameters.AddWithValue("@id", petID);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                pSizeID = myReader["ptsize_id"].ToString();
            }
        }
        #endregion

        #region Cancel or Add Order
        private void cancelOrder_Click(object sender, EventArgs e)
        {
            stock = 0;
            productName.ResetText();
            productPrice.ResetText();
            productQty.Text = "00";
            serviceName.ResetText();
            servicePrice.ResetText();
            petType.ResetText();
            petSize.SelectedIndex = 0;
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            if (availing == "Product")
            {
                if (productName.TextLength == 0)
                {
                    MaterialMessageBox.Show("Please choose a product to add!", "Notice");
                }
                else
                {
                    if(productQty.Text == "00")
                    {
                        MaterialMessageBox.Show("Quantity can't be less than 1.", "Notice");
                        productQty.Text = "01";
                    }
                    else
                    {
                        int num1 = Convert.ToInt32(productPrice.Text);
                        int num2 = Convert.ToInt32(productQty.Text);
/*                        if (soldPer == "SACK")
                        {
                            multiplier = 60;
                        }
                        else if (soldPer == "KILO")
                        {
                            multiplier = 1;
                        }*/
                        int total = num2 * (num1 * multiplier);
                        int rowId = receiptDgv.Rows.Add();
                        transactTotal = total.ToString();
                        qty = (num2 * multiplier).ToString();
                        // Grab the new row!
                        DataGridViewRow row = receiptDgv.Rows[rowId];
                        // Add the data
                        row.Cells["Column5"].Value = productName.Text;
                        row.Cells["Column6"].Value = productPrice.Text;
                        row.Cells["Column7"].Value = productQty.Text;
                        row.Cells["Column8"].Value = total;
                        row.Cells["Column9"].Value = "Product";
                        subtractProduct();
                        productName.Clear();
                        productPrice.Clear();
                        productQty.Text = "00";
                        newTransaction();
                        loadProduct();
                    }
                }
            }
            else if (availing == "Service")
            {
                if (full == false)
                {
                    if (serviceName.TextLength == 0)
                    {
                        MaterialMessageBox.Show("Please choose a service to avail!", "Notice");
                    }
                    else
                    {
                        getPrice();
                        if (price > 0)
                        {
                            getPetID();
                            getPetSize();
                            getServiceId();
                            int num1 = Convert.ToInt32(servicePrice.Text);
                            int num2 = price;
                            int total = num2 + num1;
                            transactTotal = total.ToString();
                            int rowId = receiptDgv.Rows.Add();
                            // Grab the new row!
                            DataGridViewRow row = receiptDgv.Rows[rowId];
                            // Add the data
                            row.Cells["Column5"].Value = serviceName.Text;
                            row.Cells["Column6"].Value = servicePrice.Text;
                            row.Cells["Column7"].Value = petType.Text + "-" + petSize.Text;
                            row.Cells["Column8"].Value = total;
                            row.Cells["Column9"].Value = "Service";
                            addserviceTransaction();
                            price = 0;
                            serviceName.Clear();
                            servicePrice.Clear();
                            petType.Clear();
                            petSize.SelectedIndex = 0;
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    string name = "Full Groom";
                    getPetID();
                    getPrice();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("SELECT service_id, service_price FROM services WHERE service_name = @name AND pet_id = @pet", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@pet", petID);
                    myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        serviceID = myReader["service_id"].ToString();
                        transactTotal = myReader["service_price"].ToString();
                        getPetSize();
                        int num1 = Convert.ToInt32(transactTotal);
                        int num2 = price;
                        int total = num2 + num1;
                        int rowId = receiptDgv.Rows.Add();
                        // Grab the new row!
                        DataGridViewRow row = receiptDgv.Rows[rowId];
                        // Add the data
                        row.Cells["Column5"].Value = "Full Groom";
                        row.Cells["Column6"].Value = transactTotal;
                        row.Cells["Column7"].Value = petType.Text + "-" + petSize.Text;
                        row.Cells["Column8"].Value = total;
                        row.Cells["Column9"].Value = "Service";
                        transactTotal = total.ToString();
                        addserviceTransaction();
                        petType.ResetText();
                        petSize.SelectedIndex = 0;
                    }
                    else
                    {
                        MaterialMessageBox.Show("Service doesn't exist in the system!", "Notice!");
                    }
                    dbConnect.CloseConnection();
                }
            }
        }
        #endregion

        #region Transactions
        private void newTransaction()
        {
            DateTime today = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO producttransaction VALUES('', @productID, @total, @employeeID, @date, @qty)", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@total", transactTotal);
            cmd.Parameters.AddWithValue("@employeeID", ID.Text);
            cmd.Parameters.AddWithValue("@date", today.ToString("MM-dd-yyyy"));
            cmd.Parameters.AddWithValue("@qty", qty);
            int insert = cmd.ExecuteNonQuery();
/*            if (insert > 0)
            {
                MessageBox.Show("Inserted");
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkCashier();
            timer1.Stop();
        }

        private void deleteTransaction()
        {
/*            MessageBox.Show(" " + productID);*/
            DateTime today = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM producttransaction WHERE product_id = @product AND Quantity = @qty AND pDate = @date ORDER BY pTransac_id DESC LIMIT 1", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@product", productID);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@date", today.ToString("MM-dd-yyyy"));
            int  delete = cmd.ExecuteNonQuery();
/*            if (delete > 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Failed");
            }*/
        }
        private void addProduct()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT product_stock FROM product WHERE product_id = @product", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@product", productID);
            myReader = cmd.ExecuteReader();
            if(myReader.Read())
            {
                stock = Convert.ToInt32(myReader["product_stock"].ToString());
                myReader.Close();
                int add = Convert.ToInt32(productQty.Text);
                int total = stock + add;
                stock = total;
                MySqlCommand cmd1 = new MySqlCommand("UPDATE product SET product_stock = @total WHERE product_id = @ID", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@total", total);
                cmd1.Parameters.AddWithValue("@ID", productID);
                int added = cmd1.ExecuteNonQuery();
/*                if(added > 0)
                {
                    MessageBox.Show("Added");
                }*/
            }
        }
        private void subtractProduct()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT product_stock FROM product WHERE product_id = @product", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@product", productID);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                stock = Convert.ToInt32(myReader["product_stock"].ToString());
                myReader.Close();
                int subtract = Convert.ToInt32(productQty.Text);
                int total = stock - (subtract * multiplier);
                MySqlCommand cmd1 = new MySqlCommand("UPDATE product SET product_stock = @total WHERE product_id = @ID", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@total", total);
                cmd1.Parameters.AddWithValue("@ID", productID);
                int subtracted = cmd1.ExecuteNonQuery();
/*                if (subtracted > 0)
                {
                    MessageBox.Show("Subtracted");
                }*/
            }
        }
        private void addserviceTransaction()
        {
            DateTime today = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO servicetransaction VALUES('', @pet, @size, @service, @total, @employee, @date)", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@pet", petID);
            cmd.Parameters.AddWithValue("@size", pSizeID);
            cmd.Parameters.AddWithValue("@service", serviceID);
            cmd.Parameters.AddWithValue("@total", transactTotal);
            cmd.Parameters.AddWithValue("@employee", ID.Text);
            cmd.Parameters.AddWithValue("@date", today.ToString("MM-dd-yyyy"));
            int insert = cmd.ExecuteNonQuery();
/*            if(insert > 0)
            {
                MessageBox.Show("Success");
            }*/
        }
        private void deleteserviceTransaction()
        {
            DateTime today = DateTime.Now;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM servicetransaction WHERE pet_id = @pet AND ptsize_id = @size AND service_id = @service AND sTransact_total = @total AND employee_id = @employee AND date = @date ORDER BY sTransact_id DESC LIMIT 1", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@pet", petID);
            cmd.Parameters.AddWithValue("@size", pSizeID);
            cmd.Parameters.AddWithValue("@service", serviceID);
            cmd.Parameters.AddWithValue("@total", transactTotal);
            cmd.Parameters.AddWithValue("@employee", ID.Text);
            cmd.Parameters.AddWithValue("@date", today.ToString("MM-dd-yyyy"));
            int delete = cmd.ExecuteNonQuery();
/*            if(delete > 0)
            {
                MessageBox.Show("Deleted");
            }*/
        }
        #endregion

        private void cashierDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {

            }
            else
            {
                if (availing == "Product")
                {
                    productName.Text = cashierDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                    productPrice.Text = cashierDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    stock = Convert.ToInt32(cashierDgv.Rows[e.RowIndex].Cells[2].Value);
                    productQty.Text = "01";
                    getProductId();
                }
                else if (availing == "Service")
                {
                    serviceName.Text = cashierDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                    servicePrice.Text = cashierDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                    petType.Text = cashierDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                    getServiceId();
                }
                else
                {

                }
            }
        }

        private void receiptDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < receiptDgv.Rows.Count)
            {
                DataGridViewRow row = receiptDgv.Rows[e.RowIndex];
                if (row.Cells["Column9"].Value.ToString() == "Product")
                {
                    productCategory_Click(null, null);
                    productPanel.BringToFront();
                    servicePanel.SendToBack();
                    productName.Text = row.Cells["Column5"].Value.ToString();
                    productPrice.Text = row.Cells["Column6"].Value.ToString();
                    productQty.Text = row.Cells["Column7"].Value.ToString();
                    receiptDgv.Rows.RemoveAt(e.RowIndex);
                    qty = Convert.ToString(Convert.ToInt32(productQty.Text));
                    getProductId();
                    deleteTransaction();
                    addProduct();
                    loadProduct();
                }
                else if (row.Cells["Column9"].Value.ToString() == "Service")
                {
                    services_Click(null, null);
                    if(row.Cells["Column5"].Value.ToString() == "Full Groom")
                    {
                        full = false;
                        fullGroom_CheckedChanged(null, null);
                    }
                    else
                    {

                    }
                    string input = row.Cells["Column7"].Value.ToString();
                    string[] part = input.Split(new[] { "-" }, StringSplitOptions.None);
                    productPanel.SendToBack();
                    servicePanel.BringToFront();
                    serviceName.Text = row.Cells["Column5"].Value.ToString();
                    servicePrice.Text = row.Cells["Column6"].Value.ToString();
                    transactTotal = row.Cells["Column8"].Value.ToString();
                    petType.Text = part[0].Trim();
                    switch (part[1].Trim())
                    {
                        case "Small":
                            petSize.SelectedIndex = 1;
                            break;
                        case "Medium":
                            petSize.SelectedIndex = 2;
                            break;
                        case "Large":
                            petSize.SelectedIndex = 3;
                            break;
                        case "Extra Large":
                            petSize.SelectedIndex = 4;
                            break;
                        case "2XL":
                            petSize.SelectedIndex = 5;
                            break;
                        default:
                            petSize.SelectedIndex = 0;
                            break;
                    }
                    receiptDgv.Rows.RemoveAt(e.RowIndex);
                    getPetID();
                    getPetSize();
                    getServiceId();
                    deleteserviceTransaction();
                }
            }
        }

        private void fullGroom_CheckedChanged(object sender, EventArgs e)
        {
            if(full == false)
            {
                fullGroom.Checked = true;
                full = true;
                petType.Location = new Point(40, 98);
                petSize.Location = new Point(174, 107);
/*                MessageBox.Show(petType.Location.ToString() + " " + petSize.Location.ToString());*/
                serviceName.Visible = false;
                servicePrice.Visible = false;
                serviceName.ResetText();
                servicePrice.ResetText();
                shouldhandle = false;
            }
            else
            {
                fullGroom.Checked = false;
                full = false;
                petType.Location = new Point(40, 178);
                petSize.Location = new Point(174, 187);
/*                MessageBox.Show(petType.Location.ToString() + " " + petSize.Location.ToString());*/
                petType.ResetText();
                serviceName.Visible = true;
                servicePrice.Visible = true;
                servicePrice.ResetText();
                serviceName.ResetText();
                shouldhandle = true;
            }
        }

        private void productQty_TextChanged(object sender, EventArgs e)
        {
            if(productName.TextLength == 0)
            {
                if (productQty.Text.Length < 1)
                {

                }
            }
            else
            {
                if(productQty.Text.Length < 1)
                {

                }
                else
                {
                    int current = Convert.ToInt32(productQty.Text) * multiplier;
                    if (stock < current)
                    {
                        MaterialMessageBox.Show("Stock insuffiecient", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (stock.ToString().Length < 2)
                        {
                            productQty.Text = "0" + stock.ToString();
                            soldPer = "KILO";
                            qtyCategory.Text = "KILO";
                            multiplier = 1;
                        }
                        else
                        {
                            productQty.Text = stock.ToString();
                            soldPer = "KILO";
                            qtyCategory.Text = "KILO";
                            multiplier = 1;
                        }
                    }
                }
            }
        }
    }
}
