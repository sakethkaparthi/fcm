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
    public partial class StudentRegistration : Form
    {
        OracleConnection conn;
        public StudentRegistration()
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
            int cno = int.Parse(reg.Substring(reg.Length - 5));    
            string theDate = datepicker.Value.ToString("dd-MMM-yyyy");
            string add = address.Text;
            string phone = phno.Text;
            int course = coursebox.SelectedIndex;
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into student values('"
                + reg + "','"
                + f + "','"
                + m + "','"
                + l + "','"
                + theDate + "',"
                + course + ",'"
                + phone + "','"
                + add + "')";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            cm.CommandText = "insert into card values(" + cno + ",0" + ",'active')";
            cm.ExecuteNonQuery();
            MessageBox.Show("Your card number is " + cno);
            conn.Close();
        }
    }
}
