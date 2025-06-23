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
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int CompSetID, maxrow;
        private void frmSet_Load(object sender, EventArgs e)
        {
            Button2_Click(sender, e);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "Select CompSetID,`ComputerSet`  From tblcompset WHERE ComputerSet Like '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtglist);
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CompSetID = int.Parse(dtglist.CurrentRow.Cells[0].Value.ToString());
            txtComputerSet.Text = dtglist.CurrentRow.Cells[1].Value.ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(txtComputerSet.Text == "")
            {
                funct.messagerequired();
            }
            sql = "Select * From tblcompset WHERE CompSetID = " + CompSetID;
            maxrow = config.maxrow(sql);
            if(maxrow > 0)
            {
                sql = "UPDATE `tblcompset` SET `ComputerSet`='" + txtComputerSet.Text + "' WHERE CompSetID=" + CompSetID;
                config.Execute_CUD(sql, "error to execute the query.", "ComputerSet has been updated in the database.");
            }
            else
            {
                sql = "INSERT INTO `tblcompset` (`ComputerSet` ) VALUES ('" + txtComputerSet.Text + "' )";
                config.Execute_CUD(sql, "error to execute the query.", "New ComputerSet has been saved in the database.");
            }

            Button2_Click(sender, e);


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CompSetID = 0;
            txtComputerSet.Clear();
            sql = "Select CompSetID,`ComputerSet`  From tblcompset";
            config.Load_DTG(sql, dtglist);
        }
    }
}
