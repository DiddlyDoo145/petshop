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
    public partial class attendance : UserControl
    {
        private Conclass dbConnect;
        private MySqlDataReader myReader, myReader1, myReader2;
        public Label _Name;
        public Label _Desc;
        public Label _Id;
        public PictureBox _Img;
        private DateTime _Date = DateTime.Now;
        public attendance()
        {
            InitializeComponent();
            _Name = empName;
            _Desc = empDesc;
            _Id = empId;
        }
        #region Properties

        private Color _imgBack;
        private string _name;
        private string _id;
        private string _desc;
        private Image _img;

        [Category("Custom Props")]
        public string employeeName
        {
            get { return _name; }
            set { _name = value; empName.Text = value; }
        }

        private void present_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attendance WHERE employee_id = @id AND attendance_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", empId.Text);
            cmd.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                MessageBox.Show("Employee attendance have already been marked for today", "Notice!");
            }
            else
            {
                string status = "Present";
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO attendance VALUES('', @empid, @date, @stat)", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@empid", empId.Text);
                cmd1.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
                cmd1.Parameters.AddWithValue("@stat", status);
                int insert = cmd1.ExecuteNonQuery();
                if (insert > 0)
                {
                    MessageBox.Show("Employee attendance set to present");
                }
            }
        }

        private void absent_Click(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM attendance WHERE employee_id = @id AND attendance_date = @date", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@id", empId.Text);
            cmd.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                MessageBox.Show("Employee attendance have already been marked for today", "Notice!");
            }
            else
            {
                string status = "Absent";
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO attendance VALUES('', @empid, @date, @stat)", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@empid", empId.Text);
                cmd1.Parameters.AddWithValue("@date", _Date.ToString("MM-dd-yyyy"));
                cmd1.Parameters.AddWithValue("@stat", status);
                int insert = cmd1.ExecuteNonQuery();
                if (insert > 0)
                {
                    MessageBox.Show("Employee attendance set to present");
                }
            }
        }

        [Category("Custom Props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; empId.Text = value; }
        }


        [Category("Custom Props")]
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; empDesc.Text = value; }
        }
        #endregion
    }
}
