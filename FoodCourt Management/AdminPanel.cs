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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void bubButton_Click(object sender, EventArgs e)
        {
            BlockCard b = new BlockCard();
            this.Hide();
            b.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            AddPayment p = new AddPayment();
            this.Hide();
            p.Show();
        }

        private void cardListButton_Click(object sender, EventArgs e)
        {
            CardList c = new CardList();
            this.Hide();
            c.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            StudentsList s = new StudentsList();
            this.Hide();
            s.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            this.Hide();
            s.Hide();
        }
    }
}
