using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace project
{
    public partial class FoodMenu : Form
    {
        int selectedRowIndex = 0;
        float price, quantity, totalprice,totalcost;
        string filePath = string.Empty;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
        DataTable dataTable = new DataTable();
        public FoodMenu()
        {
            InitializeComponent();
            // Add columns to show in the dgvOrder
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Total Price");
        }

        private void SelectFromDGV ()
        {
            txtFId.Text = dgvFood.Rows[selectedRowIndex].Cells["Id"].FormattedValue.ToString();
            txtName.Text = dgvFood.Rows[selectedRowIndex].Cells["Name"].FormattedValue.ToString();
            cboFCategory.Text = dgvFood.Rows[selectedRowIndex].Cells["Category"].FormattedValue.ToString();
            txtPrice.Text = dgvFood.Rows[selectedRowIndex].Cells["Price"].FormattedValue.ToString();
            cboStatus.Text = dgvFood.Rows[selectedRowIndex].Cells["Status"].FormattedValue.ToString();
            dgvFood.Rows[selectedRowIndex].Selected = true;
        }

        private void Display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // select everything from Food except Image which conatins the Image file path
            cmd.CommandText = "select Id,Name,Category,Price,Status from Food";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            dt.Clear();
            adap.Fill(dt);
            dgvFood.DataSource = dt;
            conn.Close();
        }
        private void GetAutoID()
        {
            try
            {
                string query = "select MAX(OrderID) from [Order]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                var maxId = cmd.ExecuteScalar() as String;

                if (maxId == null || maxId.Length < 5)
                {
                    lblOId.Text = "O-001";
                }
                else
                {
                    int intval = int.Parse(maxId.Substring(2, 3));
                    intval++;
                   lblOId.Text = String.Format("O-{0:000}", intval);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShowImage()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Image FROM Food WHERE Id= '" + txtFId.Text + "'", conn);
                string filePath = cmd.ExecuteScalar().ToString();
                conn.Close();

                if (!string.IsNullOrEmpty(filePath))
                {
                    pbSample.Image = Image.FromFile(filePath);

                }
                else
                {
                    MessageBox.Show("There is No Data!");
                }
            }
            catch
            {
                MessageBox.Show("Still Working On It");
            }
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            if (LoginForm.role == "Admin")
            {
                lblCId.Hide();
                lblOId.Hide();
                gbOrder.Hide();
                gbQuantity.Hide();
                txtName.ReadOnly = false;
                cboFCategory.Enabled = true;
                cboStatus.Enabled = true;
                txtPrice.ReadOnly = false;
            }
            else
            {
                btnBrowse.Hide();
                btnAutoID.Hide();
                lblCId.Text = MainMenu.SetValueForCId;
                gbAFunctions.Hide();
                GetAutoID();
            }
            dgvOrder.Hide();
            gbPrice.Hide();
            gbId.Hide();
            gbName.Hide();
            gbCategory.Hide();
            Display();
        }

        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                selectedRowIndex = e.RowIndex;
                filePath = "";
                pbSample.Image = null;
                SelectFromDGV();
                ShowImage();
                txtQuantity.Text = "0";
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
        private void panelCustomer_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text != "")
            {
                string price = txtPrice.Text;
                string pattern = "^[0-9]+$";
                bool ismatch = Regex.IsMatch(price, pattern);

                if (ismatch)
                {
                }
                else
                {
                    MessageBox.Show("Invalid data type for price");
                    txtPrice.Text = "";
                }
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            dgvFood.ClearSelection();

            if (dgvFood.Rows.Count > 0)
            {
                selectedRowIndex = 0;
                SelectFromDGV();
                ShowImage();
            }

            else
            {
                MessageBox.Show("There is no Data!!!");
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dgvFood.ClearSelection();

            if (dgvFood.Rows.Count > 0)
            {
                selectedRowIndex = dgvFood.Rows.Count -1;
                SelectFromDGV();
                ShowImage();
            }

            else
            {
                MessageBox.Show("There is no Data!!!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dgvFood.ClearSelection();
            
            if (selectedRowIndex <dgvFood.Rows.Count - 1)
            {
                selectedRowIndex++;
                SelectFromDGV();
                ShowImage();
            }

            else
            {
                MessageBox.Show("This is the Last Record!!!");   
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dgvFood.ClearSelection();
            
            if (selectedRowIndex == dgvFood.Rows.Count - 1 || selectedRowIndex != 0) 
            {
                selectedRowIndex--;
                SelectFromDGV();
                ShowImage();
            }

            else
            {
                MessageBox.Show("This is the First Record!!!");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            conn.Open();

            if (cboSearchType.Text == "Food ID")
            {
                cmd.CommandText = "select Id,Name,Category,Price,Status from Food where Id = '" + txtSFId.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    dgvFood.DataSource = dt;
                }

                else
                {
                    MessageBox.Show("Not FOUND!!");
                }

            }

            else if (cboSearchType.Text == "Food Name")
            {
                cmd.CommandText = "select Id,Name,Category,Price,Status from Food where Name = '" + txtSFName.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvFood.DataSource = dt;
                }

                else
                {
                    MessageBox.Show("Not FOUND!!");
                }
            }

            else if (cboSearchType.Text == "Category")
            {
                cmd.CommandText = "select Id,Name,Category,Price,Status from Food where Category = '" + cboCategory.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvFood.DataSource = dt;
                }

                else
                {
                    MessageBox.Show("Not FOUND!!");
                }
            }

            else if (cboSearchType.Text == "Price")
            {
                cmd.CommandText = "select Id,Name,Category,Price,Status from Food where Price = '" + txtFPrice.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvFood.DataSource = dt;
                }

                else
                {
                    MessageBox.Show("Not FOUND!!");
                }
                
            }
            conn.Close();
        }

        private void cboSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearchType.Text == "Food ID")
            {
                gbName.Hide();
                gbCategory.Hide();
                gbPrice.Hide();
                gbId.Show();
            }
            else if (cboSearchType.Text == "Food Name")
            {
                gbId.Hide();
                gbCategory.Hide();
                gbPrice.Hide();
                gbName.Show();
            }
            else if (cboSearchType.Text == "Category")
            {
                gbId.Hide();
                gbName.Hide();
                gbPrice.Hide();
                gbCategory.Show();
            }
            else if (cboSearchType.Text == "Price")
            {
                gbId.Hide();
                gbName.Hide();
                gbCategory.Hide();
                gbPrice.Show();
            }
            else
            {
                MessageBox.Show("Please choose one in ComboBox!!");
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (LoginForm.FormName == "MainMenu")
            {
                if(dgvOrder.Rows.Count == 0)
                {
                    var MainMenu = new MainMenu();
                    this.Hide();
                    MainMenu.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Discard the Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        var MainMenu = new MainMenu();
                        this.Hide();
                        MainMenu.Show();
                    }
                    else
                    {

                    }
                }
            }

            else if (LoginForm.FormName == "AFunctionsForm")
            {
                var AFunctionsForm = new AFunctionsForm();
                this.Hide();
                AFunctionsForm.Show();
            }

            else
            {
                MessageBox.Show("ERROR!!!");
            }    
        }

        private void btnAAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty (txtFId.Text)|| String.IsNullOrEmpty(txtName.Text)|| String.IsNullOrEmpty(cboFCategory.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrEmpty(cboStatus.Text)|| String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Food(Id,Name,Category,Price,Status,Image) values ('" + txtFId.Text + "','" + txtName.Text + "','" + cboFCategory.Text + "','" + txtPrice.Text + "','"+cboStatus.Text+"','"+filePath+"')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registered Successfully!");
                Display();
                txtFId.Text = txtName.Text = cboStatus.Text = cboFCategory.Text = txtPrice.Text = filePath = null;
                pbSample.Image = null;
            }
        }

        private void btnADelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (String.IsNullOrEmpty(txtFId.Text))
                {
                    MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (result == DialogResult.Yes)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from Food where Id = '" + txtFId.Text + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("DELETED SUCCESSFULLY!!");
                        Display();
                        txtFId.Text = txtName.Text = cboStatus.Text = cboFCategory.Text = txtPrice.Text = filePath =null;
                        pbSample.Image = null;
                    }
                    else
                    {

                    }
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFId.Text)|| String.IsNullOrEmpty(txtName.Text)|| String.IsNullOrEmpty(cboFCategory.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrEmpty(cboStatus.Text)|| String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please Check Again!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result==DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\msi\Documents\Paimon Cafe.mdf"";Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Food set Id = '" + txtFId.Text + "', Name = '" + txtName.Text + "', Category = '" + cboFCategory.Text + "', Price = '" + txtPrice.Text + "', Status = '" + cboStatus.Text + "', Image = '" + filePath + "' where Id = '" + txtFId.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Updated Successfully!!!");
                    Display();
                    txtFId.Text = txtName.Text = cboStatus.Text = cboFCategory.Text = txtPrice.Text = filePath = null;
                    pbSample.Image = null;
                }
                else
                {
                }
            }
        }

        private void txtFId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                if (quantity > 0)
                {
                    quantity--;
                    txtQuantity.Text = quantity.ToString();
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Quantity.");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                quantity++;
                txtQuantity.Text = quantity.ToString();
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Quantity.");
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtFId.Text)||String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("You Haven't Selected Any Food!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cboStatus.Text == "Available")
                {
                    if (txtQuantity.Text == "0")
                    {
                        MessageBox.Show("You haven't chosen the Amount!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        dgvOrder.Show();
                        DataRow dr = dataTable.NewRow();
                        dr["Id"] = txtFId.Text;
                        dr["Name"] = txtName.Text;
                        dr["Category"] = cboFCategory.Text;
                        dr["Price"] = txtPrice.Text;
                        dr["Quantity"] = txtQuantity.Text;
                        price = int.Parse(txtPrice.Text);
                        quantity = int.Parse(txtQuantity.Text);
                        totalprice = price * quantity;
                        dr["Total Price"] = totalprice;
                        dataTable.Rows.Add(dr);
                        dgvOrder.DataSource = dataTable;
                        totalcost = totalcost + totalprice;
                        lblTotalCost.Text = totalcost.ToString() + " MMK";
                    }
                }
                else
                {
                    MessageBox.Show("This Item is Out of Stock :(");
                }
            }
            
        }

        private void btnAutoID_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            cboStatus.Text = "";
            if(cboFCategory.Text == "Beverage")
            {
                string query = "select * from Food where Category = '" + "Beverage" + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                // Create a new datatable to hold the results of query
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                // Get the number of rows returned by the query
                string maxId = dt.Rows.Count.ToString();

                if (dt.Rows.Count == 0)
                {
                    txtFId.Text = "B-01";
                }
                // increase the integer value of maxId and set the text of the txtFId textbox to "B-XX"
                // where XX is the integer value padded with a leading zero
                else
                {
                    int intval = int.Parse(maxId);
                    intval++;
                    txtFId.Text = String.Format("B-{0:00}", intval);
                }
                conn.Close();
            }
            else if(cboFCategory.Text == "Main Dish")
            {
                string query = "select * from Food where Category = '" + "Main Dish" + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                string maxId = dt.Rows.Count.ToString();

                if (dt.Rows.Count == 0)
                {
                    txtFId.Text = "MD-01";
                }
                else
                {
                    int intval = int.Parse(maxId);
                    intval++;
                    txtFId.Text = String.Format("MD-{0:00}", intval);
                }
                conn.Close();
            }

            else if(cboFCategory.Text == "Side Dish")
            {
                string query = "select * from Food where Category = '" + "Side Dish" + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                string maxId = dt.Rows.Count.ToString();

                if (dt.Rows.Count == 0)
                {
                    txtFId.Text = "SD-01";
                }
                else
                {
                    int intval = int.Parse(maxId);
                    intval++;
                    txtFId.Text = String.Format("SD-{0:00}", intval);
                }
                conn.Close();
            }

            else
            {
                MessageBox.Show("Choose Category!!!");
            }

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(dgvOrder.Rows.Count == 0)
            {
                MessageBox.Show("Your Cart is Empty!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DateTime dtp = dTPOrder.Value;
                string formattedDate = dtp.ToString("MM-dd-yyyy HH:mm:ss");
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\msi\\Documents\\Paimon Cafe.mdf\";Integrated Security=True;Connect Timeout=30";
                if(String.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("You Haven't Given Your Delivery Address!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Place the Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            try
                            {
                                string insertOrderQuery = "INSERT INTO [Order] (OrderID, CustomerID, TotalCost, OrderTime, DeliveryAddress) VALUES (@OrderID, @CustomerID, @TotalCost, @OrderTime, @Address)";
                                using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@OrderID", lblOId.Text);
                                    cmd.Parameters.AddWithValue("@CustomerID", lblCId.Text);
                                    cmd.Parameters.AddWithValue("@TotalCost", totalcost);
                                    cmd.Parameters.AddWithValue("@OrderTime", formattedDate);
                                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                                    cmd.ExecuteNonQuery();
                                }
                                foreach (DataGridViewRow row in dgvOrder.Rows)
                                {
                                    if (row.Cells["Id"].Value != null)
                                    {
                                        string FId = row.Cells["Id"].Value.ToString();
                                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                                        float totalprice = Convert.ToInt32(row.Cells["Total Price"].Value);
                                        string insertODetailsQuery = "INSERT INTO [OrderDetails] (OrderID, FoodID, Quantity, TotalPrice) VALUES (@OrderID, @FoodID, @Quantity ,@TotalPrice)";
                                        using (SqlCommand command = new SqlCommand(insertODetailsQuery, conn))
                                        {
                                            command.Parameters.AddWithValue("@OrderID", lblOId.Text);
                                            command.Parameters.AddWithValue("@FoodID", FId);
                                            command.Parameters.AddWithValue("@Quantity", quantity);
                                            command.Parameters.AddWithValue("@TotalPrice", totalprice);
                                            command.ExecuteNonQuery();
                                        }
                                    }
                                }
                                MessageBox.Show("Your Order is Placed Successfully <3.");
                                conn.Close();
                                var FoodMenu = new FoodMenu();
                                this.Hide();
                                FoodMenu.Show();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else
                    {
                    } 
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\project\\Food";
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                pbSample.Image = Image.FromFile(selectedFilePath);
                filePath = openFileDialog.FileName;
            }
        }

        private void pbSample_Click(object sender, EventArgs e)
        {

        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dgvOrder.SelectedRows[0];
                DataRowView dataRowView = selectedRow.DataBoundItem as DataRowView;
                DataRow dataRow = dataRowView.Row;
                int selectedValue = Convert.ToInt32(selectedRow.Cells[5].Value);
                totalcost = totalcost - selectedValue;
                lblTotalCost.Text = totalcost.ToString() + " MMK";
                dataTable.Rows.Remove(dataRow);
                dgvOrder.Refresh();
            }
            catch
            {
                MessageBox.Show("Your Cart is Empty!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
