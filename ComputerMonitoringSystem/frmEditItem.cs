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
    public partial class frmEditItem : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxrow;
        public frmEditItem(int itemid)
        {
            InitializeComponent();

            sql = "SELECT PartsID, Parts FROM tblparts";
            config.fiil_CBO(sql, cboParts);
            sql = "SELECT BrandID,  Brand FROM tblbrand";
            config.fiil_CBO(sql, cboBrand);
            sql = "SELECT  LocationID,Location FROM tbllocation";
            config.fiil_CBO(sql, cboLocation);
            sql = "SELECT  CompSetID,ComputerSet FROM tblcompset";
            config.fiil_CBO(sql, cboCompSet);

            sql = "SELECT *,i.Description as 'Desc'  FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " 
            + "WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND ItemID=" + itemid;
            maxrow =  config.maxrow(sql); 
            if (maxrow > 0)
            {
                txtBarcode.Text = config.dt.Rows[0].Field<string>("Barcode");
                cboParts.Text = config.dt.Rows[0].Field<string>("Parts");
                cboBrand.Text = config.dt.Rows[0].Field<string>("Brand");
                txtDescription.Text = config.dt.Rows[0].Field<string>("Desc");
                cboLocation.Text = config.dt.Rows[0].Field<string>("Location");
                cboCompSet.Text = config.dt.Rows[0].Field<string>("ComputerSet");
            }


            
        }

        private void frmEditItem_Load(object sender, EventArgs e)
        {

        }
         

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtBarcode.Text == "" || txtDescription.Text == "")
            {
                funct.messagerequired();
            }

            //sql = "SELECT * FROM `tblitems` WHERE `PartsID`=" + cboParts.SelectedValue +
            //    " AND `LocationID`=" + cboLocation.SelectedValue + " AND `CompSetID`=" + cboCompSet.SelectedValue;
            //maxrow = config.maxrow(sql);
            //if (maxrow > 0)
            //{
            //    MessageBox.Show(cboParts.Text + " is already exist in the computer ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
                sql = "UPDATE `tblitems` SET  `BrandID`='" + cboBrand.SelectedValue + "', `Description`='" + txtDescription.Text + "', `PartsID`=" + cboParts.SelectedValue + ", `LocationID`=" + cboLocation.SelectedValue + ", `CompSetID`=" + cboCompSet.SelectedValue + " WHERE  `Barcode`='" + txtBarcode.Text + "'";
                config.Execute_CUD(sql, "error to execute the query.", "Item updated successfully.");
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
