using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;
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
        private void EditForm_Load(object sender, EventArgs e)
        {
            using SqlConnection con = new(connection);
            using SqlCommand cmd = new();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  [Id], [FirstName], [LastName], [Phone], [Mail] FROM People WHERE [Id] = @Id";
            cmd.Parameters.AddWithValue("@Id", _id);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            using SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtFirstName.Text = dr["FirstName"] as string;
                txtLastName.Text = dr["LastName"] as string;
                txtPhone.Text = dr["Phone"] as string;
                txtMail.Text = dr["Mail"] as string;
            }

            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connection = Program.Configuration.GetConnectionString("default");
            using SqlConnection con = new SqlConnection(connection);

            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE People SET FirstName = @firstName, LastName = @lastName, Mail = @mail, Phone = @phone WHERE [Id] = @Id";

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = _id;
            cmd.Parameters.Add("@firstName", SqlDbType.NVarChar, 100).Value = txtFirstName.Text;
            cmd.Parameters.Add("@lastName", SqlDbType.NVarChar, 100).Value = txtLastName.Text;
            cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 30).Value = txtPhone.Text;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 100).Value = txtMail.Text;


            cmd.CommandType = CommandType.Text;


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();


            if (result)
            {
                this.Close();
            }
        }

        
    }
}
