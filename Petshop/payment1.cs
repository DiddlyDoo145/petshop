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
    public partial class payment1 : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        string stock;

        public payment1()
        {
            InitializeComponent();
            populategv();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populategv()
        {


        }

        private void payment1_Load(object sender, EventArgs e)
        {
            ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Visible = false;
            textBox2.Visible = true;
            DGV4.Visible = true;
            DGV2.Visible = false;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT product_name AS NAME, product_price AS PRICE, product_stock AS STOCK FROM product", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            DGV4.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            textBox2.Visible = false;
            DGV4.Visible = false;
            DGV2.Visible = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT service_name AS NAME, size AS SIZE, service_price AS PRICE FROM services", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            DGV2.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "SEARCH")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "SEARCH";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT  product_name AS NAME, product_price AS PRICEF, product_stock AS STOCK FROM product WHERE product_name LIKE '%" + textBox2.Text + "%'", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            DGV4.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            DataTable dt = new DataTable();
            mySqlDataAdapter = new MySqlDataAdapter("SELECT  service_name AS NAME, size AS SIZE, service_price AS PRICE FROM services WHERE service_name LIKE '%" + textBox5.Text + "%'", dbConnect.myconnect);
            mySqlDataAdapter.Fill(dt);
            DGV2.DataSource = dt;
            dbConnect.CloseConnection();
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "SEARCH")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "SEARCH";
                textBox5.ForeColor = Color.Silver;
            }
        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = DGV2.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void DGV4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = DGV4.Rows[e.RowIndex].Cells[0].Value.ToString();
            stock = DGV4.Rows[e.RowIndex].Cells[2].Value.ToString();
            if(stock == "0")
            {
                MaterialMessageBox.Show("Out of stock");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = 1; int num2 = 1; int num3; string num4;
            num3 = num1 + num2;
            num3 = Convert.ToInt32(textBox4.Text);
            num4 = Convert.ToString(num3);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // payment1
            // 
            this.ClientSize = new System.Drawing.Size(991, 401);
            this.Name = "payment1";
            this.ResumeLayout(false);

        }
    }
}
