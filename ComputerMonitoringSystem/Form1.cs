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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void closefrm()
        {
            foreach(Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void showfrm(Form frm)
        {
            //closefrm();

            //this.IsMdiContainer = true;
            //frm.MdiParent = this;
            //frm.Show(); 

            frm.ShowDialog();


        }

        public void enabled_menu()
        {
            tsItems.Enabled = true;
            tsUtilities.Enabled = true;
            tsTransfer.Enabled = true;
            tsUsers.Enabled = true;
            tsDamage.Enabled = true;
            tsLost.Enabled = true;
            tsListOfItems.Enabled = true;
            tsReports.Enabled = true;
            tsUnderMaintenance.Enabled = true;
            tsLogin.Text = "Logout";
        }

        public void disabled_menu()
        {
            tsItems.Enabled = false;
            tsUtilities.Enabled = false;
            tsTransfer.Enabled = false;
            tsUsers.Enabled = false;
            tsDamage.Enabled = false;
            tsLost.Enabled = false;
            tsListOfItems.Enabled = false;
            tsReports.Enabled = false;
            tsUnderMaintenance.Enabled = false;
            tsLogin.Text = "Login";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();
        }

        private void tsTransfer_Click(object sender, EventArgs e)
        {
            showfrm(new frmTransfer());
        }

        private void tsUnderMaintenance_Click(object sender, EventArgs e)
        {
            showfrm(new frmMaintenance());
        }

        private void tsLost_Click(object sender, EventArgs e)
        {
            showfrm(new frmLost());
        }

        private void tsDamage_Click(object sender, EventArgs e)
        {
            showfrm(new frmDamage());
        }

        private void tsListOfItems_Click(object sender, EventArgs e)
        {
            showfrm(new frmListofItems());
        }

        private void tsItems_Click(object sender, EventArgs e)
        {
            showfrm(new frmItems());
        }

        private void tsParts_Click(object sender, EventArgs e)
        {
            showfrm(new frmParts());
        }

        private void tsBrand_Click(object sender, EventArgs e)
        {
            showfrm(new frmBrand());
        }

        private void tsLocation_Click(object sender, EventArgs e)
        {
            showfrm(new frmLocation());
        }

        private void tsCompSet_Click(object sender, EventArgs e)
        {
            showfrm(new frmSet());
        }

        private void tsUsers_Click(object sender, EventArgs e)
        {
            showfrm(new frmUser());
        }

        private void tsReports_Click(object sender, EventArgs e)
        {
            showfrm(new frmReports());
        }

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if(tsLogin.Text == "Login")
            {
                showfrm(new frmLogin(this));
            }
            else
            {
                disabled_menu();
            }
        }
    }
}
