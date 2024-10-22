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
    public partial class SRegisterForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
        double val = 0;
        public SRegisterForm()
        {
            InitializeComponent();
        }

        private void GetAutoID()
        {
            try
            {
                string query = "select MAX(Id) from Staff";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                var maxId = cmd.ExecuteScalar() as String;

                if (maxId == null || maxId.Length < 5)
                {
                    txtSId.Text = "S-001";
                }
                else
                {
                    int intval = int.Parse(maxId.Substring(2, 3));
                    intval++;
                    txtSId.Text = String.Format("S-{0:000}", intval);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SRegisterForm_Load(object sender, EventArgs e)
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

            DateTime dtp = dTPStaff.Value;
            string formattedDate = dtp.ToString("MM-dd-yyyy HH:mm:ss");

            if (String.IsNullOrEmpty(txtUsername.Text)|| String.IsNullOrEmpty(txtPassword.Text)|| String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }

            else if (String.IsNullOrEmpty(cboPosition.Text)|| String.IsNullOrEmpty(gender)|| String.IsNullOrEmpty(formattedDate))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (String.IsNullOrEmpty(txtPhone.Text)|| String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer where Username = '" + txtUsername.Text + "'";
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Close();
                    MessageBox.Show("This Username Already Exists!!!");
                }
                else
                {
                    rdr.Close();
                    cmd.CommandText = "select * from Staff where Username = '" + txtUsername.Text + "'";
                    rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        rdr.Close();
                        MessageBox.Show("This Username Already Exists!!!");
                    }
                    else
                    {
                        rdr.Close();
                        if(txtCPassword.Text == txtPassword.Text)
                        {
                            cmd.CommandText = "insert into Staff(Id,Username,Password,Name,Position,Gender,DateOfBirth,PhoneNo,Address) values ('" + txtSId.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + cboPosition.Text + "','" + gender + "','" + formattedDate + "','" + txtPhone.Text + "','" + txtAddress.Text + "')";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registered Successfully!!!");
                            var LoginForm = new LoginForm();
                            this.Hide();
                            LoginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please Check Your Passwords Again!!");
                        }
                    }
                }
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
                var AFunctionsForm = new AFunctionsForm();
                this.Hide();
                AFunctionsForm.Show();   
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
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
                    txtPhone.Text = "";
                    MessageBox.Show("Invalid!!!");
                }
            }
        }
    }
}
