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
    public partial class StudentDetails : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string regno;
        public StudentDetails(string regno)
        {
            InitializeComponent();
            this.regno = regno;
            connect();
            comm = new OracleCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from student where reg_no = '"+regno+"'";
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "student");
            dt = ds.Tables["student"];
            dr = dt.Rows[0];
            regnolabel.Text = dr["reg_no"].ToString();
            namelabel.Text = dr["firstname"].ToString();
            phno.Text = dr["phone"].ToString();
            addresstb.Text = dr["address"].ToString();
        }
        public void connect()
        {
            string oradb = "Data Source=localhost;User ID=dbsproj;Password=password";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update student set phone='" + phno.Text + "',address = '"
                + addresstb.Text + "' where reg_no='" + regnolabel.Text + "'";
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
        }

        private void cardbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CardDetails(regno).Show();
        }
    }
}
