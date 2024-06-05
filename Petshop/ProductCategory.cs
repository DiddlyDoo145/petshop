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
    public partial class ProductCategory : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        public ProductCategory()
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
            category.DataSource = dt;
            dbConnect.CloseConnection();

        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("INSERT INTO `productcategory`(`pCategory_name`) VALUES ('"+PCategory.Text+"')", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            MessageBox.Show("Added Successfully");
            dbConnect.CloseConnection();
            PCategory.Clear();
            populategv();
        }

        private void category_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = category.CurrentRow.Cells[0].Value.ToString();
            PCategory.Text = category.CurrentRow.Cells[1].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("UPDATE productcategory SET pCategory_name = '" + PCategory.Text + "' WHERE pCAtegory_id = '" + label2.Text + "'", dbConnect.myconnect);
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Updated Successfully", "Success");
                dbConnect.CloseConnection();
                PCategory.Clear();
                populategv();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                cmd = new MySqlCommand("DELETE FROM productcategory WHERE pCategory_id = @id", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@id", label2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "Success");
                PCategory.Clear();
                populategv();
            }
              
        }
    }
}
