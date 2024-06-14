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
    public partial class ProductTransac : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        string id;
        public ProductTransac()
        {
            InitializeComponent();
            populategv();
        }

        private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT pTransac_id, product_name, Quantity, pTransac_total, employee_fname FROM producttransaction JOIN product ON producttransaction.product_id = product.product_id JOIN employee ON producttransaction.employee_id = employee.employee_id WHERE Quantity > 0 OR pTransac_total > 0", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            TransacTable.DataSource = dt;
            TransacTable.Columns[0].Visible = false;


        }

        private void productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT product_stock FROM product WHERE product_name = @prDname", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@prDname", productName.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                productStock.Text = myReader["product_stock"].ToString();
            }


            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT product_id FROM product WHERE product_name = @prName", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@prName", productName.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                product_ID.Text = myReader["product_id"].ToString();
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            int num;
            int num1;

            if (productName.Text == "SELECT CATEGORY")
            {
                errorProvider1.SetError(productName, "Please Select a Category");
                return;
            }
            else
            {
                errorProvider1.SetError(productName, string.Empty);
            }
            if (string.IsNullOrEmpty(qty.Text.Trim()))
            {
                errorProvider2.SetError(qty, "Please Input this field");
                return;
            }
            else
            {
                errorProvider2.SetError(qty, string.Empty);
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
                errorProvider4.SetError(employee_Name, "Please Input this field");
                return;
            }
            else
            {
                errorProvider4.SetError(employee_Name, string.Empty);
            }


            num1 = Convert.ToInt32(productStock.Text);
            num = Convert.ToInt32(qty.Text);


            if (num <= 0)
            {
                MaterialMessageBox.Show("Please Input proper quantity of the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (num1 < num || num == 0)
            {
                MaterialMessageBox.Show("Product Don't Have Enough Stock", "Notice!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                /* dbConnect = new Conclass();
                 dbConnect.CloseConnection();
                 cmd = new MySqlCommand("SELECT * FROM producttransaction WHERE product_name = @uname AND Quantity = 0 AND pTransac_total = 0");
                 cmd.Parameters.AddWithValue("@uname", productName.Text);
                 myReader = cmd.ExecuteReader();
                 if (myReader.Read() == true)
                 {
                     dbConnect = new Conclass();
                     dbConnect.OpenConnection();
                     cmd = new MySqlCommand("UPDATE producttransaction SET Quantity = @qty. pTransac_total = @ptotal WHERE product_name = @pname AND Quantity = 0 AND pTransac_total = 0", dbConnect.myconnect);
                     cmd.Parameters.AddWithValue("@qty", qty.Text);
                     cmd.Parameters.AddWithValue("@ptotal", TransacTotal.Text);
                     cmd.Parameters.AddWithValue("@pname", productName.Text);
                     cmd.ExecuteNonQuery();

                     dbConnect = new Conclass();
                     dbConnect.OpenConnection();
                     cmd = new MySqlCommand("UPDATE product SET product_stock = product_stock-@num WHERE product_id = @ID", dbConnect.myconnect);
                     cmd.Parameters.AddWithValue("@num", num);
                     cmd.Parameters.AddWithValue("@ID", product_ID.Text);
                     cmd.ExecuteNonQuery();
                     dbConnect.CloseConnection();
                 }
 */
                if (MaterialMessageBox.Show(TransacTotal.Text, "Checkout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("INSERT INTO producttransaction (product_id, Quantity, pTransac_total, employee_id) VALUES (@pname, @stk, @ptotal, @emp)", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@pname", product_ID.Text);
                    cmd.Parameters.AddWithValue("@stk", qty.Text);
                    cmd.Parameters.AddWithValue("@ptotal", TransacTotal.Text);
                    cmd.Parameters.AddWithValue("@emp", employee_ID.Text);
                    cmd.ExecuteNonQuery();
                    dbConnect.CloseConnection();
                    productName.SelectedIndex = 0;
                    TransacTotal.Clear();
                    employee_Name.SelectedIndex = 0;
                    qty.Clear();
                    id = "";
                    populategv();



                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE product SET product_stock = product_stock-@num WHERE product_id = @ID", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.Parameters.AddWithValue("@ID", product_ID.Text);
                    cmd.ExecuteNonQuery();
                    dbConnect.CloseConnection();
                }
            }


        }

        private void ProductTransac_Load(object sender, EventArgs e)
        {
            productName.SelectedIndex = 0;
            employee_Name.SelectedIndex = 0;
            id = "";

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
            cmd = new MySqlCommand("SELECT employee_id FROM employee WHERE employee_fname = @empname", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@empname", employee_Name.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read() == true)
            {
                employee_ID.Text = myReader["employee_id"].ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int num5;
            int num6;
            int num7;

            if (qty.Text == "")
            {
                TransacTotal.Text = "";
            }
            dbConnect = new Conclass();
            dbConnect.OpenConnection();

            try
            {

                cmd = new MySqlCommand("SELECT product_price FROM product WHERE product_id = @productId", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@productId", product_ID.Text);
                myReader = cmd.ExecuteReader();
                {
                    if (myReader.Read())
                    {
                        productPrice.Text = myReader["product_price"].ToString();
                    }
                }


                num5 = Convert.ToInt32(productPrice.Text);
                num6 = Convert.ToInt32(qty.Text);


                num7 = num5 * num6;
                TransacTotal.Text = num7.ToString();

            }
            catch (Exception ex)
            {


            }
            finally
            {

                dbConnect.CloseConnection();
            }

        }

        private void TransacTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                productName.Text = TransacTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                qty.Text = TransacTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                TransacTotal.Text = TransacTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                employee_Name.Text = TransacTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (productName.Text == "")
                {
                    id = "";
                }
                else
                {
                    id = TransacTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int num;
            int num1;




            if (id != "")
            {
                num1 = Convert.ToInt32(productStock.Text);
                num = Convert.ToInt32(qty.Text);

                if (num <= 0)
                {
                    MaterialMessageBox.Show("Please Input proper quantity of the product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (num1 < num || num == 0)
                {
                    MaterialMessageBox.Show("Product Don't Have Enough Stock", "Notice!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MaterialMessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE producttransaction SET product_id = @upID, Quantity = @uqty, pTransac_total = @utotal, employee_id = @uempID WHERE pTransac_id = @Tid", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@Tid", id);
                    cmd.Parameters.AddWithValue("@upID", product_ID.Text);
                    cmd.Parameters.AddWithValue("@uqty", qty.Text);
                    cmd.Parameters.AddWithValue("@utotal", TransacTotal.Text);
                    cmd.Parameters.AddWithValue("@uemPID", employee_ID.Text);
                    cmd.ExecuteNonQuery();
                    MaterialMessageBox.Show("Updated Successfully");
                    dbConnect.CloseConnection();
                    productName.SelectedIndex = 0;
                    TransacTotal.Clear();
                    employee_Name.SelectedIndex = 0;
                    qty.Clear();
                    id = "";
                    populategv();

                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    cmd = new MySqlCommand("UPDATE product SET product_stock = product_stock-@num WHERE product_id = @ID", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@num", num);
                    cmd.Parameters.AddWithValue("@ID", product_ID.Text);
                    cmd.ExecuteNonQuery();
                    dbConnect.CloseConnection();
                }
            }
            else
            {
                MaterialMessageBox.Show("Please Select Data to Update", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id != "")
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE producttransaction SET Quantity = 0, pTransac_total = 0 WHERE pTransac_id = @dTid", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@dTid", id);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Deleted Successfully");
                dbConnect.CloseConnection();
                productName.SelectedIndex = 0;
                TransacTotal.Clear();
                employee_Name.SelectedIndex = 0;
                qty.Clear();
                id = "";
                populategv();
            }
            else
            {
                MaterialMessageBox.Show("Please Select Data to Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
