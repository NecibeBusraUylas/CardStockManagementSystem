namespace CardStockManagementSystem
{
    partial class BranchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchScreen));
            this.cBoxBranchName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnAddress = new System.Windows.Forms.RadioButton();
            this.rBtnName = new System.Windows.Forms.RadioButton();
            this.cBoxCardType = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tBoxUpdateValue = new System.Windows.Forms.TextBox();
            this.tBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lBoxCardType = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxBranchAddress = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxBranchName
            // 
            this.cBoxBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxBranchName.ForeColor = System.Drawing.Color.Crimson;
            this.cBoxBranchName.FormattingEnabled = true;
            this.cBoxBranchName.Location = new System.Drawing.Point(413, 94);
            this.cBoxBranchName.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxBranchName.Name = "cBoxBranchName";
            this.cBoxBranchName.Size = new System.Drawing.Size(817, 37);
            this.cBoxBranchName.TabIndex = 48;
            this.cBoxBranchName.SelectedIndexChanged += new System.EventHandler(this.cBoxBranchName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnAddress);
            this.groupBox1.Controls.Add(this.rBtnName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(208, 425);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(893, 69);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncelleme Seçenekleri";
            // 
            // rBtnAddress
            // 
            this.rBtnAddress.AutoSize = true;
            this.rBtnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnAddress.ForeColor = System.Drawing.Color.DarkOrange;
            this.rBtnAddress.Location = new System.Drawing.Point(455, 26);
            this.rBtnAddress.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnAddress.Name = "rBtnAddress";
            this.rBtnAddress.Size = new System.Drawing.Size(299, 33);
            this.rBtnAddress.TabIndex = 29;
            this.rBtnAddress.TabStop = true;
            this.rBtnAddress.Text = "Şube adresi güncelle.";
            this.rBtnAddress.UseVisualStyleBackColor = true;
            // 
            // rBtnName
            // 
            this.rBtnName.AutoSize = true;
            this.rBtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBtnName.ForeColor = System.Drawing.Color.DarkOrange;
            this.rBtnName.Location = new System.Drawing.Point(109, 26);
            this.rBtnName.Margin = new System.Windows.Forms.Padding(4);
            this.rBtnName.Name = "rBtnName";
            this.rBtnName.Size = new System.Drawing.Size(297, 33);
            this.rBtnName.TabIndex = 29;
            this.rBtnName.TabStop = true;
            this.rBtnName.Text = "Şube ismini güncelle.";
            this.rBtnName.UseVisualStyleBackColor = true;
            // 
            // cBoxCardType
            // 
            this.cBoxCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxCardType.ForeColor = System.Drawing.Color.Crimson;
            this.cBoxCardType.FormattingEnabled = true;
            this.cBoxCardType.Items.AddRange(new object[] {
            "Öğrenci",
            "Express",
            "Sanal",
            "Premium",
            "Tarım",
            "Business"});
            this.cBoxCardType.Location = new System.Drawing.Point(930, 219);
            this.cBoxCardType.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxCardType.Name = "cBoxCardType";
            this.cBoxCardType.Size = new System.Drawing.Size(281, 37);
            this.cBoxCardType.TabIndex = 45;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(13, 512);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 62);
            this.btnBack.TabIndex = 44;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Location = new System.Drawing.Point(765, 513);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(161, 64);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Güncelle";
            this.toolTip1.SetToolTip(this.btnUpdate, "Güncelleme seçeneklerinden günceleme türünü seçiniz.\r\nGüncelleme için isim , adre" +
        "s ve güncel isim alanlarını doldurunuz.\r\n\r\n");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(493, 513);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(161, 64);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Ekle";
            this.toolTip1.SetToolTip(this.btnAdd, "Yeni bir şube ekleyecekseniz istenilen kart çeşidini seçebilisiniz.\r\nVar olan bir" +
        " şubeye yeni kart çeşidi eklerken şubede bulunan kart çeşitlerini dikkate alınız" +
        ".\r\n");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tBoxUpdateValue
            // 
            this.tBoxUpdateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxUpdateValue.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxUpdateValue.Location = new System.Drawing.Point(414, 354);
            this.tBoxUpdateValue.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxUpdateValue.Name = "tBoxUpdateValue";
            this.tBoxUpdateValue.Size = new System.Drawing.Size(817, 36);
            this.tBoxUpdateValue.TabIndex = 40;
            // 
            // tBoxCardNumber
            // 
            this.tBoxCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxCardNumber.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxCardNumber.Location = new System.Drawing.Point(413, 310);
            this.tBoxCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxCardNumber.Name = "tBoxCardNumber";
            this.tBoxCardNumber.Size = new System.Drawing.Size(817, 36);
            this.tBoxCardNumber.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(77, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 35;
            this.label1.Text = "Güncel İsim yada Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(235, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Kart Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "Şubede Bulunan Kart Çeşitleri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(219, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Şube Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(246, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Şube İsmi:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1082, 423);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lBoxCardType
            // 
            this.lBoxCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lBoxCardType.ForeColor = System.Drawing.Color.Crimson;
            this.lBoxCardType.FormattingEnabled = true;
            this.lBoxCardType.ItemHeight = 29;
            this.lBoxCardType.Location = new System.Drawing.Point(414, 183);
            this.lBoxCardType.Name = "lBoxCardType";
            this.lBoxCardType.Size = new System.Drawing.Size(313, 120);
            this.lBoxCardType.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(733, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Kart Çeşitleri:";
            // 
            // tBoxBranchAddress
            // 
            this.tBoxBranchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tBoxBranchAddress.ForeColor = System.Drawing.Color.Crimson;
            this.tBoxBranchAddress.Location = new System.Drawing.Point(414, 138);
            this.tBoxBranchAddress.Name = "tBoxBranchAddress";
            this.tBoxBranchAddress.Size = new System.Drawing.Size(817, 36);
            this.tBoxBranchAddress.TabIndex = 52;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "BİLGİLENDİRME!!!";
            // 
            // BranchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 587);
            this.Controls.Add(this.tBoxBranchAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lBoxCardType);
            this.Controls.Add(this.cBoxBranchName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBoxCardType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tBoxUpdateValue);
            this.Controls.Add(this.tBoxCardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BranchScreen";
            this.Text = "Branch Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBoxBranchName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnAddress;
        private System.Windows.Forms.RadioButton rBtnName;
        private System.Windows.Forms.ComboBox cBoxCardType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tBoxUpdateValue;
        private System.Windows.Forms.TextBox tBoxCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lBoxCardType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxBranchAddress;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}