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
    public partial class frmBrand : Form
    {
        public frmBrand()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string BrandID = "0";
        string sql;

        private void btnnew_Click(object sender, EventArgs e)
        {
            BrandID = "0";
            txtBrand.Clear();
            txtDesc.Clear();
            sql = "Select BrandID,`Brand`,`Description` From tblbrand";
            config.Load_DTG(sql, dtglist);
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            btnnew_Click(sender, e);
        }

        private void dtglist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BrandID = dtglist.CurrentRow.Cells[0].Value.ToString();
            txtBrand.Text = dtglist.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = dtglist.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if( txtBrand.Text == "")
            {
                funct.messagerequired();
            }


            sql = "Select * From tblbrand WHERE BrandID = " + BrandID;
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                sql = "UPDATE `tblBrand` SET `Brand`='" + txtBrand.Text + "',`Description`='" + txtDesc.Text + "' WHERE BrandID=" + BrandID;
                config.Execute_CUD(sql, "error to execute the query", "Brand has been updated in the database.");
            }
            else
            {
                sql = "INSERT INTO `tblBrand` (`Brand`,`Description`) VALUES ('" + txtBrand.Text + "','" + txtDesc.Text + "')";
                config.Execute_CUD(sql, "error to execute the query", "New brand has been saved in the database");
            } 

            frmBrand_Load(sender, e);
                 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "Select BrandID,`Brand`,`Description`  From tblbrand WHERE Brand Like '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtglist);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE From tblbrand WHERE BrandID = " + BrandID;
            config.Execute_CUD(sql, "error to execute the query", "Brand has been deleted in the database");
            frmBrand_Load(sender, e);
        }
    }
}
