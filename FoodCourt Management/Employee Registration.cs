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
    public partial class Employee_Registration : Form
    {
        OracleConnection conn;
        public Employee_Registration()
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
            string f = fname.Text;
            string m = mname.Text;
            string l = lname.Text;
            string reg = regno.Text;
            string theDate = datepicker.Value.ToString("dd-MMM-yyyy");
            string add = address.Text;
            string phone = phno.Text;
            string course = designation.Text;
            int salary = int.Parse(sal.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into staff values('"
                + reg + "','"
                + f + "','"
                + m + "','"
                + l + "','"
                + theDate + "','"
                + course + "',"
                + salary + ",'"
                + phone + "','"
                + add + "')";
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
            conn.Close();
        }
    }
}
