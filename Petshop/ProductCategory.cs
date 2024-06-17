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
    
    public partial class productcategory : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        public productcategory()
        {
            InitializeComponent();
            populategv();
        }

        private void populategv()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM productcategory WHERE pCategory_name != 'NULL'", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            pCategory.DataSource = dt;
            pCategory.Columns[0].Visible = true;
            DataGridViewColumn column1 = pCategory.Columns["pCategory_name"];
            pCategory.Columns[0].HeaderText = "Category ID";
            pCategory.Columns[1].HeaderText = "Product Category";
            dbConnect.CloseConnection();
          
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(prodCategory.Text.Trim()))
            {
                errorProvider1.SetError(prodCategory, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(prodCategory, string.Empty);
            }
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT * FROM productcategory WHERE pCategory_name = @Cname", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@Cname", prodCategory.Text);
            myReader = cmd.ExecuteReader();
            if(myReader.Read() == true)
            {
                MaterialMessageBox.Show("Product Category Already exist", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dbConnect.CloseConnection();
                return;
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("INSERT INTO productcategory (pCategory_name) VAlUES (@pCname)", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@pCname", prodCategory.Text);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("New Product Category Successfully Added", "Success");
                prodCategory.Clear();
                populategv();
                dbConnect.CloseConnection();
            }


          
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("UPDATE productcategory SET pCategory_name = @Cname WHERE pCategory_id = @uid", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@uid", CategoryID.Text);
            cmd.Parameters.AddWithValue("@Cname", prodCategory.Text);
            cmd.ExecuteNonQuery();
            MaterialMessageBox.Show("Updated Successfully", "Success");
            prodCategory.Clear();
            populategv();
            dbConnect.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MaterialMessageBox.Show("Are you sure you want to update this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE product SET pCategory_id = 8 WHERE pCategory_id = @did", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@did", CategoryID.Text);
                cmd.ExecuteNonQuery();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("DELETE FROM productcategory WHERE pCategory_id = @did", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@did", CategoryID.Text);
                cmd.ExecuteNonQuery();
                MaterialMessageBox.Show("Deleted Successfully", "Success");
                prodCategory.Clear();
                populategv();
                dbConnect.CloseConnection();
            }
        }

        private void pCategory_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void pCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

            }
            else
            {
                CategoryID.Text = pCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                prodCategory.Text = pCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
