using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            string connection = Program.Configuration.GetConnectionString("default"); ;
            // Server=myServerAddress;Database=myDataBase;Trusted_Connection=True; -> sql'de windows'la baglananda

            using SqlConnection con = new SqlConnection(connection); // -> otomatik dispose edir

            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            //cmd.CommandText = "insert into People (Firstname, LastName,Mail, Phone) values ('murat', 'vuranok','murat.vuranok@code.edu.az','+994501234785')";
            cmd.CommandText = "insert into People (Firstname, LastName,Mail, Phone) values (@firstname, @lastname,@mail,@phone)";
            cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
            cmd.Parameters.AddWithValue("mail", txtMail.Text);
            cmd.Parameters.AddWithValue("phone", txtPhone.Text);

            cmd.CommandType = System.Data.CommandType.Text;

            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            bool result = cmd.ExecuteNonQuery() > 0;
            con.Close();

            //MessageBox.Show(result ? "Kayit Eklendi" : "Islem hatasi");
            MessageBox.Show(result ? "Kayit Eklendi" : "Islem hatasi", "Kayit Ekleme Bildirimi", MessageBoxButtons.OK, result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error);

            Clear(grbSavePerson);
            // commandi connection'a baglamalisan
            // sql injection'i engellemek ucun parametre gondermeliyik
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ListForm lf = new ListForm();
        //    lf.Show();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MainForm frm = new MainForm();
            //frm.Show();
            Program.MainFormInstance.Show();
        }

    }
}
