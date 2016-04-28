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
    public partial class FoodItems : Form
    {
        public FoodItems()
        {
            InitializeComponent();
        }

        private void FoodItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet6.FOODMENU' table. You can move, or remove it, as needed.
            this.fOODMENUTableAdapter.Fill(this.dataSet6.FOODMENU);

        }
    }
}
