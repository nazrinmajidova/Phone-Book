using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void Refresh()
        {
            lstPeople.Items.Clear();

            using SqlConnection con = new SqlConnection(connection);
            using SqlCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = "select Id, FirstName, LastName,Phone, Mail from People";
            cmd.CommandType = CommandType.Text;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            using SqlDataReader dr = cmd.ExecuteReader();
            List<Person> people = new List<Person>();
            while (dr.Read())
            {
                #region Create new object

                //Person person = new()
                //{
                //    //Id = Convert.ToInt32(dr["ID"]),
                //    Id        = dr[nameof(Person.Id)] as int? ?? 0,
                //    FirstName = dr[nameof(Person.FirstName)] as string,
                //    LastName  = dr[nameof(Person.LastName)] as string,
                //    Phone     = dr.GetString(nameof(Person.Phone)),
                //    Mail      = (string)dr[nameof(Person.Mail)],


                //};
                //people.Add(person);
                #endregion

                ListViewItem item = new(dr.GetInt32(nameof(Person.Id)).ToString());
                item.SubItems.Add(dr[nameof(Person.FirstName)] as string);
                item.SubItems.Add(dr[nameof(Person.LastName)] as string);
                item.SubItems.Add(dr[nameof(Person.Phone)] as string);
                item.SubItems.Add(dr[nameof(Person.Mail)] as string);

                lstPeople.Items.Add(item);

            }
        }

        string connection = Program.Configuration.GetConnectionString("default");

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
            //MessageBox.Show(lstPeople.SelectedItems[0].Text);

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected record?",
                "Delete Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string selectedId = lstPeople.SelectedItems[0].Text;
            using SqlConnection con = new(connection);
            using SqlCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandText = "delete from people where Id = @Id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Id", selectedId);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();
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
