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

namespace new_1
{
    public partial class student_Login : MetroFramework.Forms.MetroForm
    {
        public static student_Login instence;

        public student_Login()
        {
            InitializeComponent();
            instence = this;
        }

        private void Login_2_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
  

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
