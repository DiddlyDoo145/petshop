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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Petshop
{
    public partial class ProductsData : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        public ProductsData()
        {
            InitializeComponent();
            populategv();
        }

        private void ProductsData_Load(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pCategory_name FROM productcategory", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["pCategory_name"].ToString();

                if (!pCategory.Items.Contains(itemName))
                {
                    pCategory.Items.Add(itemName);

                }
            }
            dbConnect.CloseConnection();

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT strCategory_desc FROM storecategory", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["strCategory_desc"].ToString();

                if (!strCategory.Items.Contains(itemName))
                {
                    strCategory.Items.Add(itemName);

                }
            }
            dbConnect.CloseConnection();
            pCategory.SelectedIndex = 0;
            strCategory.SelectedIndex = 0;
        }

       private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT product_id, product_name, pCategory_name, product_price, product_stock, strCategory_desc FROM product JOIN productcategory ON product.pCategory_id = productcategory.pCategory_id JOIN storecategory ON product.strCategory_id = storecategory.strCategory_id", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ProductTable.DataSource = dt;
            ProductTable.Columns[0].Visible = false;
            DataGridViewColumn column1 = ProductTable.Columns["product_name"];
            DataGridViewColumn column2 = ProductTable.Columns["pCategory_name"];
            DataGridViewColumn column3 = ProductTable.Columns["product_price"];
            DataGridViewColumn column4 = ProductTable.Columns["product_stock"];
            DataGridViewColumn column5 = ProductTable.Columns["strCategory_desc"];
            ProductTable.Columns[1].HeaderText = "Product Name";
            ProductTable.Columns[2].HeaderText = "Product Category";
            ProductTable.Columns[3].HeaderText = "Product Price";
            ProductTable.Columns[4].HeaderText = "Product Stock";
            ProductTable.Columns[5].HeaderText = "Store Category";

        }


       private void AddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productname.Text.Trim()))
            {
                errorProvider1.SetError(productname, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(productname, string.Empty);
            }
            if (pCategory.Text == "SELECT CATEGORY")
            {
                errorProvider2.SetError(pCategory, "Please Select Category");
                return;
            }
            else
            {
                errorProvider2.SetError(pCategory, string.Empty);
            }
            if (string.IsNullOrEmpty(product_price.Text.Trim()))
            {
                errorProvider3.SetError(product_price, "Please Input this field");
                return;
            }
            else
            {
                errorProvider3.SetError(product_price, string.Empty);
            }

            if (string.IsNullOrEmpty(product_stock.Text.Trim()))
            {
                errorProvider4.SetError(product_stock, "Please Input this field");
                return;
            }
            else
            {
                errorProvider4.SetError(product_stock, string.Empty);
            }

            if (strCategory.Text == "SELECT CATEGORY")
            {
                errorProvider5.SetError(strCategory, "Please Select Category");
                return;
            }
            else
            {
                errorProvider5.SetError(strCategory, string.Empty);
            }
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("INSERT INTO product (product_name, pCategory_id, product_price, product_stock, strCategory_id) VALUES ('"+productname.Text+"', '"+pCategory_ID.Text+"', '"+product_price.Text+"', '"+product_stock.Text+"', '"+strCategory_ID.Text+"')", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            MessageBox.Show("New Product Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dbConnect.CloseConnection();
            productname.Clear();
            product_price.Clear();
            product_stock.Clear();
            pCategory.SelectedIndex = 0;
            strCategory.SelectedIndex = 0;
            populategv();
        }

        private void pCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pCategory_id FROM productcategory WHERE pCategory_name = '"+pCategory.Text+"'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if(myReader.Read() == true)
            {
                pCategory_ID.Text = myReader["pCategory_id"].ToString();
            }
            populategv();
            dbConnect.CloseConnection();

        }

       
        

        private void strCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT strCategory_id FROM storecategory WHERE strCategory_desc = '" + strCategory.Text + "'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                strCategory_ID.Text = myReader["strCategory_id"].ToString();
            }
            dbConnect.CloseConnection();
        }

        private void ProductTable_MouseClick(object sender, MouseEventArgs e)
        {
            product_id.Text = ProductTable.SelectedRows[0].Cells[0].Value.ToString();
            productname.Text = ProductTable.SelectedRows[0].Cells[1].Value.ToString();
            pCategory.Text = ProductTable.SelectedRows[0].Cells[2].Value.ToString();
            product_price.Text = ProductTable.SelectedRows[0].Cells[3].Value.ToString();
            product_stock.Text = ProductTable.SelectedRows[0].Cells[4].Value.ToString();
            strCategory.Text = ProductTable.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productname.Text.Trim()))
            {
                errorProvider1.SetError(productname, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(productname, string.Empty);
            }
            if (pCategory.Text == "SELECT CATEGORY")
            {
                errorProvider2.SetError(pCategory, "Please Select Category");
                return;
            }
            else
            {
                errorProvider2.SetError(pCategory, string.Empty);
            }
            if (string.IsNullOrEmpty(product_price.Text.Trim()))
            {
                errorProvider3.SetError(product_price, "Please Input this field");
                return;
            }
            else
            {
                errorProvider3.SetError(product_price, string.Empty);
            }

            if (string.IsNullOrEmpty(product_stock.Text.Trim()))
            {
                errorProvider4.SetError(product_stock, "Please Input this field");
                return;
            }
            else
            {
                errorProvider4.SetError(product_stock, string.Empty);
            }

            if (strCategory.Text == "SELECT CATEGORY")
            {
                errorProvider5.SetError(strCategory, "Please Select Category");
                return;
            }
            else
            {
                errorProvider5.SetError(strCategory, string.Empty);
            }
            if (product_id.Text == "" || product_id.Text == "label1")
            {
                MessageBox.Show("Please Select data to delete");
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE product SET product_name = @productname, pCategory_id = @pCategory_id, product_price = @productPrice, product_stock = @pStock, strCategory_id = @strID WHERE product_id = @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", product_id.Text);
                cmd.Parameters.AddWithValue("@productname", productname.Text);
                cmd.Parameters.AddWithValue("@pCategory_id", pCategory_ID.Text);
                cmd.Parameters.AddWithValue("@productPrice", product_price.Text);
                cmd.Parameters.AddWithValue("@pStock", product_stock.Text);
                cmd.Parameters.AddWithValue("@strID", strCategory_ID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Success");
                dbConnect.CloseConnection();
                productname.Clear();
                product_price.Clear();
                product_stock.Clear();
                pCategory.SelectedIndex = 0;
                strCategory.SelectedIndex = 0;
                populategv();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (product_id.Text == "" || product_id.Text == "label1")
            {
                MessageBox.Show("Please Select data to delete");
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("DELETE FROM product WHERE product_id = @id AND ", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", product_id.Text);
                cmd.ExecuteNonQuery();
               /* MessageBox.Show("Deleted Successfully", "Success");*/
                MaterialMessageBox.Show("Deleted Successfully", "Success");
                dbConnect.CloseConnection();
                productname.Clear();
                product_price.Clear();
                product_stock.Clear();
                pCategory.SelectedIndex = 0;
                strCategory.SelectedIndex = 0;
                populategv();
            }
        }

        private void product_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void product_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pCategory_ID.ResetText();
            strCategory_ID.ResetText();
            product_id.ResetText();
            productname.Clear();
            product_price.Clear();
            product_stock.Clear();
            pCategory.SelectedIndex = 0;
            strCategory.SelectedIndex = 0;
        }
    }
}
