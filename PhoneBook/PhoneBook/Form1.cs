using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;
using PhoneBook.Models;

namespace PhoneBook
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Clear(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Clear();
                }
                else if (item is NumericUpDown nmr)
                {
                    nmr.Value = nmr.Minimum;
                }
                else if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }

        string connection = Program.Configuration.GetConnectionString("default"); ;
        PhoneBookContext context = new();


        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = new()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Mail = txtMail.Text,
                Phone = txtPhone.Text
            };

            context.People.Add(person);
            bool result = context.SaveChanges() > 0;

            MessageBox.Show(result ? "Kayit Eklendi" : "Islem hatasi", "Kayit Ekleme Bildirimi", MessageBoxButtons.OK, result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error);

            Clear(grbSavePerson);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Program.MainFormInstance.Show();
        }

    }
}
