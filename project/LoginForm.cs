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
    public partial class LoginForm : Form
    {
        public static string SetValueForCUsername = "";
        public static string SetValueForAUsername = "";
        public static string SetValueForSUsername = "";
        public static string FormName = "";
        public static string role = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" & txtPassword.Text != "")
                {
                    // Check if the input data is in the Customer Table or Not
                    // COLLATE SQL_Latin1_general_CP1_CS_AS to check case and accent sensitive
                    string query = "select * from Customer where Username=@username COLLATE SQL_Latin1_general_CP1_CS_AS and Password=@password COLLATE SQL_Latin1_general_CP1_CS_AS";
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\msi\\Documents\\Paimon Cafe.mdf\";Integrated Security=True;Connect Timeout=30");
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    // If the Username is from Customer, Main Menu will appear
                    if (dr.HasRows)
                    {
                        dr.Close();
                        MessageBox.Show("Logged In Successfully <3");
                        LoginForm.FormName = this.Name;
                        SetValueForCUsername = txtUsername.Text;
                        var MainMenu = new MainMenu();
                        this.Hide();
                        MainMenu.Show();
                        FormName = this.Name;
                    }
                    else
                    {
                        dr.Close();
                        // Check if the input data is in the Staff Table or Not
                        query = "select * from Staff where Username=@username COLLATE SQL_Latin1_general_CP1_CS_AS and Password=@password COLLATE SQL_Latin1_general_CP1_CS_AS";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        dr = cmd.ExecuteReader();
                        string position = "";
                        while (dr.Read())
                        {
                            position = dr.GetString(4);
                        }
                        if(position == "Admin")
                        {
                            // If the input Username is from Admin, Admin form will appear
                            if (dr.HasRows)
                            {
                                dr.Close();
                                MessageBox.Show("Logged In Successfully as an Admin <3");
                                LoginForm.FormName = this.Name;
                                SetValueForAUsername = txtUsername.Text;
                                role = "Admin";
                                var AFunctionsForm = new AFunctionsForm();
                                this.Hide();
                                AFunctionsForm.Show();
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("Please Check Username and Password Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            // If the input Username is from Staff, Staff Form will appear
                            if (dr.HasRows)
                            {
                                dr.Close();
                                LoginForm.FormName = this.Name;
                                SetValueForSUsername = txtUsername.Text;
                                MessageBox.Show("Logged In Successfully as a Staff <3");
                                var SFunctionsForm = new SFunctionsForm();
                                this.Hide();
                                SFunctionsForm.Show();
                            }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("Please Check Username and Password Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void linklblCRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm.FormName = this.Name;
            var CRegisterForm = new CRegisterForm();
            this.Hide();
            CRegisterForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
