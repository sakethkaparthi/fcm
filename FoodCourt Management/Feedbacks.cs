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
    public partial class Feedbacks : Form
    {
        public Feedbacks()
        {
            InitializeComponent();
        }

        private void Feedbacks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.FEEDBACK' table. You can move, or remove it, as needed.
            this.fEEDBACKTableAdapter.Fill(this.dataSet2.FEEDBACK);

        }
    }
}
