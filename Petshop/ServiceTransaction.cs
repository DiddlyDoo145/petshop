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
    public partial class ServiceTransaction : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;
        string petID;
        string serviceID;
        string employeeID;
        string serviceName;
        string StID;
        public ServiceTransaction()
        {
            InitializeComponent();
            populategv();
        }

        private void populategv()
        {
           
        }

        private void ServiceTransaction_Load(object sender, EventArgs e)
        {
           

        }

        private void pettype_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ServicesSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void serviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void employee_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        
        }

        private void serviceTtble_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
