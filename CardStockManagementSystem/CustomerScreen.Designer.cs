namespace CardStockManagementSystem
{
    partial class CustomerScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerScreen));
            this.cBoxCardType = new System.Windows.Forms.ComboBox();
            this.tBoxDayOfBirth = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnCustomerDel = new System.Windows.Forms.RadioButton();
            this.rBtnCustomerInfoDel = new System.Windows.Forms.RadioButton();
            this.cBoxBranch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateCard = new System.Windows.Forms.Button();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.tBoxAddress = new System.Windows.Forms.TextBox();
            this.tBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tBoxPlaceofBirth = new System.Windows.Forms.TextBox();
            this.tBoxNationalId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxName = new System.Windows.Forms.ComboBox();
            this.cBoxSurname = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxCardType
            // 
            this.cBoxCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxCardType.ForeColor = System.Drawing.Color.Crimson;
            this.cBoxCardType.FormattingEnabled = true;
            this.cBoxCardType.Location = new System.Drawing.Point(366, 75);
            this.cBoxCardType.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxCardType.Name = "cBoxCardType";
            this.cBoxCardType.Size = new System.Drawing.Size(321, 37);
            this.cBoxCardType.TabIndex = 79;
            this.cBoxCardType.SelectedIndexChanged += new System.EventHandler(this.cBoxCardType_SelectedIndexChanged);
            // 
            // tBoxDayOfBirth
            // 
            this.tBoxDayOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxDayOfBirth.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxDayOfBirth.Location = new System.Drawing.Point(908, 27);
            this.tBoxDayOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxDayOfBirth.Name = "tBoxDayOfBirth";
            this.tBoxDayOfBirth.Size = new System.Drawing.Size(321, 36);
            this.tBoxDayOfBirth.TabIndex = 78;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnFind.Location = new System.Drawing.Point(722, 418);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(171, 73);
            this.btnFind.TabIndex = 77;
            this.btnFind.Text = "Bul";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnCustomerDel);
            this.groupBox2.Controls.Add(this.rBtnCustomerInfoDel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(151, 332);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1078, 69);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İptal Seçenekleri";
            // 
            // rBtnCustomerDel
            // 
            this.rBtnCustomerDel.AutoSize = true;
            this.rBtnCustomerDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnCustomerDel.ForeColor = System.Drawing.Color.DarkOrange;
            this.rBtnCustomerDel.Location = new System.Drawing.Point(622, 28);
            this.rBtnCustomerDel.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnCustomerDel.Name = "rBtnCustomerDel";
            this.rBtnCustomerDel.Size = new System.Drawing.Size(436, 33);
            this.rBtnCustomerDel.TabIndex = 29;
            this.rBtnCustomerDel.Text = "Müşteriye ait tüm kartları iptal et.";
            this.rBtnCustomerDel.UseVisualStyleBackColor = true;
            // 
            // rBtnCustomerInfoDel
            // 
            this.rBtnCustomerInfoDel.AutoSize = true;
            this.rBtnCustomerInfoDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnCustomerInfoDel.ForeColor = System.Drawing.Color.DarkOrange;
            this.rBtnCustomerInfoDel.Location = new System.Drawing.Point(51, 28);
            this.rBtnCustomerInfoDel.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnCustomerInfoDel.Name = "rBtnCustomerInfoDel";
            this.rBtnCustomerInfoDel.Size = new System.Drawing.Size(516, 33);
            this.rBtnCustomerInfoDel.TabIndex = 29;
            this.rBtnCustomerInfoDel.TabStop = true;
            this.rBtnCustomerInfoDel.Text = "Müşteriye ait girilen tipteki kartı iptal et.";
            this.rBtnCustomerInfoDel.UseVisualStyleBackColor = true;
            // 
            // cBoxBranch
            // 
            this.cBoxBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxBranch.ForeColor = System.Drawing.Color.Crimson;
            this.cBoxBranch.FormattingEnabled = true;
            this.cBoxBranch.Location = new System.Drawing.Point(366, 27);
            this.cBoxBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxBranch.Name = "cBoxBranch";
            this.cBoxBranch.Size = new System.Drawing.Size(321, 37);
            this.cBoxBranch.TabIndex = 75;
            this.cBoxBranch.SelectedIndexChanged += new System.EventHandler(this.cBoxBranch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(146, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 29);
            this.label8.TabIndex = 74;
            this.label8.Text = "Banka Şubesi: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Location = new System.Drawing.Point(954, 418);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 73);
            this.btnUpdate.TabIndex = 72;
            this.btnUpdate.Text = "Güncelle";
            this.toolTip1.SetToolTip(this.btnUpdate, "Güncelleme yapmak için öncellikle kart çeşidini ,banka şubesi,ad,soyad giriniz ve" +
        " bul butonuna basınız.\r\nBilgilerin tamamı gelince güncellemeyi yapıp güncelle bu" +
        "tonuna basınız.\r\n\r\n");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(489, 418);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 73);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "İptal";
            this.toolTip1.SetToolTip(this.btnDelete, "İptal seçeneklerinden iptal işleminin türünü seçiniz.\r\nMüşteriye ait bir kartı ip" +
        "tal etmek için kart çeşidi,ad ve soyadı giriniz.\r\nMüşteriye ait tüm kartları ipt" +
        "al etmek için ad ve soyad giriniz.\r\n\r\n");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(15, 511);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 62);
            this.btnBack.TabIndex = 70;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreateCard
            // 
            this.btnCreateCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateCard.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCreateCard.Location = new System.Drawing.Point(177, 418);
            this.btnCreateCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCard.Name = "btnCreateCard";
            this.btnCreateCard.Size = new System.Drawing.Size(248, 73);
            this.btnCreateCard.TabIndex = 69;
            this.btnCreateCard.Text = "Kart Oluştur\r\n";
            this.btnCreateCard.UseVisualStyleBackColor = true;
            this.btnCreateCard.Click += new System.EventHandler(this.btnCreateCard_Click);
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnMale.ForeColor = System.Drawing.Color.Crimson;
            this.rBtnMale.Location = new System.Drawing.Point(394, 253);
            this.rBtnMale.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(81, 33);
            this.rBtnMale.TabIndex = 68;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Bay";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnFemale.ForeColor = System.Drawing.Color.Crimson;
            this.rBtnFemale.Location = new System.Drawing.Point(501, 253);
            this.rBtnFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(111, 33);
            this.rBtnFemale.TabIndex = 67;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Bayan";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // tBoxAddress
            // 
            this.tBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxAddress.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxAddress.Location = new System.Drawing.Point(908, 160);
            this.tBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxAddress.Multiline = true;
            this.tBoxAddress.Name = "tBoxAddress";
            this.tBoxAddress.Size = new System.Drawing.Size(321, 131);
            this.tBoxAddress.TabIndex = 65;
            // 
            // tBoxPhoneNumber
            // 
            this.tBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxPhoneNumber.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxPhoneNumber.Location = new System.Drawing.Point(908, 116);
            this.tBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxPhoneNumber.Name = "tBoxPhoneNumber";
            this.tBoxPhoneNumber.Size = new System.Drawing.Size(321, 36);
            this.tBoxPhoneNumber.TabIndex = 64;
            // 
            // tBoxPlaceofBirth
            // 
            this.tBoxPlaceofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxPlaceofBirth.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxPlaceofBirth.Location = new System.Drawing.Point(908, 71);
            this.tBoxPlaceofBirth.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxPlaceofBirth.Name = "tBoxPlaceofBirth";
            this.tBoxPlaceofBirth.Size = new System.Drawing.Size(321, 36);
            this.tBoxPlaceofBirth.TabIndex = 63;
            // 
            // tBoxNationalId
            // 
            this.tBoxNationalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxNationalId.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxNationalId.Location = new System.Drawing.Point(366, 123);
            this.tBoxNationalId.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxNationalId.Name = "tBoxNationalId";
            this.tBoxNationalId.Size = new System.Drawing.Size(321, 36);
            this.tBoxNationalId.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DarkOrange;
            this.label10.Location = new System.Drawing.Point(217, 255);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 29);
            this.label10.TabIndex = 60;
            this.label10.Text = "Cinsiyeti:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkOrange;
            this.label11.Location = new System.Drawing.Point(700, 119);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 29);
            this.label11.TabIndex = 59;
            this.label11.Text = "Cep Telefonu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(726, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 29);
            this.label9.TabIndex = 58;
            this.label9.Text = "Doğum Yeri:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(703, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(146, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "T.C. Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(188, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Kart Çeşidi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(799, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Adres:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1078, 418);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "BİLGİLENDİRME!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(283, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(239, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "Soyadı:";
            // 
            // cBoxName
            // 
            this.cBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxName.ForeColor = System.Drawing.Color.Crimson;
            this.cBoxName.FormattingEnabled = true;
            this.cBoxName.Location = new System.Drawing.Point(366, 166);
            this.cBoxName.Name = "cBoxName";
            this.cBoxName.Size = new System.Drawing.Size(321, 37);
            this.cBoxName.TabIndex = 81;
            // 
            // cBoxSurname
            // 
            this.cBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxSurname.ForeColor = System.Drawing.Color.Crimson;
            this.cBoxSurname.FormattingEnabled = true;
            this.cBoxSurname.Location = new System.Drawing.Point(366, 209);
            this.cBoxSurname.Name = "cBoxSurname";
            this.cBoxSurname.Size = new System.Drawing.Size(321, 37);
            this.cBoxSurname.TabIndex = 81;
            // 
            // CustomerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 587);
            this.Controls.Add(this.cBoxSurname);
            this.Controls.Add(this.cBoxName);
            this.Controls.Add(this.cBoxCardType);
            this.Controls.Add(this.tBoxDayOfBirth);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cBoxBranch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateCard);
            this.Controls.Add(this.rBtnMale);
            this.Controls.Add(this.rBtnFemale);
            this.Controls.Add(this.tBoxAddress);
            this.Controls.Add(this.tBoxPhoneNumber);
            this.Controls.Add(this.tBoxPlaceofBirth);
            this.Controls.Add(this.tBoxNationalId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerScreen";
            this.Text = "Customer Screen";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxCardType;
        private System.Windows.Forms.TextBox tBoxDayOfBirth;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnCustomerDel;
        private System.Windows.Forms.RadioButton rBtnCustomerInfoDel;
        private System.Windows.Forms.ComboBox cBoxBranch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreateCard;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.TextBox tBoxAddress;
        private System.Windows.Forms.TextBox tBoxPhoneNumber;
        private System.Windows.Forms.TextBox tBoxPlaceofBirth;
        private System.Windows.Forms.TextBox tBoxNationalId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxName;
        private System.Windows.Forms.ComboBox cBoxSurname;
    }
}