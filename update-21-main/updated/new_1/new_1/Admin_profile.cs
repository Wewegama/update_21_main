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
    public partial class Admin_profile : MetroFramework.Forms.MetroForm
    {
        public Admin_profile()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are want to exit", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Admin_profile_Load(object sender, EventArgs e)
        {

        }
    }
}
