using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1PresentationLayer
{
    public partial class FormAddEdit : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        int _ContactID;
        clsContact _Contact;

        public FormAddEdit(int ConactID)
        {
            InitializeComponent();
            _ContactID = ConactID;
            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else { _Mode = enMode.Update; }

        }
        private void _FillCountriesInCombox()
        {
            DataTable dtCpuntries = Country.GetAllCountries();
            foreach (DataRow row in dtCpuntries.Rows)
            {
                comboBox1.Items.Add(row["CountryName"]);

            }
        }
        private void _LoadData()
        {
            _FillCountriesInCombox();
            comboBox1.SelectedIndex = 0;
            if (_Mode == enMode.AddNew)
            {
                HEAD.Text = "Add New User";
                _Contact = new clsContact();
                return;
            }
            _Contact = clsContact.Find(_ContactID);
            if (_Contact == null)
            {
                MessageBox.Show("contact box is empty");
                this.Close();
                return;
            }
            HEAD.Text = "Edit contact ID = " + _ContactID;
            ID.Text = _ContactID.ToString();
            textBoxFnmae.Text = _Contact.FirstName.ToString();
            textBoxLname.Text = _Contact.LastName.ToString();
            textBoxemail.Text = _Contact.Email.ToString();
            textBoxPhone.Text = _Contact.Phone.ToString();
            textBoxAddress.Text = _Contact.Address.ToString();
            dateTimePicker1.Value = _Contact.DateOfBirth;
            if (_Contact.ImagePath != "")
            {
                pictureBox1.Load(_Contact.ImagePath);
            }
            Remove.Visible = (_Contact.ImagePath != "");
            comboBox1.SelectedIndex = comboBox1.FindString(Country.Find(_Contact.CountryID).CountryName);


        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            int CountryID = Country.Find(comboBox1.Text).CountryID;
            _Contact.FirstName = textBoxFnmae.Text;
            _Contact.LastName = textBoxLname.Text;
            _Contact.Phone = textBoxPhone.Text;
            _Contact.Email = textBoxemail.Text;
            _Contact.Address = textBoxAddress.Text;
            _Contact.DateOfBirth = dateTimePicker1.Value;
            _Contact.CountryID = CountryID;
            if (pictureBox1.ImageLocation != null)
                _Contact.ImagePath = pictureBox1.ImageLocation;
            else
                _Contact.ImagePath = "";

            if (_Contact.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

            _Mode = enMode.Update;
          HEAD.Text = "Edit Contact ID = " + _Contact.ID;
            ID.Text = _Contact.ID.ToString();


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
                // ...
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            pictureBox1.Visible=false;


        }
    }
}

