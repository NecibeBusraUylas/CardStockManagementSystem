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
    public partial class CustomerScreen : Form
    {
        public CustomerScreen()
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

        private void cBoxCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxName.Items.Clear();
            cBoxSurname.Items.Clear();
            int type = findCardType();

            var branchCustomer = entity.Customer.Where(p => p.BranchName == cBoxBranch.Text && p.CustomerCardType == type).ToList();
            foreach (Customer c in branchCustomer)
            {
                cBoxName.Items.Add(c.Name);
                cBoxSurname.Items.Add(c.Surname);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CardStock cardstock = new CardStock();
            cardstock.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rBtnCustomerInfoDel.Checked == true)
            {
                int type = findCardType();
                cBoxCardType.Enabled = true;
                var id = entity.Customer.Where(p => p.Name == cBoxName.Text && p.Surname == cBoxSurname.Text && p.CustomerCardType == type);

                entity.Customer.RemoveRange(id);
                entity.SaveChanges();
                MessageBox.Show("Girilen bilgilere göre müşterinin kartı iptal edildi.");
            }

            else if (rBtnCustomerDel.Checked == true)
            {
                var id = entity.Customer.Where(p => p.Name == cBoxName.Text && p.Surname == cBoxSurname.Text);
                entity.Customer.RemoveRange(id);
                entity.SaveChanges();
                MessageBox.Show("Müşteriye ait tüm kartlar iptal edildi.");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int type = findCardType();
            cBoxCardType.Enabled = true;
            var customerToFind = entity.Customer.Where(p => p.BranchName == cBoxBranch.Text && p.CustomerCardType == type && p.Name == cBoxName.Text && p.Surname == cBoxSurname.Text);
            foreach (Customer c in customerToFind)
            {
                tBoxNationalId.Text = c.NationalId;
                if (c.Gender == "Bay")
                    rBtnMale.Checked = true;
                if (c.Gender == "Bayan")
                    rBtnFemale.Checked = true;
                tBoxDayOfBirth.Text = c.DayOfBirth;
                tBoxPlaceofBirth.Text = c.PlaceOfBrith;
                tBoxPhoneNumber.Text = c.PhoneNumber;
                tBoxAddress.Text = c.Address;
            }
            entity.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int type = findCardType();
            cBoxCardType.Enabled = false;
            var CustomerToUpdate = entity.Customer.Where(p => p.CustomerCardType == type && p.NationalId == tBoxNationalId.Text && p.DayOfBirth == tBoxDayOfBirth.Text);
            foreach (Customer c in CustomerToUpdate)
            {
                c.BranchName = cBoxBranch.Text;
                c.Name = cBoxName.Text;
                c.Surname = cBoxSurname.Text;
                if (rBtnMale.Checked == true)
                    c.Gender = rBtnMale.Text;
                if (rBtnFemale.Checked == true)
                    c.Gender = rBtnFemale.Text;
                c.DayOfBirth = tBoxDayOfBirth.Text;
                c.PlaceOfBrith = tBoxPlaceofBirth.Text;
                c.PhoneNumber = tBoxPhoneNumber.Text;
                c.Address = tBoxAddress.Text;
            }
            entity.SaveChanges();
            MessageBox.Show("Müşteri bilgileri güncellendi.");
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            Console.WriteLine(randomNumber);

            if (randomNumber == 1 || randomNumber == 2)
            { 
                MessageBox.Show("Kart oluşturma işlemi sırasında hata oluştu lütfen işlemi tekrar ediniz.");
            }
            else if (true)
            {
                int type = findCardType();
                cBoxCardType.Enabled = true;
                var newCustomer = new Customer();
                newCustomer.BranchName = cBoxBranch.Text;
                newCustomer.CustomerCardType = type;
                newCustomer.NationalId = tBoxNationalId.Text;
                newCustomer.Name = cBoxName.Text;
                newCustomer.Surname = cBoxSurname.Text;
                if (rBtnMale.Checked == true)
                    newCustomer.Gender = rBtnMale.Text;
                if (rBtnFemale.Checked == true)
                    newCustomer.Gender = rBtnFemale.Text;
                newCustomer.DayOfBirth = tBoxDayOfBirth.Text;
                newCustomer.PlaceOfBrith = tBoxPlaceofBirth.Text;
                newCustomer.PhoneNumber = tBoxPhoneNumber.Text;
                newCustomer.Address = tBoxAddress.Text;
                entity.Customer.Add(newCustomer);
                entity.SaveChanges();

                var newCardTransaction = new BranchCardTransactions();
                using (var branchInfo = new CardStockManagementSystemEntities1())
                {
                    var branchToFind = branchInfo.BranchInfo.Where(p => p.BranchName == cBoxBranch.Text && p.BranchCardType == type);
                    foreach (BranchInfo b in branchToFind)
                    {
                        b.BranchCardNumber = ((b.BranchCardNumber) - 1);
                        newCardTransaction.BranchId = b.BranchId;
                        newCardTransaction.CardType = b.BranchCardType;
                        newCardTransaction.Number = " -1 ";
                        entity.SaveChanges();
                    }
                    using (var cardTransactions = new CardStockManagementSystemEntities1())
                    {
                        cardTransactions.BranchCardTransactions.Add(newCardTransaction);
                        cardTransactions.SaveChanges();
                    }

                    branchInfo.SaveChanges();
                }
                MessageBox.Show("Kart başarıyla oluşturuldu.");

                using (var branchInfo = new CardStockManagementSystemEntities1())
                {
                    var branchToFind = branchInfo.BranchInfo.Where(p => p.BranchName == cBoxBranch.Text && p.BranchCardType == type);
                    foreach (BranchInfo b in branchToFind)
                    {
                        if (b.BranchCardNumber < 10)
                        {
                            MessageBox.Show("Kart sayısı azaldı lüften kart gönderin.");
                        }
                    }
                }
            }
        }
    }
}
