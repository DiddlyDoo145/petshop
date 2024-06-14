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
    public partial class storeCategory : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        public storeCategory()
        {
            InitializeComponent();
            populategv();
        }

        private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT pTransac_id, product_name, pTransac_total, employee_fname FROM producttransaction JOIN product ON producttransaction.product_id = product.product_id JOIN employee ON producttransaction.employee_id = employee.employee_id", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            ProductTransactionTable.DataSource = dt;
            ProductTransactionTable.Columns[0].Visible = false;
            DataGridViewColumn column1 = ProductTransactionTable.Columns["product_name"];
            DataGridViewColumn column2 = ProductTransactionTable.Columns["pTransac_total"];
            DataGridViewColumn column3 = ProductTransactionTable.Columns["employee_fname"];
            ProductTransactionTable.Columns[1].HeaderText = "Product Name";
            ProductTransactionTable.Columns[2].HeaderText = "Transaction Total";
            ProductTransactionTable.Columns[3].HeaderText = "Employee Name";
        }

        private void SaveProducts_Click(object sender, EventArgs e)
        {
            int num1;

            num1 = Convert.ToInt32(producttotal.Text);
            
            if (productName.Text == "Select Category")
            {
                errorProvider1.SetError(productName, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(productName, string.Empty);
            }
            if (string.IsNullOrEmpty(producttotal.Text.Trim()))
            {
                errorProvider2.SetError(producttotal, "Please Select Category");
                return;
            }
            else
            {
                errorProvider2.SetError(producttotal, string.Empty);
            }
            if (employee.Text == "SELECT CATEGORY")
            {
                errorProvider3.SetError(employee, "Please Input this field");
                return;
            }
            else
            {
                errorProvider3.SetError(employee, string.Empty);
            }

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("INSERT INTO producttransaction (product_id, pTransac_total, employee_id) VALUES ('"+product_ID.Text+"', '"+producttotal.Text+"', '"+employeeID.Text+"')", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            MessageBox.Show("Added Successfully", "Success!!");
            productName.SelectedIndex = 0;
            producttotal.Clear();
            employee.SelectedIndex = 0;


            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("UPDATE product SET product_stock = product_stock-@num1 WHERE product_id = '"+product_ID.Text+"'", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@num1", num1);
            myReader = cmd.ExecuteReader();
            populategv();
        }

        private void productName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT product_id FROM product WHERE product_name = '"+productName.Text+"'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if(myReader.Read() == true)
            {
                product_ID.Text = myReader["product_id"].ToString();
            }


        }

        private void storeCategory_Load(object sender, EventArgs e)
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

                if (!employee.Items.Contains(itemName))
                {
                    employee.Items.Add(itemName);

                }
            }
            productName.SelectedIndex = 0;
            employee.SelectedIndex = 0;
        }

        private void employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT employee_id FROM employee WHERE employee_fname = '"+employee.Text+"'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            if(myReader.Read() == true) 
            {
                employeeID.Text = myReader["employee_id"].ToString();
            }
        }

        private void ProductTransactionTable_MouseClick(object sender, MouseEventArgs e)
        {
            pTransac_id.Text = ProductTransactionTable.CurrentRow.Cells[0].Value.ToString();
            productName.Text = ProductTransactionTable.CurrentRow.Cells[1].Value.ToString();
            producttotal.Text = ProductTransactionTable.CurrentRow.Cells[2].Value.ToString();
            employee.Text = ProductTransactionTable.CurrentRow.Cells[3].Value.ToString();
        }

        private void EditProducts_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("UPDATE producttransaction SET product_id = '"+product_ID.Text+"', pTransac_total = '"+producttotal.Text+"', employee_id = '"+employeeID.Text+"' WHERE pTransac_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", pTransac_id.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully", "Success");
            populategv();
            productName.SelectedIndex = 0;
            producttotal.Clear();
            employee.SelectedIndex = 0;
        }

        private void product_total_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void DeleteProducts_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("DELETE FROM producttransaction WHERE pTransac_id = @id", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", pTransac_id.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted Successfully", "Success!!");
            populategv();
            productName.SelectedIndex = 0;
            producttotal.Clear();
            employee.SelectedIndex = 0;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            populategv();
            productName.SelectedIndex = 0;
            producttotal.Clear();
            employee.SelectedIndex = 0;
            product_ID.ResetText();
            employeeID.ResetText();
            pTransac_id.ResetText();
        }
    }
}
