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
    
    public partial class FeedbackForm : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public FeedbackForm()
        {
            InitializeComponent();
        }
        public void connect()
        {
            string oradb = "Data Source=localhost;User ID=dbsproj;Password=password";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void submitbutton_Click(object sender, EventArgs e)
        {
            connect();
            string id = idtb.Text;
            string fb = feedbacktb.Text;
            double rating = double.Parse(ratingtb.Text);
            comm = new OracleCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from feedback";
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "feedback");
            dt = ds.Tables["feedback"];
            int fid = dt.Rows.Count;
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into feedback values("
                + fid + ",'"
                + id + "','"
                + fb + "',"
                + rating+")";
            cm.CommandType = CommandType.Text;
            try { 
            cm.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Error");
                return;
            }
            MessageBox.Show("Submitted!");
            conn.Close();
        }
    }
}
