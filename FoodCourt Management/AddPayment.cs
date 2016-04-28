using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace FoodCourt_Management
{
    public partial class AddPayment : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public AddPayment()
        {
            InitializeComponent();
        }

        public void connect()
        {
            string oradb = "Data Source=localhost;User ID=dbsproj;Password=password";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void sumbitButton_Click(object sender, EventArgs e)
        {
            connect();
            comm = new OracleCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from payment";
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "payment");
            dt = ds.Tables["payment"];
            int pid = dt.Rows.Count;
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;

            DateTime d = System.DateTime.Today.Date;
            Console.WriteLine("Today is " + d.ToString("dd-MMM-yyyy"));
            cm.CommandText = "insert into payment values("
                + pid + ","
                + amountTb.Text + ",'"
                + d.ToString("dd-MMM-yyyy") + "','"
                + sidTb.Text + "')";
            cm.CommandType = CommandType.Text;
            try
            {
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return;
            }
            MessageBox.Show("Updated!");
            conn.Close();
        }
    }
}
