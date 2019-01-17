namespace Assignment2
{
    partial class EditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContact));
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.pictureBoxDisplayPicture = new System.Windows.Forms.PictureBox();
            this.buttonSearchNumber = new System.Windows.Forms.Button();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearchName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxSearchByNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxBirthdate = new System.Windows.Forms.MaskedTextBox();
            this.labelBirthdate = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPostcode = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCounty = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelDesription = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelPostcode = new System.Windows.Forms.Label();
            this.labelCounty = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(224, 436);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(305, 436);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(386, 436);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(386, 368);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenImage.TabIndex = 15;
            this.buttonOpenImage.Text = "Open Image";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // pictureBoxDisplayPicture
            // 
            this.pictureBoxDisplayPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplayPicture.Image = global::Assignment2.Properties.Resources.Contact;
            this.pictureBoxDisplayPicture.Location = new System.Drawing.Point(224, 63);
            this.pictureBoxDisplayPicture.Name = "pictureBoxDisplayPicture";
            this.pictureBoxDisplayPicture.Size = new System.Drawing.Size(236, 299);
            this.pictureBoxDisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplayPicture.TabIndex = 39;
            this.pictureBoxDisplayPicture.TabStop = false;
            // 
            // buttonSearchNumber
            // 
            this.buttonSearchNumber.Location = new System.Drawing.Point(350, 34);
            this.buttonSearchNumber.Name = "buttonSearchNumber";
            this.buttonSearchNumber.Size = new System.Drawing.Size(110, 23);
            this.buttonSearchNumber.TabIndex = 14;
            this.buttonSearchNumber.Text = "Search by Number";
            this.buttonSearchNumber.UseVisualStyleBackColor = true;
            this.buttonSearchNumber.Click += new System.EventHandler(this.buttonSearchNumber_Click);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(224, 13);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(120, 20);
            this.textBoxSearchName.TabIndex = 11;
            // 
            // buttonSearchName
            // 
            this.buttonSearchName.Location = new System.Drawing.Point(350, 10);
            this.buttonSearchName.Name = "buttonSearchName";
            this.buttonSearchName.Size = new System.Drawing.Size(110, 23);
            this.buttonSearchName.TabIndex = 12;
            this.buttonSearchName.Text = "Search by Name";
            this.buttonSearchName.UseVisualStyleBackColor = true;
            this.buttonSearchName.Click += new System.EventHandler(this.buttonSearchName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Search for a contact";
            // 
            // maskedTextBoxSearchByNumber
            // 
            this.maskedTextBoxSearchByNumber.Location = new System.Drawing.Point(262, 36);
            this.maskedTextBoxSearchByNumber.Mask = "(99999) 999999";
            this.maskedTextBoxSearchByNumber.Name = "maskedTextBoxSearchByNumber";
            this.maskedTextBoxSearchByNumber.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBoxSearchByNumber.TabIndex = 13;
            // 
            // maskedTextBoxBirthdate
            // 
            this.maskedTextBoxBirthdate.Location = new System.Drawing.Point(153, 326);
            this.maskedTextBoxBirthdate.Mask = "99/99/9999";
            this.maskedTextBoxBirthdate.Name = "maskedTextBoxBirthdate";
            this.maskedTextBoxBirthdate.Size = new System.Drawing.Size(64, 20);
            this.maskedTextBoxBirthdate.TabIndex = 9;
            // 
            // labelBirthdate
            // 
            this.labelBirthdate.AutoSize = true;
            this.labelBirthdate.Location = new System.Drawing.Point(7, 333);
            this.labelBirthdate.Name = "labelBirthdate";
            this.labelBirthdate.Size = new System.Drawing.Size(49, 13);
            this.labelBirthdate.TabIndex = 118;
            this.labelBirthdate.Text = "Birthdate";
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(132, 270);
            this.maskedTextBoxPhoneNumber.Mask = "(99999) 999999";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxPhoneNumber.TabIndex = 7;
            // 
            // maskedTextBoxPostcode
            // 
            this.maskedTextBoxPostcode.Location = new System.Drawing.Point(153, 240);
            this.maskedTextBoxPostcode.Mask = ">LL09 0LL";
            this.maskedTextBoxPostcode.Name = "maskedTextBoxPostcode";
            this.maskedTextBoxPostcode.Size = new System.Drawing.Size(64, 20);
            this.maskedTextBoxPostcode.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(10, 386);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(207, 70);
            this.textBoxDescription.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(91, 300);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(126, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxCounty
            // 
            this.textBoxCounty.Location = new System.Drawing.Point(91, 210);
            this.textBoxCounty.Name = "textBoxCounty";
            this.textBoxCounty.Size = new System.Drawing.Size(126, 20);
            this.textBoxCounty.TabIndex = 5;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(91, 180);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(126, 20);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(91, 150);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(126, 20);
            this.textBoxAddress.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(91, 120);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(126, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(91, 90);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(126, 20);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelDesription
            // 
            this.labelDesription.AutoSize = true;
            this.labelDesription.Location = new System.Drawing.Point(7, 363);
            this.labelDesription.Name = "labelDesription";
            this.labelDesription.Size = new System.Drawing.Size(60, 13);
            this.labelDesription.TabIndex = 117;
            this.labelDesription.Text = "Description";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(7, 303);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 115;
            this.labelEmail.Text = "Email Address";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(7, 273);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 114;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // labelPostcode
            // 
            this.labelPostcode.AutoSize = true;
            this.labelPostcode.Location = new System.Drawing.Point(7, 243);
            this.labelPostcode.Name = "labelPostcode";
            this.labelPostcode.Size = new System.Drawing.Size(52, 13);
            this.labelPostcode.TabIndex = 112;
            this.labelPostcode.Text = "Postcode";
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.Location = new System.Drawing.Point(7, 213);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(40, 13);
            this.labelCounty.TabIndex = 110;
            this.labelCounty.Text = "County";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(7, 183);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(56, 13);
            this.labelCity.TabIndex = 108;
            this.labelCity.Text = "City/Town";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(7, 153);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 13);
            this.labelAddress.TabIndex = 106;
            this.labelAddress.Text = "Address Line";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(7, 123);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 104;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 93);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 101;
            this.labelFirstName.Text = "First Name";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(7, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 99;
            this.labelTitle.Text = "Title";
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Ms.",
            "Dr."});
            this.comboBoxTitle.Location = new System.Drawing.Point(144, 63);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(74, 21);
            this.comboBoxTitle.TabIndex = 0;
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 466);
            this.Controls.Add(this.maskedTextBoxBirthdate);
            this.Controls.Add(this.labelBirthdate);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.maskedTextBoxPostcode);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxCounty);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelDesription);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelPostcode);
            this.Controls.Add(this.labelCounty);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.maskedTextBoxSearchByNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchName);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.buttonSearchNumber);
            this.Controls.Add(this.pictureBoxDisplayPicture);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOpenImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit a Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplayPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplayPicture;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonSearchNumber;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchByNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBirthdate;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostcode;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCounty;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelDesription;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelPostcode;
        private System.Windows.Forms.Label labelCounty;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxTitle;
    }
}