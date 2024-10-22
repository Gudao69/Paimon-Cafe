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

namespace project
{
    public partial class SFunctionsForm : Form
    {
        public static string SetValueForSId = "";
        public SFunctionsForm()
        {
            InitializeComponent();
        }
        private void GetSId()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\msi\\Documents\\Paimon Cafe.mdf\";Integrated Security=True;Connect Timeout=30");
            connection.Open();
            string query = "select Id from Staff " + " where Username=@username COLLATE SQL_Latin1_general_CP1_CS_AS";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", lblSUsername.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                SetValueForSId = dr.GetValue(0).ToString();
            }
            connection.Close();
        }

        private void SFunctionsForm_Load(object sender, EventArgs e)
        {
            lblSUsername.Text = LoginForm.SetValueForSUsername;
            GetSId();
        }

        private void btnSEdit_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var EditSProfile = new EditSProfile();
            this.Hide();
            EditSProfile.Show();
        }

        private void btnLOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var LoginForm = new LoginForm();
                this.Hide();
                LoginForm.Show();
                SetValueForSId = "";
            }
            else
            {

            }
        }
    }
}
