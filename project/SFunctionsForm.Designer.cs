namespace project
{
    partial class SFunctionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFunctionsForm));
            this.btnSEdit = new System.Windows.Forms.Button();
            this.btnLOut = new System.Windows.Forms.Button();
            this.lblSUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSEdit
            // 
            this.btnSEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSEdit.BackgroundImage")));
            this.btnSEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSEdit.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnSEdit.FlatAppearance.BorderSize = 2;
            this.btnSEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnSEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEdit.Location = new System.Drawing.Point(539, 156);
            this.btnSEdit.Name = "btnSEdit";
            this.btnSEdit.Size = new System.Drawing.Size(200, 200);
            this.btnSEdit.TabIndex = 23;
            this.btnSEdit.UseVisualStyleBackColor = true;
            this.btnSEdit.Click += new System.EventHandler(this.btnSEdit_Click);
            // 
            // btnLOut
            // 
            this.btnLOut.BackColor = System.Drawing.Color.MintCream;
            this.btnLOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLOut.BackgroundImage")));
            this.btnLOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLOut.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnLOut.FlatAppearance.BorderSize = 2;
            this.btnLOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnLOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOut.Location = new System.Drawing.Point(516, 526);
            this.btnLOut.Name = "btnLOut";
            this.btnLOut.Size = new System.Drawing.Size(240, 135);
            this.btnLOut.TabIndex = 26;
            this.btnLOut.UseVisualStyleBackColor = false;
            this.btnLOut.Click += new System.EventHandler(this.btnLOut_Click);
            // 
            // lblSUsername
            // 
            this.lblSUsername.AutoSize = true;
            this.lblSUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblSUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUsername.Location = new System.Drawing.Point(1105, 9);
            this.lblSUsername.Name = "lblSUsername";
            this.lblSUsername.Size = new System.Drawing.Size(110, 25);
            this.lblSUsername.TabIndex = 27;
            this.lblSUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1048, 225);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // SFunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSUsername);
            this.Controls.Add(this.btnLOut);
            this.Controls.Add(this.btnSEdit);
            this.DoubleBuffered = true;
            this.Name = "SFunctionsForm";
            this.Text = "SFunctionsForm";
            this.Load += new System.EventHandler(this.SFunctionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSEdit;
        private System.Windows.Forms.Button btnLOut;
        private System.Windows.Forms.Label lblSUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}