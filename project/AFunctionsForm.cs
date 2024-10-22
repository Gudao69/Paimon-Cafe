using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class AFunctionsForm : Form
    {
        public AFunctionsForm()
        {
            InitializeComponent();
        }

        private void btnSRegister_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var SRegisterForm = new SRegisterForm();
            this.Hide();
            SRegisterForm.Show();
        }

        private void btnCRegister_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var CRegisterForm = new CRegisterForm();
            this.Hide(); 
            CRegisterForm.Show();
        }

        private void AFunctionsForm_Load(object sender, EventArgs e)
        {
            lblAUsername.Text = LoginForm.SetValueForAUsername;
        }

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var EditCProfile = new EditCProfile();
            this.Hide();
            EditCProfile.Show();
        }

        private void btnLOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                var LoginForm = new LoginForm();
                this.Hide();
                LoginForm.Show();
                LoginForm.role = "";
            }
            else
            {
            }
        }

        private void btnFoodMenu_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var FoodMenu = new FoodMenu();
            this.Hide();
            FoodMenu.Show();
        }

        private void btnSUpdate_Click(object sender, EventArgs e)
        {
            var EditSProfile = new EditSProfile();
            this.Hide();
            EditSProfile.Show();
        }

        private void btnCheckOrders_Click(object sender, EventArgs e)
        {
            LoginForm.FormName = this.Name;
            var COrderForm = new COrdersForm();
            this.Hide();
            COrderForm.Show();
        }
    }
}
