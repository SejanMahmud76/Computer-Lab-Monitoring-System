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
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();

        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int LocationID,maxrow;
        private void btnnew_Click(object sender, EventArgs e)
        {
            LocationID = 0;
            txtLocation.Clear();
            sql = "Select LocationID,`Location`  From tbllocation";
            config.Load_DTG(sql, dtglist);
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            btnnew_Click( sender,  e);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "Select LocationID,`Location`  From tbllocation WHERE Location Like '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtglist);
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LocationID = int.Parse(dtglist.CurrentRow.Cells[0].Value.ToString());
            txtLocation.Text = dtglist.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            if( txtLocation.Text == "")
            {
                funct.messagerequired();
            }

            sql = "Select * From tbllocation WHERE LocationID = " + LocationID;
            maxrow = config.maxrow(sql);

            if(maxrow > 0)
            {
                sql = "UPDATE `tbllocation` SET `Location`='" + txtLocation.Text + "' WHERE LocationID=" + LocationID;
                config.Execute_CUD(sql, "error to execute the query", "Location has been updated in the database");
            }
            else
            { 
                sql = "INSERT INTO `tbllocation` (`Location` ) VALUES ('" + txtLocation.Text + "' )";
                config.Execute_CUD(sql, "error to execute the query", "New Location has been saved in the database");
            }
            btnnew_Click(sender, e);
            
        }
    }
}
