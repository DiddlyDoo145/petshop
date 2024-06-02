using MySql.Data.MySqlClient;
using Practice1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class Product : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        public Product()
        {
            InitializeComponent();
            populategv();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            category.SelectedIndex = 0;
        }

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void productPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }
        private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM products", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ProductTable.DataSource = dt;
            ProductTable.Columns[0].Visible = false;
            DataGridViewColumn column1 = ProductTable.Columns["productName"];
            DataGridViewColumn column2 = ProductTable.Columns["category"];
            DataGridViewColumn column3 = ProductTable.Columns["quantity"];
            DataGridViewColumn column4 = ProductTable.Columns["price"];
            ProductTable.Columns[1].HeaderText = "Product Name";
            ProductTable.Columns[2].HeaderText = "Category";
            ProductTable.Columns[3].HeaderText = "Quantity";
            ProductTable.Columns[4].HeaderText = "Price";
        }


        private void ProductTable_MouseClick(object sender, MouseEventArgs e)
        {
            product_ID.Text = ProductTable.CurrentRow.Cells[0].Value.ToString();
            productName.Text = ProductTable.CurrentRow.Cells[1].Value.ToString();
            category.Text = ProductTable.CurrentRow.Cells[2].Value.ToString();
            quantity.Text = ProductTable.CurrentRow.Cells[3].Value.ToString();
            productPrice.Text = ProductTable.CurrentRow.Cells[4].Value.ToString();
        }



        private void SaveProducts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productName.Text.Trim()))
            {
                errorProvider1.SetError(productName, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(productName, string.Empty);
            }
            if (string.IsNullOrEmpty(quantity.Text.Trim()))
            {
                errorProvider2.SetError(quantity, "Please Input this field");
                return;
            }
            else
            {
                errorProvider2.SetError(quantity, string.Empty);
            }

            if (string.IsNullOrEmpty(productPrice.Text.Trim()))
            {
                errorProvider3.SetError(productPrice, "Please Input this field");
                return;
            }
            else
            {
                errorProvider3.SetError(productPrice, string.Empty);
            }

            if (category.Text == "Select Category")
            {
                errorProvider4.SetError(category, "Please Select Category");
                return;
            }
            else
            {
                errorProvider4.SetError(category, string.Empty);
            }

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("INSERT INTO `products`(`ProdName`, `ProdCat`, `ProdQty`, `ProdPrice`) VALUES ('" + productName.Text + "', '" + category.Text + "', '" + quantity.Text + "', '" + productPrice.Text + "')", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            MessageBox.Show("Save Successfully");
            populategv();
            productName.Clear();
            quantity.Clear();
            productPrice.Clear();
            category.SelectedIndex = 0;
            myReader.Close();
        }

    

        private void EditProducts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE products SET ProdName = '" + productName.Text + "', ProdCat = '" + category.Text + "', ProdQty = '" + quantity.Text + "', ProdPrice = '" + productPrice.Text + "' WHERE ProdId = '" + product_ID.Text + "'", dbConnect.myconnect);
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Updated Successfully");
                populategv();
                productName.Clear();
                quantity.Clear();
                productPrice.Clear();
                category.SelectedIndex = 0;
                myReader.Close();
            }
        }

        private void DeleteProducts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("DELETE FROM products WHERE ProdId = '" + product_ID.Text + "'", dbConnect.myconnect);
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Deleted Successfully");
                populategv();
                productName.Clear();
                quantity.Clear();
                productPrice.Clear();
                category.SelectedIndex = 0;
                myReader.Close();
            }
        }

       
    }
}
