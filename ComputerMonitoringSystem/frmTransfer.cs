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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int CompSetID, maxrow;

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sql = "SELECT *,i.Description as ItemDesc " +
            " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c "
             + "WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` "
             + "AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND Status='Good' AND ItemID=" + dtgList.CurrentRow.Cells[0].Value;
            maxrow = config.maxrow(sql);
            if(maxrow > 0)
            {
                txtBarcode.Text = config.dt.Rows[0].Field<string>("Barcode");
                txtBrand.Text = config.dt.Rows[0].Field<string>("Brand");
                txtItems.Text = config.dt.Rows[0].Field<string>("ItemDesc");
                txtParts.Text = config.dt.Rows[0].Field<string>("Parts");
                txtLocated.Text = config.dt.Rows[0].Field<string>("Location");
                txtCompSet.Text = config.dt.Rows[0].Field<string>("ComputerSet");
            } 
        }

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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if( txtBarcode.Text == "")
            {
                funct.messagerequired();
            }


            sql = "SELECT * " +
              " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c "
               + "WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` "
               + "AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND Status='Good' "
               + "AND  i.`LocationID`=" + cboLocation.SelectedValue + " AND i.CompSetID=" + cboCompSet.SelectedValue + " AND Parts='" + txtParts.Text + "'";
             maxrow = config.maxrow(sql);
            if (maxrow > 0)
            {
                MessageBox.Show(txtParts.Text + " already exist in the competer", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                sql = "INSERT INTO  `tbltransfer` (`ItemID`, `Item`, `Parts`, `LocationFROM`, `LocationTO`, `PCFrom`, `PCTo`, `TransferDate`) " +
                    " VALUES (" + dtgList.CurrentRow.Cells[0].Value + ",'" + txtItems.Text + "','" + txtParts.Text + "','" + txtLocated.Text + "','" + cboLocation.Text + "','" + txtCompSet.Text + "','" + cboCompSet.Text + "',DATE(NOW()))";
                config.Execute_Query(sql);

                sql = "UPDATE `tblitems` SET `LocationID`=" + cboLocation.SelectedValue + ",`CompSetID`=" + cboCompSet.SelectedValue + ",`Remarks`='Transfered' WHERE `ItemID`=" + dtgList.CurrentRow.Cells[0].Value;
                config.Execute_Query(sql);


                frmTransfer_Load(sender, e);
                //cbo_fill(cboCompSet, "ComputerSet", "CompSetID", "tblcompset") 

                MessageBox.Show("Computer parts has been transferred.");
            


            } 
     
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            sql = "SELECT LocationID,Location FROM tbllocation";
            config.fiil_CBO(sql, cboLocation);

            sql = "SELECT CompSetID,ComputerSet FROM tblcompset";
            config.fiil_CBO(sql, cboCompSet);
             
            sql = "SELECT ItemID, `Parts`,`Location`, `ComputerSet` FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND Status='Good'";
            config.Load_DTG(sql, dtgList);
            dtgList.Columns[0].Visible = false;

            funct.clearTxt(GroupBox1);
        }
    }
}
