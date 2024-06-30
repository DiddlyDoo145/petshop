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
    public partial class assignCashier : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        public assignCashier()
        {
            InitializeComponent();
        }

        private void assignCashier_Load(object sender, EventArgs e)
        {
            employeeCb.SelectedIndex = 0;
            loadEmployee();
        }
        private void loadEmployee()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee_fname FROM employee WHERE position_id !='6'", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while(myReader.Read())
            {
                employeeCb.Items.Add(myReader["employee_fname"].ToString());
            }
        }

        private void employeeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(employeeCb.SelectedIndex > 0)
            {
                Cashier.instance.cashierName.Text = employeeCb.SelectedItem.ToString();
                getEmployeeID();
                Home.instance.closeForm();
                BlurBg bbg = new BlurBg();
                bbg.Size = new Size(1400, 782);
                bbg.Visible = true;
                bbg.BringToFront();
                BlurBg.instance.pickCashier = false;
                BlurBg.instance.employeeManage = true;
                BlurBg.instance.BlurBg_Load(null, null);
            }
        }
        private void getEmployeeID()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT employee_id FROM employee WHERE employee_fname = @name", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@name", employeeCb.SelectedItem.ToString());
            myReader = cmd.ExecuteReader();
            if(myReader.Read())
            {
                Cashier.instance.ID.Text = myReader["employee_id"].ToString();
            }
        }
    }
}
