using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_1
{
    public partial class Studets__profile : MetroFramework.Forms.MetroForm
    {
        public Studets__profile()
        {
            InitializeComponent();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            student_Login student_Login = new student_Login();
            student_Login.Show();
            this.Hide();
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            my_courses my_Courses = new my_courses();
            my_Courses.Show();
            this.Hide();
        }
    }
}
