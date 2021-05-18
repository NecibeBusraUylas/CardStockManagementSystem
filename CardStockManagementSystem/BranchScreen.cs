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
    public partial class BranchScreen : Form
    {
        public BranchScreen()
        {
            InitializeComponent();
            Loaddata();
        }

        CardStockManagementSystemEntities1 entity = new CardStockManagementSystemEntities1();

        public void Loaddata()
        {
            var branches = entity.BranchInfo.ToList();
            foreach (BranchInfo b in branches)
            {
                if (cBoxBranchName.Items.Contains(b.BranchName) == false)
                    cBoxBranchName.Items.Add(b.BranchName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            CardStock cardstock = new CardStock();
            cardstock.Show();
            this.Hide();
        }

        public int FindCardType()
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

        private void cBoxBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var branch = entity.BranchInfo.Where(p => p.BranchName == cBoxBranchName.Text).ToList();
            foreach (BranchInfo b in branch)
            {
                tBoxBranchAddress.Text = b.BranchAddress;

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

                lBoxCardType.Items.Add(type);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int type = FindCardType();

            var newBranch = new BranchInfo();
            newBranch.BranchName = cBoxBranchName.Text;
            newBranch.BranchAddress = tBoxBranchAddress.Text;
            newBranch.BranchCardType = type;
            newBranch.BranchCardNumber = Convert.ToInt32(tBoxCardNumber.Text);

            entity.BranchInfo.Add(newBranch);
            entity.SaveChanges();
            MessageBox.Show("Yeni şube bilgileri eklendi.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rBtnName.Checked == true)
            {
                using (var branchInfo = new CardStockManagementSystemEntities1())
                {
                    var BranchNameToUpdate = entity.BranchInfo.Where(p => p.BranchName == cBoxBranchName.Text && p.BranchAddress == tBoxBranchAddress.Text).ToList();
                    var Name = tBoxUpdateValue.Text;
                    foreach (BranchInfo b in BranchNameToUpdate)
                    {
                        b.BranchName = Name;
                        entity.SaveChanges();
                    }
                    branchInfo.SaveChanges();
                    MessageBox.Show("Şubenin ismi güncellendi.");
                }
            }

            else if (rBtnAddress.Checked == true)
            {
                using (var branchInfo = new CardStockManagementSystemEntities1())
                {
                    var BranchAddressToUpdate = entity.BranchInfo.Where(p => p.BranchName == cBoxBranchName.Text && p.BranchAddress == tBoxBranchAddress.Text).ToList();
                    var Address = tBoxUpdateValue.Text;
                    foreach (BranchInfo b in BranchAddressToUpdate)
                    {
                        b.BranchAddress = Address;
                        entity.SaveChanges();
                    }
                    branchInfo.SaveChanges();
                    MessageBox.Show("Şubenin adresi güncellendi.");
                }
            }
        }
    }
}
