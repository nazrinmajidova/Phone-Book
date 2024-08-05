using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;
using PhoneBook.Models;


namespace PhoneBook
{
    public partial class ListForm : MetroForm
    {
        public ListForm()
        {
            InitializeComponent();
        }

        string connection = Program.Configuration.GetConnectionString("default");
        PhoneBookContext context = new();

        public void Refresh()
        {
            lstPeople.Items.Clear();

            var people = context.People.ToList();

            foreach (var person in people)
            {
                ListViewItem item = new(person.Id.ToString());
                item.SubItems.Add(person.FirstName);
                item.SubItems.Add(person.LastName);
                item.SubItems.Add(person.Phone);
                item.SubItems.Add(person.Mail);

                lstPeople.Items.Add(item);

            }
        }
   

        private void ListForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void cmsRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmsSil_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.", "Delete item",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected record?",
                "Delete Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedId = Convert.ToInt32(lstPeople.SelectedItems[0].Text);
            Person person = context.People.FirstOrDefault(p => p.Id == selectedId);

            if(person != null)
            {
                context.People.Remove(person);

                bool result = context.SaveChanges() > 0;

                if (result)
                {
                    lstPeople.SelectedItems[0].Remove();
                }

                MessageBox.Show(text: result ? "Kayit Silindi" : "Islem Hatasi",
                                caption: "Kayit Silme Bildirimi",
                                buttons: MessageBoxButtons.OK,
                                icon: result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
                );
            }    
            
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainFormInstance.Show();
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to update.",
                    "Update Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string selectedId = lstPeople.SelectedItems[0].Text;
            EditForm frm = new(selectedId);
            frm.ShowDialog();
        }
    }
}
