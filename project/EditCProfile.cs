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
    public partial class EditCProfile : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
        public EditCProfile()
        {
            InitializeComponent();
        }

        private void Display()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Customer";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                dgvCDetails.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditCProfile_Load(object sender, EventArgs e)
        {
            if(LoginForm.FormName == "AFunctionsForm")
            {
                Display();
            }
            else
            {
                btnADelete.Hide();
                dgvCDetails.Hide();
            }
            SetCId();
            if (txtCId.Text != "")
            {
                txtCId.ReadOnly = true;
            }
            else { txtCId.ReadOnly = false; }
        }

        private void SetCId()
        {
            string CId = MainMenu.SetValueForCId;
            txtCId.Text = CId;
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
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
            if (String.IsNullOrEmpty(txtCId.Text)|| String.IsNullOrEmpty(txtUsername.Text)|| String.IsNullOrEmpty(txtPassword.Text)|| String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrEmpty(gender)|| String.IsNullOrEmpty(formattedDate)|| String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {try
                {DialogResult result = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Customer set Id = '" + txtCId.Text + "', Username = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "', Name = '" + txtName.Text + "', Gender = '" + gender + "', DateOfBirth = '" + formattedDate + "',PhoneNo = '" + txtPhone.Text + "', Address = '" + txtAddress.Text + "' where Id = '" + txtCId.Text + "'";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Profile Updated Successfully!!!");
                        Display();
                        txtPassword.Text = null;
                        txtName.Text = txtPhone.Text = txtAddress.Text = null;
                        rdbMale.Checked = false;
                        rdbFemale.Checked = false;
                        btnShowData.BringToFront();
                    }
                    else
                    {
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (LoginForm.FormName == "MainMenu")
            {
                var MainMenu = new MainMenu();
                this.Hide();
                MainMenu.Show();
            }

            if (LoginForm.FormName == "AFunctionsForm")
            {
               var AFunctionsForm = new AFunctionsForm();
                this.Hide();    
                AFunctionsForm.Show();
            }
        }

        private void txtCId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtCId.Text))
                {
                    MessageBox.Show("Enter Customer ID!!!");
                }
                else
                {
                    conn.Open();
                    string query = "select * from Customer " + " where Id=@id COLLATE SQL_Latin1_general_CP1_CS_AS";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", txtCId.Text);
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        txtUsername.Text = dr.GetValue(1).ToString();
                        txtPassword.Text = dr.GetValue(2).ToString();
                        txtName.Text = dr.GetValue(3).ToString();

                        String gender = dr.GetValue(4).ToString();
                        if (gender == "Male")
                        {
                            rdbMale.Checked = true;
                        }
                        if (gender == "Female")
                        {
                            rdbFemale.Checked = true;
                        }

                        DateTime dtp = dTPCustomer.Value;
                        String formattedDate = dtp.ToString("MM-dd-yyyy HH:mm:ss");
                        dTPCustomer.Text = dr.GetValue(5).ToString();

                        txtPhone.Text = dr.GetValue(6).ToString();
                        txtAddress.Text = dr.GetValue(7).ToString();
                        btnHideData.BringToFront();
                    }
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHideData_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            rdbFemale.Checked = false; rdbMale.Checked = false;
            txtPhone.Text = "";
            txtAddress.Text = "";
            btnShowData.BringToFront();
        }
        private void dgvCDetails_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCDetails.CurrentRow.Selected = true;
                txtCId.Text = dgvCDetails.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtUsername.Text = dgvCDetails.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                txtPassword.Text = dgvCDetails.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
                txtName.Text = dgvCDetails.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                string gender = dgvCDetails.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                if (gender == "Male")
                {
                    rdbMale.Checked = true;
                }
                if (gender == "Female")
                {
                    rdbFemale.Checked = true;
                }
                DateTime dtp = dTPCustomer.Value;
                String formattedDate = dtp.ToString("MM-dd-yyyy HH:mm:ss");
                dTPCustomer.Text = dgvCDetails.Rows[e.RowIndex].Cells["DateOfBirth"].FormattedValue.ToString();
                txtPhone.Text = dgvCDetails.Rows[e.RowIndex].Cells["PhoneNo"].FormattedValue.ToString();
                txtAddress.Text = dgvCDetails.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                btnHideData.BringToFront();
            }
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

        private void btnADelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (String.IsNullOrEmpty(txtCId.Text))
            {
                MessageBox.Show("Please Check Again!!!");
            }
            else
            {
                try
                {
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Customer where Id = '" + txtCId.Text + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("DELETED SUCCESSFULLY!!");
                        conn.Close();
                        Display();
                        txtCId.Text = txtUsername.Text = txtPassword.Text = null;
                        txtName.Text = txtPhone.Text = txtAddress.Text = null;
                        rdbMale.Checked = false;
                        rdbFemale.Checked = false;
                        btnShowData.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("Invalid!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
