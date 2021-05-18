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
    public partial class CardStock : Form
    {
        public CardStock()
        {
            InitializeComponent();
            loaddata();
        }

        CardStockManagementSystemEntities1 entity = new CardStockManagementSystemEntities1();

        private void loaddata()
        {
            var items = entity.BranchInfo.ToList();
            foreach (var item in items)
            {
                if (cBoxBranch.Items.Contains(item.BranchName) == false)
                {
                    cBoxBranch.Items.Add(item.BranchName);
                }
            }
        }

        private void btnBranchEkran_Click(object sender, EventArgs e)
        {
            BranchScreen branchscreen = new BranchScreen();
            branchscreen.Show();
            this.Hide();
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            CustomerScreen customerscreen = new CustomerScreen();
            customerscreen.Show();
            this.Hide();
        }

        private void btnSendCard_Click(object sender, EventArgs e)
        {
            SendCard sendcard = new SendCard();
            sendcard.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var Query = from table1 in entity.BranchInfo
                        join table2 in entity.CardType
                        on table1.BranchCardType equals table2.CardTypeId
                        where table1.BranchName == cBoxBranch.Text

                        select new
                        {
                            CardType = table2.CardTypeName,
                            Number = table1.BranchCardNumber
                        };
            dataGridView1.DataSource = Query.ToList();
        }
    }
}
