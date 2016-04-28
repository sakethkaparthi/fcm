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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void studreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentRegistration().Show();
        }

        private void empreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Employee_Registration().Show();
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FeedbackForm().Show();
        }

        private void studetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            new studentLogin().Show();
        }
    }
}
