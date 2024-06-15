using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Practice1;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;
using Org.BouncyCastle.Tls;

namespace ScottPlot
{
    public partial class Analytics : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        private MySqlDataAdapter mySqlDataAdapter;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Analytics()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*// Add the control to the panel
            panel1.Controls.Add(FormsPlot1);

            // Plot data using the control
            double[] data = ScottPlot.Generate.Sin();
            FormsPlot1.Plot.Add.Signal(data);
            FormsPlot1.Refresh();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double val1 = 0, val2 = 0, comp = 0;

           /* #region load
            load_SalesChart();
            load_PieChart();

            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            cmd = new MySqlCommand("SELECT SUM(pTransac_total) FROM producttransaction WHERE DATE(pDATE) = CURDATE()", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                try
                {
                    val1 = (double)myReader["SUM(pTransac_total)"];
                }
                catch { };
            }
            myReader.Dispose();

            cmd = new MySqlCommand("SELECT SUM(pTransac_total) FROM producttransaction WHERE DATE(pDATE) = CURDATE()-1", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                try
                {
                    val2 = (double)myReader["SUM(pTransac_total)"];
                }
                catch { };
            }
            myReader.Dispose();

            comp = val2 - val1;
            if (val1 == 0)
                comp = 0;
            else if (val2 < val1)
            {
                comp = (val1 - val2) / val2 * 100;
                label5.Text = "+" + comp.ToString("N2") + "%";
            }
            else
            {
                comp = (val2 - val1) / val2 * 100;
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "-" + comp.ToString("N2") + "%";
            }

            label3.Text = "$" + val1.ToString("N2");
            label4.Text = "$" + val2.ToString("N2");




            dbConnect.CloseConnection();
            #endregion*/

            /*chart1.Series["Salary"].Points.AddXY("Mon", 1000);
            chart1.Series["Salary"].Points.AddXY("Tue", 5000);
            chart1.Series["Salary"].Points.AddXY("Wed", 1500);
            chart1.Series["Salary"].Points.AddXY("Thu", 7000);
            chart1.Series["Salary"].Points.AddXY("Fri", 7000);
            chart1.Series["Salary"].Points.AddXY("Sat", 7000);
            chart1.Series["Salary"].Points.AddXY("Today", 7000);*/
            /*chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.White;*/
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_SalesChart()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            chart1.Series["Sales"].Points.Clear();

            cmd = new MySqlCommand("SELECT DATE_FORMAT(pDate, '%d-%m-%y'), SUM(pTransac_total) FROM producttransaction GROUP BY pDate", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                double sum = (double)myReader["SUM(pTransac_total)"];
                var pDate = myReader["DATE_FORMAT(pDate, '%d-%m-%y')"].ToString();

                DataPoint point = new DataPoint();
                point.SetValueXY(pDate, sum);
                point.ToolTip = string.Format("{0}, {1}", pDate, sum);
                chart1.Series["Sales"].Points.Add(point);

            }
            myReader.Dispose();
            dbConnect.CloseConnection();

            chart1.Visible = true;
            chart3.Visible = false;
            chart4.Visible = false;

            cHighlight1.Visible = true;
            cHighlight2.Visible = false;
            cHighlight3.Visible = false;
        }

        private void load_CustChart()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            chart3.Series["Customers"].Points.Clear();

            cmd = new MySqlCommand("SELECT DATE_FORMAT(cust_date, '%d-%m-%y'), COUNT(cust_id) FROM customer GROUP BY DATE(cust_date)", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                var sum = myReader["COUNT(cust_id)"].ToString();
                var pDate = myReader["DATE_FORMAT(cust_date, '%d-%m-%y')"].ToString();

                DataPoint point = new DataPoint();
                point.SetValueXY(pDate, sum);
                point.ToolTip = string.Format("{0}, {1}", pDate, sum);
                chart3.Series["Customers"].Points.Add(point);

            }
            myReader.Dispose();
            dbConnect.CloseConnection();

            chart1.Visible = false;
            chart3.Visible = true;
            chart4.Visible = false;

            cHighlight1.Visible = false;
            cHighlight2.Visible = true;
            cHighlight3.Visible = false;
        }

        private void load_PieChart()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            chart2.Series["Pie"].Points.Clear();


            cmd = new MySqlCommand("SELECT p.product_name, COUNT(*) FROM producttransaction pt LEFT JOIN product p ON p.product_id = pt.product_id GROUP BY p.product_id, p.product_name", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string name = myReader["product_name"].ToString();
                int count = Convert.ToInt32(myReader["COUNT(*)"]);

                chart2.Series["Pie"].Points.AddXY(name, count);

            }
            myReader.Dispose();
            dbConnect.CloseConnection();

            chart1.Visible = true;
            chart3.Visible = false;
            chart4.Visible = false;

            cHighlight1.Visible = true;
            cHighlight2.Visible = false;
            cHighlight3.Visible = false;
        }

        private void load_ProfitChart()
        {
            /*dbConnect = new Conclass();
            dbConnect.OpenConnection();
            chart3.Series["Customers"].Points.Clear();

            cmd = new MySqlCommand("SELECT DATE_FORMAT(cust_date, '%d-%m-%y'), COUNT(cust_id) FROM customer GROUP BY DATE(cust_date)", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                var sum = myReader["COUNT(cust_id)"].ToString();
                var pDate = myReader["DATE_FORMAT(cust_date, '%d-%m-%y')"].ToString();

                DataPoint point = new DataPoint();
                point.SetValueXY(pDate, sum);
                point.ToolTip = string.Format("{0}, {1}", pDate, sum);
                chart3.Series["Customers"].Points.Add(point);

            }
            myReader.Dispose();
            dbConnect.CloseConnection();*/

            chart1.Visible = false;
            chart3.Visible = false;
            chart4.Visible = true;

            cHighlight1.Visible = false;
            cHighlight2.Visible = false;
            cHighlight3.Visible = true;
        }

        private void cPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            load_SalesChart();   
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            load_CustChart();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            load_ProfitChart();
        }
    }
}
