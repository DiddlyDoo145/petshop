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
            mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM productcategory", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            pCategory.DataSource = dt;
            pCategory.Columns[0].Visible = true;
            DataGridViewColumn column1 = pCategory.Columns["pCategory_name"];
            pCategory.Columns[0].HeaderText = "Category ID";
            pCategory.Columns[1].HeaderText = "Product Category";
          
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pCategoryName.Text.Trim()))
            {
                errorProvider1.SetError(pCategoryName, "Please Input this field");
                return;
            }
            else
            {
                errorProvider1.SetError(pCategoryName, string.Empty);
            }
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("INSERT INTO productcategory (pCategory_name) VAlUES (@pCname)", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@pCname", pCategoryName.Text);
            cmd.ExecuteNonQuery();
            MaterialMessageBox.Show("New Product Category Successfully Added", "Success");
            pCategoryName.Clear();
            populategv();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("UPDATE productcategory SET pCategory_name = @Cname WHERE pCategory_id = @uid", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@uid", CategoryID.Text);
            cmd.Parameters.AddWithValue("@Cname", pCategoryName.Text);
            cmd.ExecuteNonQuery();
            MaterialMessageBox.Show("Updated Successfully", "Success");
            pCategoryName.Clear();
            populategv();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("DELETE FROM productcategory WHERE pCategory_id = @did", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@did", CategoryID.Text);
            cmd.ExecuteNonQuery();
            MaterialMessageBox.Show("Deleted Successfully", "Success");
            pCategoryName.Clear();
            populategv();
        }

        private void pCategory_MouseClick(object sender, MouseEventArgs e)
        {
            CategoryID.Text = pCategory.SelectedRows[0].Cells[0].Value.ToString();
            pCategoryName.Text = pCategory.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
