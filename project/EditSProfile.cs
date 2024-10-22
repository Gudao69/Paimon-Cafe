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
    public partial class EditSProfile : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\msi\\Documents\\Paimon Cafe.mdf\";Integrated Security=True;Connect Timeout=30");

        public EditSProfile()
        {
            InitializeComponent();
        }
        private void SetSId()
        {
            string SId = SFunctionsForm.SetValueForSId;
            txtCId.Text = SId;
        }

        private void Display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(dt);
            dgvSDetails.DataSource = dt;
            conn.Close();

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select * from Staff " + " where Id=@id COLLATE SQL_Latin1_general_CP1_CS_AS";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", txtCId.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtUsername.Text = dr.GetValue(1).ToString();
                txtPassword.Text = dr.GetValue(2).ToString();
                txtName.Text = dr.GetValue(3).ToString();
                cboPosition.Text = dr.GetValue(4).ToString();

                String gender = dr.GetValue(5).ToString();
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
                dTPCustomer.Text = dr.GetValue(6).ToString();

                txtPhone.Text = dr.GetValue(7).ToString();
                txtAddress.Text = dr.GetValue(8).ToString();
                btnHideData.BringToFront();
            }
            conn.Close();
        }

        private void btnHideData_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            cboPosition.Text = "";
            rdbFemale.Checked = false; rdbMale.Checked = false;
            txtPhone.Text = "";
            txtAddress.Text = "";
            btnShowData.BringToFront();
        }

        private void dgvSDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSDetails.CurrentRow.Selected = true;
                txtCId.Text = dgvSDetails.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtUsername.Text = dgvSDetails.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                txtPassword.Text = dgvSDetails.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
                txtName.Text = dgvSDetails.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                cboPosition.Text = dgvSDetails.Rows[e.RowIndex].Cells["Position"].FormattedValue.ToString();
                string gender = dgvSDetails.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
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
                dTPCustomer.Text = dgvSDetails.Rows[e.RowIndex].Cells["DateOfBirth"].FormattedValue.ToString();
                txtPhone.Text = dgvSDetails.Rows[e.RowIndex].Cells["PhoneNo"].FormattedValue.ToString();
                txtAddress.Text = dgvSDetails.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                btnHideData.BringToFront();
            }
        }

        private void EditSProfile_Load(object sender, EventArgs e)
        {
            if (LoginForm.FormName == "AFunctionsForm")
            {
                Display();
            }
            else
            {
                btnADelete.Hide();
                dgvSDetails.Hide();
            }
            SetSId();
            if (txtCId.Text != "")
            {
                txtCId.ReadOnly = true;
            }
            else { txtCId.ReadOnly = false; }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (LoginForm.FormName == "SFunctionsForm")
            {
                var SFunctionsForm = new SFunctionsForm();
                this.Hide();
                SFunctionsForm.Show();
            }

            if (LoginForm.FormName == "AFunctionsForm")
            {
                var AFunctionsForm = new AFunctionsForm();
                this.Hide();
                AFunctionsForm.Show();
            }
        }

        private void btnADelete_Click(object sender, EventArgs e)
        {
            if(cboPosition.Text == "Admin")
            {
                MessageBox.Show("There Must Have at least One Admin!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Staff where Position = '" + cboPosition.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (String.IsNullOrEmpty(txtCId.Text))
                    {
                        MessageBox.Show("Please Check Again!!!");
                    }
                    else
                    {
                        if (result == DialogResult.Yes)
                        {
                            conn.Open();
                            SqlCommand cmd1 = conn.CreateCommand();
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "delete from Staff where Id = '" + txtCId.Text + "'";
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("DELETED SUCCESSFULLY!!");
                            Display();
                        }
                        else
                        {

                        }
                    }
                    conn.Close();
                }
            }
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

            if (String.IsNullOrEmpty(txtCId.Text)||String.IsNullOrEmpty(txtUsername.Text)|| String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (String.IsNullOrEmpty(txtName.Text)||String.IsNullOrEmpty(cboPosition.Text)|| String.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (String.IsNullOrEmpty(formattedDate)|| String.IsNullOrEmpty(txtPhone.Text)|| String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Staff set Id = '" + txtCId.Text + "', Username = '" + txtUsername.Text + "', Password = '" + txtPassword.Text + "', Name = '" + txtName.Text + "', Position = '" + cboPosition.Text + "', Gender = '" + gender + "', DateOfBirth = '" + formattedDate + "',PhoneNo = '" + txtPhone.Text + "', Address = '" + txtAddress.Text + "' where Id = '" + txtCId.Text + "'";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Profile Updated Successfully!!!");
                        txtPassword.Text = cboPosition.Text = null;
                        txtName.Text = txtPhone.Text = txtAddress.Text = null;
                        rdbMale.Checked = false;
                        rdbFemale.Checked = false;
                        Display();
                    }
                    else
                    {

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
