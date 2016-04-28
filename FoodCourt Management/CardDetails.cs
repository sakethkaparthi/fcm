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
    
    public partial class CardDetails : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        string regno;
        public CardDetails(string regn)
        {
            InitializeComponent();
            this.regno = regn;
            connect();
            comm = new OracleCommand();
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from card where card_no = '" + regno.Substring(regno.Length -5) + "'";
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "card");
            dt = ds.Tables["card"];
            dr = dt.Rows[0];
            number.Text = dr["card_no"].ToString();
            balance.Text = dr["balance"].ToString();
            status.Text = dr["status"].ToString();
        }
        public void connect()
        {
            string oradb = "Data Source=localhost;User ID=dbsproj;Password=password";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
    }
}
