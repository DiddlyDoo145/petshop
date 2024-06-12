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
        string productID;
        public ProductsData()
        {
            InitializeComponent();
            populategv();
        }

        private void ProductsData_Load(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pCategory_name FROM productcategory WHERE pCategory_name != 'NULL'", dbConnect.myconnect);
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
            pCategory.SelectedIndex = 0;
           
        }

       private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT product_id, product_name, pCategory_name, product_price, product_stock, strCategory_desc FROM product JOIN productcategory ON product.pCategory_id = productcategory.pCategory_id JOIN storecategory ON product.strCategory_id = storecategory.strCategory_id WHERE product_stock > '0' AND product_price > '0'", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ProductTable.DataSource = dt;
            ProductTable.Columns[0].Visible = false;
            dbConnect.CloseConnection();

        }


        int Key = 0;
        private void ProductTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                productname.Text = ProductTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                pCategory.Text = ProductTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                product_price.Text = ProductTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                product_stock.Text = ProductTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (productname.Text == "")
                {
                    productID = "";
                }
                else
                {
                    productID = ProductTable.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
           
        }
       
    

        private void search_TextChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT product_id, product_name, pCategory_name, product_price, product_stock, strCategory_desc FROM product JOIN productcategory ON product.pCategory_id = productcategory.pCategory_id JOIN storecategory ON product.strCategory_id = storecategory.strCategory_id WHERE  product_name LIKE '%" + search.Text + "%' AND product_price > 0 AND product_price > 0 OR pCategory_name LIKE '%" + search.Text + "%' AND product_price > 0 AND product_price > 0 OR strCategory_desc LIKE '%" + search.Text + "%' AND product_price > 0 AND product_price > 0", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ProductTable.DataSource = dt;
            ProductTable.Columns[0].Visible = false;
            dbConnect.CloseConnection();
        }

        private void AddProduct_Click(object sender, EventArgs e)
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
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM product JOIN productcategory ON product.pCategory_id = productcategory.pCategory_id JOIN storecategory ON product.strCategory_id = storecategory.strCategory_id WHERE product_name = @Uname AND pCategory_name = @Uca AND product_stock = 0 AND product_price = 0", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@Uname", productname.Text);
            cmd.Parameters.AddWithValue("@Uca", pCategory.Text);
            myReader = cmd.ExecuteReader();
            if(myReader.Read() == true)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE product SET product_stock = @Ustock, product_price = @Uprice WHERE product_name = @uname AND pCategory_id = @uID AND product_stock = 0 AND product_price = 0", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@uname", productname.Text);
                cmd.Parameters.AddWithValue("@uID", pCategory_ID.Text);
                cmd.Parameters.AddWithValue("@Uprice", product_price.Text);
                cmd.Parameters.AddWithValue("@Ustock", product_stock.Text);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Added Successfully", "Notice!!");
                productname.Clear();
                product_price.Clear();
                product_stock.Clear();
                pCategory.SelectedIndex = 0;
                Key = 0;
                dbConnect.CloseConnection();
                return;
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT * FROM product JOIN productcategory ON product.pCategory_id = productcategory.pCategory_id JOIN storecategory ON product.strCategory_id = storecategory.strCategory_id WHERE product_name = @ename AND pCategory_name = @eca", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@ename", productname.Text);
                cmd.Parameters.AddWithValue("@eca", pCategory.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read() == true)
                {
                    MaterialMessageBox.Show("Product Already Exist", "Error!!");
                    dbConnect.CloseConnection();
                    return;
                }
                else
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("INSERT INTO product (product_name, pCategory_id, product_price, product_stock, strCategory_id) VALUES (@pname, @cID, @price, @stock,'1')", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@pname", productname.Text);
                    cmd.Parameters.AddWithValue("@cID", pCategory_ID.Text);
                    cmd.Parameters.AddWithValue("@price", product_price.Text);
                    cmd.Parameters.AddWithValue("@stock", product_stock.Text);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("New Product Successfully Added", "Success");
                    dbConnect.CloseConnection();
                    productname.Clear();
                    product_price.Clear();
                    product_stock.Clear();
                    pCategory.SelectedIndex = 0;
                    Key = 0;
                    populategv();
                }


            }




        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
           
            if (productID == "")
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("SELECT product_id FROM product JOIN productcategory ON product.pCategory_id = productcategory.pCategory_id JOIN storecategory ON product.strCategory_id = storecategory.strCategory_id WHERE product_name = @ename AND pCategory_name = @eca", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@ename", productname.Text);
                cmd.Parameters.AddWithValue("@eca", pCategory.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read() == true)
                {
                    
                    productID = myReader["product_id"].ToString();
                    
                }
                        
            }
            if (MaterialMessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE product SET product_name = @productname, pCategory_id = @pCategory_id, product_price = @productPrice, product_stock = @pStock WHERE product_id = @id", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@id", productID);
                    cmd.Parameters.AddWithValue("@productname", productname.Text);
                    cmd.Parameters.AddWithValue("@pCategory_id", pCategory_ID.Text);
                    cmd.Parameters.AddWithValue("@productPrice", product_price.Text);
                    cmd.Parameters.AddWithValue("@pStock", product_stock.Text);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("Updated Successfully", "Success");
                    dbConnect.CloseConnection();
                    productname.Clear();
                    product_price.Clear();
                    product_stock.Clear();
                    pCategory.SelectedIndex = 0;
                    Key = 0;
                    populategv();
                    dbConnect.CloseConnection();
                
              
            }
            else
            {
                MaterialMessageBox.Show("Please Select product to update", "Notice!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbConnect.CloseConnection();
            }
        }
            

        private void button2_Click_1(object sender, EventArgs e)
        {
         if(productID == "")
            {
                MaterialMessageBox.Show("Please Select Product to Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (MaterialMessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE product SET product_stock = 0, product_price = 0 WHERE product_id = @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", productID);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Deleted Successfully", "Success");
                dbConnect.CloseConnection();
                productname.Clear();
                product_price.Clear();
                product_stock.Clear();
                pCategory.SelectedIndex = 0;
                Key = 0;
                populategv();
                dbConnect.CloseConnection();
            }
   
           
        }
           
            
           
        

        private void Reset_Click(object sender, EventArgs e)
        {
            pCategory_ID.ResetText();
            Key = 0;
            productname.Clear();
            product_price.Clear();
            product_stock.Clear();
            pCategory.SelectedIndex = 0;
           
        }

        private void pCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT pCategory_id FROM productcategory WHERE pCategory_name = '" + pCategory.Text + "'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                pCategory_ID.Text = myReader["pCategory_id"].ToString();
            }
            populategv();
            dbConnect.CloseConnection();
        }

     
        private void product_price_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Purchase f1 = new Purchase();
            f1.Show();
            Visible = true;
        }

      
    }
}
