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
    public partial class CardList : Form
    {
        public CardList()
        {
            InitializeComponent();
        }

        private void CardList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CARD' table. You can move, or remove it, as needed.
            this.cARDTableAdapter.Fill(this.dataSet1.CARD);

        }

        private void defaultersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cARDTableAdapter.Defaulters(this.dataSet1.CARD);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
