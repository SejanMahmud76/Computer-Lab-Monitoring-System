using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerMonitoringSystem
{
    public partial class frmLogin : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxrow;

        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

            sql = "SELECT * FROM `tbluseraccounts` WHERE Username= '" + UsernameTextBox.Text + "' and Pass = sha1('" + PasswordTextBox.Text + "')";
            maxrow = config.maxrow(sql);
            if (maxrow > 0)
            {
                MessageBox.Show("Welcome User");
                frm.enabled_menu();

                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist. Please contact administrator.","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
