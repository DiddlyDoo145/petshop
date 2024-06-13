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
            #region commment
            /*// Add the control to the panel
            panel1.Controls.Add(FormsPlot1);

            // Plot data using the control
            double[] data = ScottPlot.Generate.Sin();
            FormsPlot1.Plot.Add.Signal(data);
            FormsPlot1.Refresh();*/
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 /*           double val1 = 0, val2 = 0, comp = 0;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();

            cmd = new MySqlCommand("SELECT DATE_FORMAT(pDate, '%d-%m-%y'), SUM(pTransac_total) FROM producttransaction GROUP BY pDate", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                double sum = (double)myReader["SUM(pTransac_total)"];
                var pDate = myReader["DATE_FORMAT(pDate, '%d-%m-%y')"].ToString();
                chart1.Series["Salary"].Points.AddXY(pDate, sum);
            }
            myReader.Dispose();

            cmd = new MySqlCommand("SELECT SUM(pTransac_total) FROM producttransaction WHERE DATE(pDATE) = CURDATE()", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
                val1 = (double)myReader["SUM(pTransac_total)"];
            myReader.Dispose();

            cmd = new MySqlCommand("SELECT SUM(pTransac_total) FROM producttransaction WHERE DATE(pDATE) = CURDATE()-1", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
                val2 = (double)myReader["SUM(pTransac_total)"];
            myReader.Dispose();

            comp = val2 - val1;
            if (val2 < val1)
                comp = (val2 - val1) / val1 * 100;
            else
            {
                comp = (val1 - val2) / val1 * 100;
                label5.ForeColor = System.Drawing.Color.Red;
            }

            label3.Text = "$" + val1.ToString();
            label4.Text = "$" + val2.ToString();
            label5.Text = comp.ToString() + "%";




            dbConnect.CloseConnection();*/
            #region comment
            /*chart1.Series["Salary"].Points.AddXY("Mon", 1000);
            chart1.Series["Salary"].Points.AddXY("Tue", 5000);
            chart1.Series["Salary"].Points.AddXY("Wed", 1500);
            chart1.Series["Salary"].Points.AddXY("Thu", 7000);
            chart1.Series["Salary"].Points.AddXY("Fri", 7000);
            chart1.Series["Salary"].Points.AddXY("Sat", 7000);
            chart1.Series["Salary"].Points.AddXY("Today", 7000);*/
            /*chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.White;*/
            #endregion
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
