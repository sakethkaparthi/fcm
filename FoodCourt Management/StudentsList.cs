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
    public partial class StudentsList : Form
    {
        public StudentsList()
        {
            InitializeComponent();
        }

        private void StudentsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.student.STUDENT);

        }
    }
}
