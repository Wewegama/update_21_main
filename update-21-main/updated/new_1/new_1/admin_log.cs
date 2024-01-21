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
    public partial class frm_admin_log : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.Login_Database1ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;

        public object txt_StudentID { get; private set; }

        public frm_admin_log()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("SELECT * FROM tbllog WHERE AdminID='" +txt_AdminID.Text+ "' and Password='"+ txt_Password.Text+"'",conn);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i=  ds.Tables [0].Rows.Count;
            if (i == 0)
            {
                frm_admin_log fh = new frm_admin_log();
                fh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Plece Check Your User Name Or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void admin_log_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adminDB_Appdata.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.adminDB_Appdata.tbllog);


        }
    }
}
