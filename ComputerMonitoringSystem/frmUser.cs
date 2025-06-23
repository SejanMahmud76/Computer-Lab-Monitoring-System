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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int CompSetID, maxrow;

        private void btn_New_Click(object sender, EventArgs e)
        {

            lbl_id.Text = "id";
            funct.clearTxt(this);
            cbo_type.Text = "Administrator";
            config.Load_DTG("Select UserID as 'ID' ,Fullname as 'Name',Username as 'Username',Role as 'Type' From tbluseraccounts WHERE Status='Active'", dtg_listUser);
            dtg_listUser.Columns[0].Visible = false;
            if(lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
             
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dtg_listUser.CurrentRow.Cells[1].Value.ToString();
            txt_username.Text = dtg_listUser.CurrentRow.Cells[2].Value.ToString();
            cbo_type.Text = dtg_listUser.CurrentRow.Cells[3].Value.ToString();

            if (lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {
            if( txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
            {
                funct.messagerequired();
            }


            sql = "insert into tbluseraccounts (`Fullname`, `Username`, `Pass`, `Role`,`Status`) "
             + "values('" + txt_name.Text + "','" + txt_username.Text
             + "',sha1('" + txt_pass.Text + "'),'" + cbo_type.Text
             + "','Active')";
            config.Execute_CUD(sql, "error to execute the query.", "New User has been saved in the database.");

 
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
            {
                funct.messagerequired();
            }


            sql = "update tbluseraccounts set Fullname = '" + txt_name.Text + "',Username= '" + txt_username.Text 
                + "',Pass= sha1('" + txt_pass.Text + "'),Role= '" + cbo_type.Text 
                + "' where UserID = " + lbl_id.Text;
            config.Execute_CUD(sql, "error to execute the query.", "User has been updated in the database.");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        { 
            sql = "DELETE FROM tbluseraccounts  where UserID = " + lbl_id.Text;
            config.Execute_CUD(sql, "error to execute the query.", "User has been deleted in the database.");
            btn_New_Click(sender, e);
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }
    }
}
