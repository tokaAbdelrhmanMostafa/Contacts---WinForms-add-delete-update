namespace WindowsFormsApp1PresentationLayer
{
    partial class FormAddEdit
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
            this.HEAD = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.ContactID = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxFnmae = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SetImage = new System.Windows.Forms.LinkLabel();
            this.Remove = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HEAD
            // 
            this.HEAD.AutoSize = true;
            this.HEAD.Location = new System.Drawing.Point(355, 35);
            this.HEAD.Name = "HEAD";
            this.HEAD.Size = new System.Drawing.Size(45, 16);
            this.HEAD.TabIndex = 0;
            this.HEAD.Text = "HEAD";
            this.HEAD.Click += new System.EventHandler(this.label1_Click);
            // 
            // country
            // 
            this.country.AutoSize = true;
            this.country.Location = new System.Drawing.Point(243, 253);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(50, 16);
            this.country.TabIndex = 1;
            this.country.Text = "country";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(243, 217);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(45, 16);
            this.phone.TabIndex = 2;
            this.phone.Text = "phone";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(243, 192);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(243, 155);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(69, 16);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(243, 120);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(69, 16);
            this.FirstName.TabIndex = 5;
            this.FirstName.Text = "FirstName";
            // 
            // ContactID
            // 
            this.ContactID.AutoSize = true;
            this.ContactID.Location = new System.Drawing.Point(243, 83);
            this.ContactID.Name = "ContactID";
            this.ContactID.Size = new System.Drawing.Size(65, 16);
            this.ContactID.TabIndex = 6;
            this.ContactID.Text = "ContactID";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(243, 282);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(58, 16);
            this.Address.TabIndex = 7;
            this.Address.Text = "Address";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(355, 83);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Location = new System.Drawing.Point(244, 315);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateOfBirth.Size = new System.Drawing.Size(75, 16);
            this.DateOfBirth.TabIndex = 10;
            this.DateOfBirth.Text = "DateOfBirth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBoxFnmae
            // 
            this.textBoxFnmae.Location = new System.Drawing.Point(349, 120);
            this.textBoxFnmae.Name = "textBoxFnmae";
            this.textBoxFnmae.Size = new System.Drawing.Size(100, 22);
            this.textBoxFnmae.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(350, 214);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(349, 155);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(100, 22);
            this.textBoxLname.TabIndex = 14;
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(349, 186);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(100, 22);
            this.textBoxemail.TabIndex = 15;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(349, 282);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 16;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(496, 385);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(86, 36);
            this.close.TabIndex = 17;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(606, 385);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 36);
            this.save.TabIndex = 18;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 130);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // SetImage
            // 
            this.SetImage.AutoSize = true;
            this.SetImage.Location = new System.Drawing.Point(590, 35);
            this.SetImage.Name = "SetImage";
            this.SetImage.Size = new System.Drawing.Size(65, 16);
            this.SetImage.TabIndex = 20;
            this.SetImage.TabStop = true;
            this.SetImage.Text = "SetImage";
            this.SetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetImage_LinkClicked);
            // 
            // Remove
            // 
            this.Remove.AutoSize = true;
            this.Remove.Location = new System.Drawing.Point(691, 35);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(59, 16);
            this.Remove.TabIndex = 21;
            this.Remove.TabStop = true;
            this.Remove.Text = "Remove";
            this.Remove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Remove_LinkClicked);
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.SetImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.close);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxFnmae);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.ContactID);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.country);
            this.Controls.Add(this.HEAD);
            this.Name = "FormAddEdit";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HEAD;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label ContactID;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxFnmae;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel SetImage;
        private System.Windows.Forms.LinkLabel Remove;
    }
}