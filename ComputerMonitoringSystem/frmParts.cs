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
    public partial class frmParts : Form
    {
        public frmParts()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int PartsID, maxrow;

        private void frmParts_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "Select PartsID,`Parts`  From tblparts WHERE Parts Like '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtglist);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtParts.Text == "")
            {
                funct.messagerequired();
            }
             
            sql = "Select * From tblparts WHERE PartsID = " + PartsID;
            maxrow = config.maxrow(sql);
            if(maxrow > 0)
            {
                sql = "UPDATE `tblparts` SET `Parts`='" + txtParts.Text + "' WHERE PartsID=" + PartsID;
                config.Execute_CUD(sql, "error to execute the query", "Parts has been updated in the database.");
            }
            else
            {
                sql = "INSERT INTO `tblparts` (`Parts` ) VALUES ('" + txtParts.Text + "' )";
                config.Execute_CUD(sql, "error to execute the query", "New Parts has been saved in the database.");
            }
            btnnew_Click(sender, e);
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PartsID = int.Parse( dtglist.CurrentRow.Cells[0].Value.ToString());
            txtParts.Text = dtglist.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            PartsID = 0;
            txtParts.Clear();
            sql = "Select PartsID,`Parts`  From tblparts";
            config.Load_DTG(sql, dtglist);
        }
    }
}
