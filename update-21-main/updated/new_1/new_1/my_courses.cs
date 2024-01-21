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
    public partial class my_courses : MetroFramework.Forms.MetroForm
    {
        public my_courses()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Studets__profile studets__Profile = new Studets__profile();
            studets__Profile.Show();
            this.Hide();
        }
    }
}
