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
    public partial class SendCard : Form
    {
        public SendCard()
        {
            InitializeComponent();
            loaddata();
        }

        CardStockManagementSystemEntities1 entity = new CardStockManagementSystemEntities1();

        public void loaddata()
        {
            var items = entity.BranchInfo.ToList();
            foreach (BranchInfo item in items)
            {
                if (cBoxBranch.Items.Contains(item.BranchName) == false)
                {
                    cBoxBranch.Items.Add(item.BranchName);
                }
            }
        }

        public int findCardType()
        {
            int type = 0;

            if (cBoxCardType.Text == "Öğrenci")
                type = 1;
            else if (cBoxCardType.Text == "Express")
                type = 2;
            else if (cBoxCardType.Text == "Sanal")
                type = 3;
            else if (cBoxCardType.Text == "Premium")
                type = 4;
            else if (cBoxCardType.Text == "Tarım")
                type = 5;
            else if (cBoxCardType.Text == "Business")
                type = 6;
            return type;
        }

        private void cBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxCardType.Items.Clear();
            var branchCardTypes = entity.BranchInfo.Where(p => p.BranchName == cBoxBranch.Text).ToList();
            foreach (BranchInfo b in branchCardTypes)
            {
                string type = "";
                if (b.BranchCardType == 1)
                    type = "Öğrenci";
                else if (b.BranchCardType == 2)
                    type = "Express";
                else if (b.BranchCardType == 3)
                    type = "Sanal";
                else if (b.BranchCardType == 4)
                    type = "Premium";
                else if (b.BranchCardType == 5)
                    type = "Tarım";
                else if (b.BranchCardType == 6)
                    type = "Business";

                cBoxCardType.Items.Add(type);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CardStock cardstock = new CardStock();
            cardstock.Show();
            this.Hide();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int type = findCardType();
            var BranchesToSendCard = entity.BranchInfo.Where(p => p.BranchName == cBoxBranch.Text && p.BranchCardType == type).ToList();
            var newCardTransaction = new BranchCardTransactions();
            foreach (BranchInfo branch in BranchesToSendCard)
            {
                branch.BranchCardNumber = (branch.BranchCardNumber + (Convert.ToInt32(nUpDownCardNumber.Value)));
                newCardTransaction.BranchId = branch.BranchId;
                newCardTransaction.CardType = branch.BranchCardType;
                newCardTransaction.Number = " +" + nUpDownCardNumber.Value.ToString();
                entity.BranchCardTransactions.Add(newCardTransaction);
                entity.SaveChanges();
            }
            MessageBox.Show("Şubeye istenilen sayıda kart gönderildi.");
        }
    }
}