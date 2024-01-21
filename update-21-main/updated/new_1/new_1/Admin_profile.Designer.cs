namespace new_1
{
    partial class Admin_profile
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btn_Add_New_Student = new MetroFramework.Controls.MetroButton();
            this.btn_Log_out = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(189, 223);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(348, 33);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Delet Student Account";
            this.metroButton2.UseSelectable = true;
            // 
            // btn_Add_New_Student
            // 
            this.btn_Add_New_Student.Location = new System.Drawing.Point(189, 165);
            this.btn_Add_New_Student.Name = "btn_Add_New_Student";
            this.btn_Add_New_Student.Size = new System.Drawing.Size(348, 33);
            this.btn_Add_New_Student.TabIndex = 0;
            this.btn_Add_New_Student.Text = "Add New Students";
            this.btn_Add_New_Student.UseSelectable = true;
            // 
            // btn_Log_out
            // 
            this.btn_Log_out.Location = new System.Drawing.Point(337, 394);
            this.btn_Log_out.Name = "btn_Log_out";
            this.btn_Log_out.Size = new System.Drawing.Size(130, 33);
            this.btn_Log_out.TabIndex = 2;
            this.btn_Log_out.Text = "Log Out";
            this.btn_Log_out.UseSelectable = true;
            this.btn_Log_out.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(647, 394);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(130, 33);
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Exit";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(189, 273);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(348, 33);
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "Student List";
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(498, 394);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(130, 33);
            this.metroButton6.TabIndex = 2;
            this.metroButton6.Text = "Start up menu";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Admin_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 457);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.btn_Log_out);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btn_Add_New_Student);
            this.Name = "Admin_profile";
            this.Text = "Admin Profile";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Admin_profile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_Add_New_Student;
        private MetroFramework.Controls.MetroButton btn_Log_out;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
    }
}