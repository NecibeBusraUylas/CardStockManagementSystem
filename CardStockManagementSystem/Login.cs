using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardStockManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tBoxUserName.Text == "Büşra Uylaş" && tBoxPassword.Text == "123456")
            {
                CardStock cardstock = new CardStock();
                cardstock.Show();
                this.Hide();
            }
        }
    }
}

