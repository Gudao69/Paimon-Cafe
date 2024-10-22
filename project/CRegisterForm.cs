using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class CRegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");

        public CRegisterForm()
        {
            InitializeComponent();
        }

        private void GetAutoID()
        {
            try
            {
                // Query to select the maximum Id from the Customer table
                string query = "select MAX(Id) from Customer";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var maxId = cmd.ExecuteScalar() as String;

                if(maxId == null || maxId.Length < 5)
                {
                    txtCId.Text = "C-001";
                }
                else
                {
                    // Parse the integer value from the Id string
                    int intval = int.Parse(maxId.Substring(2,3));
                    intval++;
                    // Format the integer value as a 3-digit string with leading zeroes
                    txtCId.Text = String.Format("C-{0:000}", intval);
                }
                con.Close();
            }
            
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CRegisterForm_Load(object sender, EventArgs e)
        {
            GetAutoID();
        }

        private void btnCRegister_Click(object sender, EventArgs e)
        {
            String gender = "";
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            if (rdbFemale.Checked)
            {
                gender = "Female";
            }

            DateTime dtp = dTPCustomer.Value;
            string formattedDate = dtp.ToString("MM-dd-yyyy HH:mm:ss");

            if (String.IsNullOrEmpty(txtUsername.Text)|| String.IsNullOrEmpty(txtPassword.Text)|| String.IsNullOrEmpty(txtCPassword.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (String.IsNullOrEmpty(txtName.Text)|| String.IsNullOrEmpty(gender)|| String.IsNullOrEmpty(formattedDate))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (String.IsNullOrEmpty(txtPhone.Text)|| String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    // Check in the Staff table if the Username already exists or not
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Staff where Username = '" + txtUsername.Text + "'";
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        rdr.Close();
                        MessageBox.Show("This Username Already Exists!!!");
                    }
                    else
                    {
                        // Check in the Customer table if the Username already exists or not
                        rdr.Close();
                        cmd.CommandText = "select * from Customer where Username = '" + txtUsername.Text + "'";
                        rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            rdr.Close();
                            MessageBox.Show("This Username Already Exists!!!");
                        }
                        else
                        {
                            // Insert the data into the Customer table.
                            rdr.Close();
                            if (txtCPassword.Text == txtPassword.Text)
                            {
                                cmd.CommandText = "insert into Customer(Id,Username,Password,Name,Gender,DateOfBirth,PhoneNo,Address) values ('" + txtCId.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + gender + "','" + formattedDate + "','" + txtPhone.Text + "','" + txtAddress.Text + "')";
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Registered Successfully!!!");
                                if(LoginForm.FormName == "LoginForm")
                                {
                                    var LoginForm = new LoginForm();
                                    this.Hide();
                                    LoginForm.Show();
                                }
                                if(LoginForm.FormName == "AFunctionsForm")
                                {
                                    var CRegisterForm = new CRegisterForm();
                                    this.Hide();
                                    CRegisterForm.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Check Your Passwords Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Return to Login if the form is loaded from Login Form
            if (LoginForm.FormName == "LoginForm")
            {
                var LoginForm = new LoginForm();
                this.Hide();
                LoginForm.Show();
            }
            // Return to AFunctionsForm if the form is loaded by Admin
            if (LoginForm.FormName == "AFunctionsForm")
            {
                var AFunctionsForm = new AFunctionsForm();
                this.Hide();
                AFunctionsForm.Show();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            // Restrict User from entering anyting in the textbox except 0 to 9
            if (txtPhone.Text != "")
            {
                string phno = txtPhone.Text;
                string pattern = "^[0-9]+$";
                bool ismatch = Regex.IsMatch(phno, pattern);

                if (ismatch)
                {
                }
                else
                {
                    MessageBox.Show("Invalid data type for phone number");
                    txtPhone.Text = "";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
