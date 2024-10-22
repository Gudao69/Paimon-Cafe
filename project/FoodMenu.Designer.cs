namespace project
{
    partial class FoodMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodMenu));
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnShowMenu = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbSample = new System.Windows.Forms.PictureBox();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.txtFPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAutoID = new System.Windows.Forms.Button();
            this.cboFCategory = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbAFunctions = new System.Windows.Forms.GroupBox();
            this.btnAAdd = new System.Windows.Forms.Button();
            this.btnADelete = new System.Windows.Forms.Button();
            this.btnAUpdate = new System.Windows.Forms.Button();
            this.gbQuantity = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSFName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearchType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbId = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSFId = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.lblCId = new System.Windows.Forms.Label();
            this.lblOId = new System.Windows.Forms.Label();
            this.dTPOrder = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.panelCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).BeginInit();
            this.gbOrder.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.gbAFunctions.SuspendLayout();
            this.gbQuantity.SuspendLayout();
            this.gbCategory.SuspendLayout();
            this.gbName.SuspendLayout();
            this.gbId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFood.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFood.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvFood.Location = new System.Drawing.Point(12, 7);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(788, 435);
            this.dgvFood.TabIndex = 0;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(881, 89);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(132, 33);
            this.txtPrice.TabIndex = 55;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(881, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(261, 33);
            this.txtName.TabIndex = 53;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtFId
            // 
            this.txtFId.BackColor = System.Drawing.SystemColors.Window;
            this.txtFId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFId.Location = new System.Drawing.Point(508, 20);
            this.txtFId.Name = "txtFId";
            this.txtFId.ReadOnly = true;
            this.txtFId.Size = new System.Drawing.Size(227, 33);
            this.txtFId.TabIndex = 52;
            this.txtFId.TextChanged += new System.EventHandler(this.txtFId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 56;
            this.label1.Text = "Food ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(746, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 57;
            this.label2.Text = "Food Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 58;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(814, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 27);
            this.label4.TabIndex = 59;
            this.label4.Text = "Price";
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.panelCustomer.Controls.Add(this.btnShowMenu);
            this.panelCustomer.Controls.Add(this.btnBrowse);
            this.panelCustomer.Controls.Add(this.cboStatus);
            this.panelCustomer.Controls.Add(this.label11);
            this.panelCustomer.Controls.Add(this.label7);
            this.panelCustomer.Controls.Add(this.label6);
            this.panelCustomer.Controls.Add(this.pbSample);
            this.panelCustomer.Controls.Add(this.gbOrder);
            this.panelCustomer.Controls.Add(this.gbPrice);
            this.panelCustomer.Controls.Add(this.btnAutoID);
            this.panelCustomer.Controls.Add(this.cboFCategory);
            this.panelCustomer.Controls.Add(this.btnBack);
            this.panelCustomer.Controls.Add(this.gbAFunctions);
            this.panelCustomer.Controls.Add(this.gbQuantity);
            this.panelCustomer.Controls.Add(this.gbCategory);
            this.panelCustomer.Controls.Add(this.gbName);
            this.panelCustomer.Controls.Add(this.btnSearch);
            this.panelCustomer.Controls.Add(this.cboSearchType);
            this.panelCustomer.Controls.Add(this.label10);
            this.panelCustomer.Controls.Add(this.gbId);
            this.panelCustomer.Controls.Add(this.btnLast);
            this.panelCustomer.Controls.Add(this.btnNext);
            this.panelCustomer.Controls.Add(this.btnPrevious);
            this.panelCustomer.Controls.Add(this.btnFirst);
            this.panelCustomer.Controls.Add(this.label4);
            this.panelCustomer.Controls.Add(this.label3);
            this.panelCustomer.Controls.Add(this.txtFId);
            this.panelCustomer.Controls.Add(this.label2);
            this.panelCustomer.Controls.Add(this.txtName);
            this.panelCustomer.Controls.Add(this.label1);
            this.panelCustomer.Controls.Add(this.txtPrice);
            this.panelCustomer.Location = new System.Drawing.Point(12, 448);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(1558, 373);
            this.panelCustomer.TabIndex = 2;
            this.panelCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomer_Paint);
            // 
            // btnShowMenu
            // 
            this.btnShowMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMenu.Location = new System.Drawing.Point(287, 311);
            this.btnShowMenu.Name = "btnShowMenu";
            this.btnShowMenu.Size = new System.Drawing.Size(101, 53);
            this.btnShowMenu.TabIndex = 87;
            this.btnShowMenu.Text = "Show All Menus";
            this.btnShowMenu.UseVisualStyleBackColor = true;
            this.btnShowMenu.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.MintCream;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnBrowse.FlatAppearance.BorderSize = 2;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(644, 258);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(213, 105);
            this.btnBrowse.TabIndex = 86;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.Enabled = false;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Available",
            "Out of Stock"});
            this.cboStatus.Location = new System.Drawing.Point(508, 162);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(229, 35);
            this.cboStatus.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(427, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 27);
            this.label11.TabIndex = 84;
            this.label11.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 27);
            this.label7.TabIndex = 82;
            this.label7.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(788, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 27);
            this.label6.TabIndex = 81;
            this.label6.Text = "Sample";
            // 
            // pbSample
            // 
            this.pbSample.BackColor = System.Drawing.Color.Transparent;
            this.pbSample.Location = new System.Drawing.Point(881, 156);
            this.pbSample.Name = "pbSample";
            this.pbSample.Size = new System.Drawing.Size(190, 190);
            this.pbSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSample.TabIndex = 80;
            this.pbSample.TabStop = false;
            this.pbSample.Click += new System.EventHandler(this.pbSample_Click);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.btnRemove);
            this.gbOrder.Controls.Add(this.btnOrder);
            this.gbOrder.Controls.Add(this.btnAddToCart);
            this.gbOrder.Location = new System.Drawing.Point(1077, 193);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(459, 170);
            this.gbOrder.TabIndex = 79;
            this.gbOrder.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.MintCream;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(145, 17);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 125);
            this.btnRemove.TabIndex = 66;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.MintCream;
            this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnOrder.FlatAppearance.BorderSize = 2;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Location = new System.Drawing.Point(290, 17);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 125);
            this.btnOrder.TabIndex = 65;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.MintCream;
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddToCart.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAddToCart.FlatAppearance.BorderSize = 2;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Location = new System.Drawing.Point(6, 17);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(125, 125);
            this.btnAddToCart.TabIndex = 64;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.txtFPrice);
            this.gbPrice.Controls.Add(this.label5);
            this.gbPrice.Location = new System.Drawing.Point(13, 169);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(379, 86);
            this.gbPrice.TabIndex = 76;
            this.gbPrice.TabStop = false;
            // 
            // txtFPrice
            // 
            this.txtFPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtFPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFPrice.Location = new System.Drawing.Point(113, 27);
            this.txtFPrice.Name = "txtFPrice";
            this.txtFPrice.Size = new System.Drawing.Size(226, 33);
            this.txtFPrice.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 73;
            this.label5.Text = "Price";
            // 
            // btnAutoID
            // 
            this.btnAutoID.BackColor = System.Drawing.Color.MintCream;
            this.btnAutoID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAutoID.BackgroundImage")));
            this.btnAutoID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAutoID.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnAutoID.FlatAppearance.BorderSize = 2;
            this.btnAutoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoID.Location = new System.Drawing.Point(407, 258);
            this.btnAutoID.Name = "btnAutoID";
            this.btnAutoID.Size = new System.Drawing.Size(213, 105);
            this.btnAutoID.TabIndex = 78;
            this.btnAutoID.UseVisualStyleBackColor = false;
            this.btnAutoID.Click += new System.EventHandler(this.btnAutoID_Click);
            // 
            // cboFCategory
            // 
            this.cboFCategory.Enabled = false;
            this.cboFCategory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFCategory.FormattingEnabled = true;
            this.cboFCategory.Items.AddRange(new object[] {
            "Beverage",
            "Main Dish",
            "Side Dish"});
            this.cboFCategory.Location = new System.Drawing.Point(508, 89);
            this.cboFCategory.Name = "cboFCategory";
            this.cboFCategory.Size = new System.Drawing.Size(229, 35);
            this.cboFCategory.TabIndex = 76;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MintCream;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 285);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 90);
            this.btnBack.TabIndex = 77;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbAFunctions
            // 
            this.gbAFunctions.Controls.Add(this.btnAAdd);
            this.gbAFunctions.Controls.Add(this.btnADelete);
            this.gbAFunctions.Controls.Add(this.btnAUpdate);
            this.gbAFunctions.Location = new System.Drawing.Point(1109, 205);
            this.gbAFunctions.Name = "gbAFunctions";
            this.gbAFunctions.Size = new System.Drawing.Size(412, 151);
            this.gbAFunctions.TabIndex = 76;
            this.gbAFunctions.TabStop = false;
            // 
            // btnAAdd
            // 
            this.btnAAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnAAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAAdd.BackgroundImage")));
            this.btnAAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAAdd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAAdd.FlatAppearance.BorderSize = 2;
            this.btnAAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAAdd.Location = new System.Drawing.Point(16, 11);
            this.btnAAdd.Name = "btnAAdd";
            this.btnAAdd.Size = new System.Drawing.Size(125, 125);
            this.btnAAdd.TabIndex = 60;
            this.btnAAdd.UseVisualStyleBackColor = false;
            this.btnAAdd.Click += new System.EventHandler(this.btnAAdd_Click);
            // 
            // btnADelete
            // 
            this.btnADelete.BackColor = System.Drawing.Color.MintCream;
            this.btnADelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnADelete.BackgroundImage")));
            this.btnADelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnADelete.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnADelete.FlatAppearance.BorderSize = 2;
            this.btnADelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADelete.Location = new System.Drawing.Point(145, 11);
            this.btnADelete.Name = "btnADelete";
            this.btnADelete.Size = new System.Drawing.Size(125, 125);
            this.btnADelete.TabIndex = 61;
            this.btnADelete.UseVisualStyleBackColor = false;
            this.btnADelete.Click += new System.EventHandler(this.btnADelete_Click);
            // 
            // btnAUpdate
            // 
            this.btnAUpdate.BackColor = System.Drawing.Color.MintCream;
            this.btnAUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAUpdate.BackgroundImage")));
            this.btnAUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAUpdate.FlatAppearance.BorderSize = 2;
            this.btnAUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAUpdate.Location = new System.Drawing.Point(276, 11);
            this.btnAUpdate.Name = "btnAUpdate";
            this.btnAUpdate.Size = new System.Drawing.Size(125, 125);
            this.btnAUpdate.TabIndex = 62;
            this.btnAUpdate.UseVisualStyleBackColor = false;
            this.btnAUpdate.Click += new System.EventHandler(this.btnAUpdate_Click);
            // 
            // gbQuantity
            // 
            this.gbQuantity.Controls.Add(this.lblTotalCost);
            this.gbQuantity.Controls.Add(this.label8);
            this.gbQuantity.Controls.Add(this.txtAddress);
            this.gbQuantity.Controls.Add(this.label15);
            this.gbQuantity.Controls.Add(this.btnPlus);
            this.gbQuantity.Controls.Add(this.btnMinus);
            this.gbQuantity.Controls.Add(this.txtQuantity);
            this.gbQuantity.Controls.Add(this.label9);
            this.gbQuantity.Location = new System.Drawing.Point(1149, 3);
            this.gbQuantity.Name = "gbQuantity";
            this.gbQuantity.Size = new System.Drawing.Size(362, 186);
            this.gbQuantity.TabIndex = 75;
            this.gbQuantity.TabStop = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(122, 142);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(24, 27);
            this.lblTotalCost.TabIndex = 88;
            this.lblTotalCost.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 27);
            this.label8.TabIndex = 87;
            this.label8.Text = "Total Cost";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(107, 83);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 33);
            this.txtAddress.TabIndex = 86;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 27);
            this.label15.TabIndex = 86;
            this.label15.Text = "Address";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.Window;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(230, 19);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 65;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.Window;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(263, 19);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(33, 33);
            this.btnMinus.TabIndex = 64;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(107, 18);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(188, 33);
            this.txtQuantity.TabIndex = 60;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 27);
            this.label9.TabIndex = 61;
            this.label9.Text = "Quantity";
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.cboCategory);
            this.gbCategory.Controls.Add(this.label14);
            this.gbCategory.Location = new System.Drawing.Point(9, 174);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(379, 86);
            this.gbCategory.TabIndex = 74;
            this.gbCategory.TabStop = false;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Beverage",
            "Main Dish",
            "Side Dish"});
            this.cboCategory.Location = new System.Drawing.Point(140, 28);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(221, 35);
            this.cboCategory.TabIndex = 75;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 27);
            this.label14.TabIndex = 73;
            this.label14.Text = "Category";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.label13);
            this.gbName.Controls.Add(this.txtSFName);
            this.gbName.Location = new System.Drawing.Point(7, 169);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(397, 75);
            this.gbName.TabIndex = 74;
            this.gbName.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 27);
            this.label13.TabIndex = 73;
            this.label13.Text = "Food Name";
            // 
            // txtSFName
            // 
            this.txtSFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSFName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFName.Location = new System.Drawing.Point(157, 28);
            this.txtSFName.Name = "txtSFName";
            this.txtSFName.Size = new System.Drawing.Size(227, 33);
            this.txtSFName.TabIndex = 73;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(182, 311);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 53);
            this.btnSearch.TabIndex = 73;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearchType
            // 
            this.cboSearchType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearchType.FormattingEnabled = true;
            this.cboSearchType.Items.AddRange(new object[] {
            "Category",
            "Food Name",
            "Food ID",
            "Price"});
            this.cboSearchType.Location = new System.Drawing.Point(143, 89);
            this.cboSearchType.Name = "cboSearchType";
            this.cboSearchType.Size = new System.Drawing.Size(221, 35);
            this.cboSearchType.TabIndex = 71;
            this.cboSearchType.SelectedIndexChanged += new System.EventHandler(this.cboSearchType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 27);
            this.label10.TabIndex = 70;
            this.label10.Text = "Search By";
            // 
            // gbId
            // 
            this.gbId.Controls.Add(this.label12);
            this.gbId.Controls.Add(this.txtSFId);
            this.gbId.Location = new System.Drawing.Point(9, 184);
            this.gbId.Name = "gbId";
            this.gbId.Size = new System.Drawing.Size(367, 71);
            this.gbId.TabIndex = 69;
            this.gbId.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 27);
            this.label12.TabIndex = 73;
            this.label12.Text = "Food ID";
            // 
            // txtSFId
            // 
            this.txtSFId.BackColor = System.Drawing.SystemColors.Window;
            this.txtSFId.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFId.Location = new System.Drawing.Point(134, 21);
            this.txtSFId.Name = "txtSFId";
            this.txtSFId.Size = new System.Drawing.Size(227, 33);
            this.txtSFId.TabIndex = 73;
            // 
            // btnLast
            // 
            this.btnLast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLast.BackgroundImage")));
            this.btnLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLast.Location = new System.Drawing.Point(287, 8);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 53);
            this.btnLast.TabIndex = 68;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Location = new System.Drawing.Point(204, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 53);
            this.btnNext.TabIndex = 67;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.Location = new System.Drawing.Point(122, 8);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 53);
            this.btnPrevious.TabIndex = 66;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirst.BackgroundImage")));
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirst.Location = new System.Drawing.Point(42, 8);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(60, 53);
            this.btnFirst.TabIndex = 65;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(807, 37);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(741, 405);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // lblCId
            // 
            this.lblCId.AutoSize = true;
            this.lblCId.BackColor = System.Drawing.Color.Transparent;
            this.lblCId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCId.Location = new System.Drawing.Point(1426, 7);
            this.lblCId.Name = "lblCId";
            this.lblCId.Size = new System.Drawing.Size(78, 25);
            this.lblCId.TabIndex = 24;
            this.lblCId.Text = "UserID";
            // 
            // lblOId
            // 
            this.lblOId.AutoSize = true;
            this.lblOId.BackColor = System.Drawing.Color.Transparent;
            this.lblOId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOId.Location = new System.Drawing.Point(806, 9);
            this.lblOId.Name = "lblOId";
            this.lblOId.Size = new System.Drawing.Size(88, 25);
            this.lblOId.TabIndex = 25;
            this.lblOId.Text = "OrderID";
            // 
            // dTPOrder
            // 
            this.dTPOrder.Enabled = false;
            this.dTPOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPOrder.Location = new System.Drawing.Point(966, 3);
            this.dTPOrder.Name = "dTPOrder";
            this.dTPOrder.Size = new System.Drawing.Size(393, 33);
            this.dTPOrder.TabIndex = 28;
            // 
            // FoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 823);
            this.Controls.Add(this.dTPOrder);
            this.Controls.Add(this.lblOId);
            this.Controls.Add(this.lblCId);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.dgvFood);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FoodMenu";
            this.Text = "FoodMenu";
            this.Load += new System.EventHandler(this.FoodMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSample)).EndInit();
            this.gbOrder.ResumeLayout(false);
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.gbAFunctions.ResumeLayout(false);
            this.gbQuantity.ResumeLayout(false);
            this.gbQuantity.PerformLayout();
            this.gbCategory.ResumeLayout(false);
            this.gbCategory.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbId.ResumeLayout(false);
            this.gbId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAAdd;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSFName;
        private System.Windows.Forms.ComboBox cboSearchType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSFId;
        private System.Windows.Forms.Button btnAUpdate;
        private System.Windows.Forms.GroupBox gbQuantity;
        private System.Windows.Forms.GroupBox gbAFunctions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboFCategory;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnAutoID;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.TextBox txtFPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblCId;
        private System.Windows.Forms.Label lblOId;
        private System.Windows.Forms.DateTimePicker dTPOrder;
        private System.Windows.Forms.Button btnADelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbSample;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnShowMenu;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label8;
    }
}