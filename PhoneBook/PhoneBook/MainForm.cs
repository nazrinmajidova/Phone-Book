using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PhoneBook
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            //this.Hide();
            Program.MainFormInstance.Hide();
            frm.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListForm frm = new ListForm();
            //this.Hide();
            Program.MainFormInstance.Hide();
            frm.ShowDialog();
        }
    }
}
