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
    public partial class frm_add_new_student : MetroFramework.Forms.MetroForm
    {
        public frm_add_new_student()
        {
            InitializeComponent();
        }

        private void add_new_student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminDB_Appdata.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.adminDB_Appdata.tbllog);

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are want to exit", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
