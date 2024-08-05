using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PhoneBook.Models;

namespace PhoneBook
{
    public partial class EditForm : MetroForm
    {
        private string _id;
        public EditForm(string Id)
        {
            _id = Id;
            InitializeComponent();
        }


        string connection = Program.Configuration.GetConnectionString("default");
        PhoneBookContext context = new();

        private void EditForm_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(_id);
            Person person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtPhone.Text = person.Phone;
                txtMail.Text = person.Mail;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(_id);
            Person person = context.People.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                person.FirstName = txtFirstName.Text;
                person.LastName = txtLastName.Text;
                person.Phone = txtPhone.Text;
                person.Mail = txtMail.Text;

                context.SaveChanges();
                this.Close();
            }


        }
    }
}
