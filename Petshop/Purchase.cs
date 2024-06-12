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
using System.Xml;

namespace Petshop
{
    public partial class Purchase : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        public Purchase()
        {
            InitializeComponent();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            int num;
            int num1;

            num1 = Convert.ToInt32(productStock.Text);
            num = Convert.ToInt32(TransacTotal.Text);

            if (num1 <= num)
            {
                MaterialMessageBox.Show("Product Don't Have Enough Stock", "Notice!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (productName.Text == "SELECT CATEGORY")
            {
                errorProvider1.SetError(productName, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(productName, string.Empty);
            }
           
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                errorProvider2.SetError(textBox2, "Please Input this field");
                return;
            }
            else
            {
                errorProvider2.SetError(textBox2, string.Empty);
            }

            if (string.IsNullOrEmpty(TransacTotal.Text.Trim()))
            {
                errorProvider3.SetError(TransacTotal, "Please Input this field");
                return;
            }
            else
            {
                errorProvider3.SetError(TransacTotal, string.Empty);
            }

            if (employee_Name.Text == "SELECT CATEGORY")
            {
                errorProvider4.SetError(employee_Name, "Please Select Category");
                return;
            }
            else
            {
                errorProvider4.SetError(employee_Name, string.Empty);
            }
           

            if (MaterialMessageBox.Show("Are you sure you want Checkout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("INSERT INTO producttransaction (product_id, Quantity, pTransac_total, employee_id) VALUES (@pname, @Qty, @ptotal, @emp)", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@pname", product_ID.Text);
                cmd.Parameters.AddWithValue("@Qty", textBox2.Text);
                cmd.Parameters.AddWithValue("@ptotal", TransacTotal.Text);
                cmd.Parameters.AddWithValue("@emp", employee_ID.Text);
                cmd.ExecuteNonQuery();
                dbConnect.CloseConnection();
                productName.SelectedIndex = 0;
                TransacTotal.Clear();
                employee_Name.SelectedIndex = 0;



                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE product SET product_stock = product_stock-@num WHERE product_id = @ID", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@num", num);
                cmd.Parameters.AddWithValue("@ID", product_ID.Text);
                cmd.ExecuteNonQuery();
                dbConnect.CloseConnection();
            }
            Visible = false;
        }

        private void productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT product_stock FROM product WHERE product_name = '" + productName.Text + "'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                productStock.Text = myReader["product_stock"].ToString();
            }


            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT product_id FROM product WHERE product_name = '" + productName.Text + "'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                product_ID.Text = myReader["product_id"].ToString();
            }
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT product_name FROM product", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["product_name"].ToString();

                if (!productName.Items.Contains(itemName))
                {
                    productName.Items.Add(itemName);

                }
            }

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT employee_fname FROM employee", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string itemName = myReader["employee_fname"].ToString();

                if (!employee_Name.Items.Contains(itemName))
                {
                    employee_Name.Items.Add(itemName);

                }
            }
        }

        private void employee_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT employee_id FROM employee WHERE employee_fname = '" + employee_Name.Text + "'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                employee_ID.Text = myReader["employee_id"].ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int num5;
            int num6;
            int num7;


            dbConnect = new Conclass();
            dbConnect.OpenConnection();

            try
            {

                string query = "SELECT product_price FROM product WHERE product_id = @productId";
                cmd = new MySqlCommand(query, dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@productId", product_ID.Text);

                using (myReader = cmd.ExecuteReader())
                {
                    if (myReader.Read())
                    {
                        productPrice.Text = myReader["product_price"].ToString();
                    }
                }


                num5 = Convert.ToInt32(productPrice.Text);
                num6 = Convert.ToInt32(textBox2.Text);


                num7 = num5 * num6;
                TransacTotal.Text = num7.ToString();
            }
            catch (Exception ex)
            {

                MaterialMessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {

                dbConnect.CloseConnection();
            }
        }
    }
}
