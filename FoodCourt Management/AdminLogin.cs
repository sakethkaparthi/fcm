using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourt_Management
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string id = userNameTb.Text;
            string pw = passwordTb.Text;
            if(id.Equals("admin") && pw.Equals("admin"))
            {
                AdminPanel a = new AdminPanel();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("Invalid details! Authorised access only");
            }
        }
    }
}
