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
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int CompSetID, maxrow;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT ItemID, `Parts`,`Location`, `ComputerSet` "
               + "FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c "
               + "WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` "
               + "AND i.CompSetID=c.CompSetID AND Status='Good' AND (Parts Like '%" + txtSearch.Text
               + "%' OR Location Like '%" + txtSearch.Text + "%' OR ComputerSet Like '%" + txtSearch.Text
               + "%' OR CONCAT(Parts,' ',ComputerSet,' ', Location) LIKE '%" + txtSearch.Text + "%')";
            config.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT *,i.Description as ItemDesc " + 
            " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c "
             + "WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` "
             + "AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND Status='Good' AND ItemID=" + dtgList.CurrentRow.Cells[0].Value;
            maxrow = config.maxrow(sql);
            if (maxrow > 0)
            {
                txtBarcode.Text = config.dt.Rows[0].Field<string>("Barcode");
                txtBrand.Text = config.dt.Rows[0].Field<string>("Brand");
                txtItems.Text = config.dt.Rows[0].Field<string>("ItemDesc");
                txtParts.Text = config.dt.Rows[0].Field<string>("Parts");
                txtLocated.Text = config.dt.Rows[0].Field<string>("Location");
                txtCompSet.Text = config.dt.Rows[0].Field<string>("ComputerSet");
            } 
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if( txtBarcode.Text == "")
            {
                funct.messagerequired();
            }


            sql = "UPDATE `tblitems` SET `Status`='Maintenance',RecievedDate = Now() WHERE `ItemID`=" + dtgList.CurrentRow.Cells[0].Value;
            config.Execute_Query(sql);
             
            MessageBox.Show("Computer parts has been under maintenance.");
            frmMaintenance_Load(sender, e);


        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        { 
            sql = "SELECT ItemID, `Parts`,`Location`, `ComputerSet` FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND Status='Good'";
            config.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;

            funct.clearTxt(GroupBox1);

        }
    }
}
