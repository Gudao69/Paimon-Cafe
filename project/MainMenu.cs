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
    public partial class MainMenu : Form
    {
        public static string SetValueForCId = "";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCEdit_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var EditCProfile = new EditCProfile();
            this.Hide();
            EditCProfile.Show();
        }
        private void GetCId()
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\msi\\Documents\\Paimon Cafe.mdf\";Integrated Security=True;Connect Timeout=30");
            connection.Open();
            string query = "select Id from Customer " + " where Username=@username COLLATE SQL_Latin1_general_CP1_CS_AS";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", lblCUsername.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                SetValueForCId = dr.GetValue(0).ToString();
            }
            connection.Close();
        }

        private void btnLOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result== DialogResult.Yes)
            {
                var LoginForm = new LoginForm();
                this.Hide();
                LoginForm.Show();
                SetValueForCId = "";
            }
            else
            {

            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblCUsername.Text = LoginForm.SetValueForCUsername;
            GetCId();
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var FoodMenu = new FoodMenu();
            this.Hide(); 
            FoodMenu.Show();
            LoginForm.FormName = "MainMenu";
        }

        private void btnCheckOrders_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var COrdersForm = new COrdersForm();
            this.Hide();
            COrdersForm.Show();
        }
    }
}
