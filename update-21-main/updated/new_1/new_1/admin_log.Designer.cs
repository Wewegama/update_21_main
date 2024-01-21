namespace new_1
{
    partial class frm_admin_log
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin_log));
            this.btn_Back = new MetroFramework.Controls.MetroButton();
            this.txt_Password = new MetroFramework.Controls.MetroTextBox();
            this.tbllogBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adminDB_Appdata = new new_1.AdminDB_Appdata();
            this.txt_AdminID = new MetroFramework.Controls.MetroTextBox();
            this.tbllogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.Username = new MetroFramework.Controls.MetroLabel();
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.tbllogTableAdapter = new new_1.AdminDB_AppdataTableAdapters.tbllogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDB_Appdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(199, 338);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(101, 24);
            this.btn_Back.TabIndex = 10;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseSelectable = true;
            this.btn_Back.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.AccessibleName = "txt_Password";
            // 
            // 
            // 
            this.txt_Password.CustomButton.Image = null;
            this.txt_Password.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_Password.CustomButton.Name = "";
            this.txt_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Password.CustomButton.TabIndex = 1;
            this.txt_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Password.CustomButton.UseSelectable = true;
            this.txt_Password.CustomButton.Visible = false;
            this.txt_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource1, "StudentID", true));
            this.txt_Password.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Password.Lines = new string[0];
            this.txt_Password.Location = new System.Drawing.Point(61, 229);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.ShortcutsEnabled = true;
            this.txt_Password.Size = new System.Drawing.Size(187, 23);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_Password.UseSelectable = true;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // tbllogBindingSource1
            // 
            this.tbllogBindingSource1.DataMember = "tbllog";
            this.tbllogBindingSource1.DataSource = this.adminDB_Appdata;
            // 
            // adminDB_Appdata
            // 
            this.adminDB_Appdata.DataSetName = "AdminDB_Appdata";
            this.adminDB_Appdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_AdminID
            // 
            this.txt_AdminID.AccessibleName = "txt_AdminID";
            // 
            // 
            // 
            this.txt_AdminID.CustomButton.Image = null;
            this.txt_AdminID.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txt_AdminID.CustomButton.Name = "";
            this.txt_AdminID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_AdminID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_AdminID.CustomButton.TabIndex = 1;
            this.txt_AdminID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_AdminID.CustomButton.UseSelectable = true;
            this.txt_AdminID.CustomButton.Visible = false;
            this.txt_AdminID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbllogBindingSource, "StudentID", true));
            this.txt_AdminID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_AdminID.Lines = new string[0];
            this.txt_AdminID.Location = new System.Drawing.Point(61, 153);
            this.txt_AdminID.MaxLength = 32767;
            this.txt_AdminID.Name = "txt_AdminID";
            this.txt_AdminID.PasswordChar = '\0';
            this.txt_AdminID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_AdminID.SelectedText = "";
            this.txt_AdminID.SelectionLength = 0;
            this.txt_AdminID.SelectionStart = 0;
            this.txt_AdminID.ShortcutsEnabled = true;
            this.txt_AdminID.Size = new System.Drawing.Size(187, 23);
            this.txt_AdminID.TabIndex = 8;
            this.txt_AdminID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_AdminID.UseSelectable = true;
            this.txt_AdminID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_AdminID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_AdminID.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // tbllogBindingSource
            // 
            this.tbllogBindingSource.DataMember = "tbllog";
            this.tbllogBindingSource.DataSource = this.adminDB_Appdata;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Password.Location = new System.Drawing.Point(118, 198);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 19);
            this.Password.TabIndex = 7;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Username.Location = new System.Drawing.Point(118, 122);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(71, 19);
            this.Username.TabIndex = 6;
            this.Username.Text = "Admin ID";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(44, 338);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(101, 24);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseSelectable = true;
            this.btn_Login.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // tbllogTableAdapter
            // 
            this.tbllogTableAdapter.ClearBeforeFill = true;
            // 
            // frm_admin_log
            // 
            this.AccessibleName = "txt_Password";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 385);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_AdminID);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(323, 385);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(323, 385);
            this.Name = "frm_admin_log";
            this.Text = "Admin login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.admin_log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDB_Appdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Back;
        private MetroFramework.Controls.MetroTextBox txt_Password;
        private MetroFramework.Controls.MetroTextBox txt_AdminID;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroLabel Username;
        private MetroFramework.Controls.MetroButton btn_Login;
        private AdminDB_Appdata adminDB_Appdata;
        private System.Windows.Forms.BindingSource tbllogBindingSource;
        private AdminDB_AppdataTableAdapters.tbllogTableAdapter tbllogTableAdapter;
        private System.Windows.Forms.BindingSource tbllogBindingSource1;
    }
}