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
    public partial class frmListofItems : Form
    {
        public frmListofItems()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxrow;
        private void frmListofItems_Load(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT  ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status " 
                 + " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID " 
                 + "AND (Barcode Like '%" + txtSearch.Text + "%' OR Parts Like '%" 
                 + txtSearch.Text + "%' OR Brand Like '%" + txtSearch.Text + "%' OR i.Description Like '%"
                 + txtSearch.Text + "%' OR Location Like '%" + txtSearch.Text + "%')";
            config.Load_DTG(sql, DataGridView1);
            DataGridView1.Columns[0].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int itemid = int.Parse(DataGridView1.CurrentRow.Cells[0].Value.ToString()); 
            Form frm = new frmEditItem(itemid);
            frm.ShowDialog();
            //.Show()
            //.Focus()
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT  ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status "
                + " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID "
                + "AND (Status Like '%" + ComboBox1.Text + "%')";
            config.Load_DTG(sql, DataGridView1);
            DataGridView1.Columns[0].Visible = false;
        }
    }
}
