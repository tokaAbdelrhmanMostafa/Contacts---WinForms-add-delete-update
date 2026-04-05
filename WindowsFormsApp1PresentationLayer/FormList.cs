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
using BusinessLayer;

namespace WindowsFormsApp1PresentationLayer
{
    public partial class FormList : Form
    {
        public FormList()
        {
            InitializeComponent();
        }
        private void _RefreshContactList()
        {
            dataGridView1.DataSource = clsContact.GetAllContacts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContactList();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            FormAddEdit frm = new FormAddEdit(-1);
            frm.ShowDialog();
            _RefreshContactList();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            //frmAddEditContact frm = new frmAddEditContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);

            FormAddEdit frm = new FormAddEdit((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshContactList();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure","conform ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

            }
        }
    }
}
