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
   
    public partial class BlockCard : Form
    {
        OracleConnection conn;
        OracleCommand comm;

        public BlockCard()
        {
            InitializeComponent();
        }
        public void connect()
        {
            string oradb = "Data Source=localhost;User ID=dbsproj;Password=password";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        private void blockButton_Click(object sender, EventArgs e)
        {
            connect();
            string cn = CardNo.Text;
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update card set status='blocked' where card_no =" +cn+" ";
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
            MessageBox.Show("Blocked!");
            conn.Close();
        }

        private void unblockButton_Click(object sender, EventArgs e)
        {
            connect();
            string cn = CardNo.Text;
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update card set status='active' where card_no =" + cn + " ";
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
            MessageBox.Show("Un Blocked!");
            conn.Close();
        }
    }
}
