using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class COrdersForm : Form
    {
        int rowcount;
        float price, FQuantity, total, finaltotal, totalcost1, totalcost2;
        TimeSpan timediff = TimeSpan.Zero;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
        DataTable dataTable = new DataTable();
        public COrdersForm()
        {
            InitializeComponent();
        }

        private void DisplayAllOrder()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Order]";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                dgvOrderList.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayOrder()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select [OrderID], [TotalCost], [OrderTime], [DeliveryAddress] from [Order] where CustomerID = @CID";
                cmd.Parameters.AddWithValue("@CID", cboCId.Text);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                dgvOrderList.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayOrderDetails()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                // Simutaneously Extract only necessary data from 2 database tables(Food and OrderDetails)
                cmd.CommandText = "select od.OrderDetailsID, f.Id, f.Name, f.Price, od.Quantity, od.TotalPrice from Food f, OrderDetails od where od.FoodID = f.Id and OrderID = @OID";
                cmd.Parameters.AddWithValue("@OID", txtOId.Text);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                dgvOrderDetails.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message );
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

        private void COrdersForm_Load(object sender, EventArgs e)
        {
            dgvOrderDetails.Hide();
            dTPOrder.Hide();
            cboCId.Text = MainMenu.SetValueForCId;

            if (LoginForm.role == "Admin")
            {
                cboCId.Enabled = true;
                conn.Open();
                string query = "SELECT [Id] FROM Customer";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cboCId.Items.Add(reader["Id"].ToString());
                }
                conn.Close();
                DisplayAllOrder();
            }

            else
            {
                DisplayOrder();
            }
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvOrderList.CurrentRow.Selected = true;
                dgvOrderDetails.Show();
                txtOId.Text = dgvOrderList.Rows[e.RowIndex].Cells["OrderID"].FormattedValue.ToString();
                lblTCost.Text = dgvOrderList.Rows[e.RowIndex].Cells["TotalCost"].FormattedValue.ToString() + " MMK";
                totalcost1 = Convert.ToInt32(dgvOrderList.Rows[e.RowIndex].Cells["TotalCost"].FormattedValue);
                dTPOrder.Text = dgvOrderList.Rows[e.RowIndex].Cells["OrderTime"].FormattedValue.ToString();
                txtAddress.Text = dgvOrderList.Rows[e.RowIndex].Cells["DeliveryAddress"].FormattedValue.ToString();
                rowcount = e.RowIndex;
                DisplayOrderDetails();
            }
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvOrderDetails.CurrentRow.Selected = true;
                txtODId.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["OrderDetailsID"].FormattedValue.ToString();
                txtFId.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                txtName.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtQuantity.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["Quantity"].FormattedValue.ToString();
                txtPrice.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                lblTotal.Text = dgvOrderDetails.Rows[e.RowIndex].Cells["TotalPrice"].FormattedValue.ToString()+" MMK";
                total = Convert.ToInt32(dgvOrderDetails.Rows[e.RowIndex].Cells["TotalPrice"].FormattedValue);
                rowcount = e.RowIndex;
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                string phno = txtQuantity.Text;
                string pattern = "^[0-9]+$";
                bool ismatch = Regex.IsMatch(phno, pattern);

                if (ismatch)
                {
                }
                else
                {
                    txtQuantity.Text = "";
                    MessageBox.Show("Invalid!!!");
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                quantity++;
                txtQuantity.Text = quantity.ToString();
                price = int.Parse(txtPrice.Text);
                FQuantity = int.Parse(txtQuantity.Text);
                finaltotal = price * FQuantity;
                lblTotal.Text = finaltotal.ToString() + " MMK";
                totalcost2 = (totalcost1 - total) + finaltotal;
                lblTCost.Text = totalcost2.ToString() + " MMK";
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Quantity.");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                if (quantity > 0)
                {
                    quantity--;
                }
                txtQuantity.Text = quantity.ToString();
                price = int.Parse(txtPrice.Text);
                FQuantity = int.Parse(txtQuantity.Text);
                finaltotal = price * FQuantity;
                lblTotal.Text = finaltotal.ToString() + " MMK";
                totalcost2 = (totalcost1 - total) + finaltotal;
                lblTCost.Text = totalcost2.ToString() + " MMK";
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Quantity.");
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtOId.Text))
                {
                    MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DateTime dtp1 = dTPOrder.Value;
                    DateTime dtp2 = dTPCurrent.Value;
                    timediff = dtp2 - dtp1;

                    if (timediff.TotalHours >= 4)
                    {
                        MessageBox.Show("You can Upadte or Cancel the Order Only Within 4 Hours!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to Cancel the Whole Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            conn.Open();
                            // Delete from OrderDetails table
                            SqlCommand cmd1 = new SqlCommand("DELETE FROM [OrderDetails] WHERE [OrderID] = @OrderID", conn);
                            cmd1.Parameters.AddWithValue("@OrderID", txtOId.Text);
                            int rowsDeleted1 = cmd1.ExecuteNonQuery();

                            // Delete from Order table
                            SqlCommand cmd2 = new SqlCommand("DELETE FROM [Order] WHERE [OrderID] = @OrderID", conn);
                            cmd2.Parameters.AddWithValue("@OrderID", txtOId.Text);
                            int rowsDeleted2 = cmd2.ExecuteNonQuery();

                            if (rowsDeleted1 > 0 || rowsDeleted2 > 0)
                            {
                                txtOId.Text = "";
                                MessageBox.Show("CANCELLED SUCCESSFULLY!!");
                                conn.Close();
                                DisplayOrder();
                                DisplayOrderDetails();
                            }
                            else
                            {
                                MessageBox.Show("NO RECORDS FOUND!!");
                                conn.Close();
                            }
                        }
                        else
                        {
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayOrder();
        }

        private void btnOdDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtODId.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime dtp1 = dTPOrder.Value;
                DateTime dtp2 = dTPCurrent.Value;
                timediff = dtp2 - dtp1;

                if (timediff.TotalHours >= 4)
                {
                    MessageBox.Show("You can Update or Cancel the Order Only Within 4 Hours!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        // delete the detail from the OrderDetailID table
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from [OrderDetails] where OrderDetailsID = '" + txtODId.Text + "'";
                        cmd.ExecuteNonQuery();

                        totalcost2 = totalcost1 - total;
                        lblTCost.Text = totalcost2.ToString()+" MMK";
                        // update the data in Order table
                        SqlCommand cmd2 = conn.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "update [Order] set [TotalCost] = '" + totalcost2 + "', [DeliveryAddress] = '" + txtAddress.Text + "' where OrderID = '" + txtOId.Text + "'";
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("DELETED SUCCESSFULLY!!");
                        conn.Close();
                        // refresh the data grid views
                        DisplayOrder();
                        DisplayOrderDetails();
                        txtODId.Text = txtFId.Text = txtName.Text = txtPrice.Text = lblTotal.Text = null;
                        lblTCost.Text = totalcost2.ToString() + " MMK";
                        txtQuantity.Text = "0";
                    }
                    else
                    {
                    }
                }
            }
        }

        private void btnODUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtOId.Text)|| String.IsNullOrEmpty(txtAddress.Text)|| String.IsNullOrEmpty(txtODId.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrEmpty(txtName.Text)|| String.IsNullOrEmpty(txtPrice.Text)|| String.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime dtp1 = dTPOrder.Value;
                DateTime dtp2 = dTPCurrent.Value;
                timediff = dtp2 - dtp1;

                if (timediff.TotalHours >= 4)
                {
                    MessageBox.Show("You can Update or Cancel the Order Only Within 4 Hours!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "update [OrderDetails] set [OrderID] = '" + txtOId.Text + "', [FoodID] = '" + txtFId.Text + "', [Quantity] = '" + txtQuantity.Text + "', [TotalPrice] = '" + finaltotal + "' where OrderDetailsID = '" + txtODId.Text + "'";
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = conn.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.CommandText = "update [Order] set [TotalCost] = '"+totalcost2+"', [DeliveryAddress] = '" + txtAddress.Text + "' where OrderID = '" + txtOId.Text + "'";
                        cmd2.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Updated Successfully!!!");

                        DisplayOrder();
                        DisplayOrderDetails();
                        txtODId.Text = txtFId.Text = txtName.Text = txtPrice.Text = lblTotal.Text = null;
                        lblTCost.Text = totalcost2.ToString()+" MMK";
                        txtQuantity.Text = "0";
                    }
                    else
                    {
                    }
                }
            }
        }
    }
}
