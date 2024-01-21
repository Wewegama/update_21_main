using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace new_1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Form1 instence;
        SqlConnection con = new SqlConnection(Properties.Settings.Default.Login_Database1ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            instence = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frm_admin_log form = new frm_admin_log();
            form.Show();
            this.Hide();

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are want to exit", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }


            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void    metroButton2_Click(object sender, EventArgs e)
        {
            student_Login student_Login = new student_Login();
            student_Login.Show();
            this.Hide();
        }

    }
}
