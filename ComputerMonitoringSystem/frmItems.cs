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
    public partial class frmItems : Form
    {
        public frmItems()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction(); 
        string sql;
        int maxrow;
        private void btnNew_Click(object sender, EventArgs e)
        {
            funct.clearTxt(this);

            sql = "SELECT PartsID, Parts FROM tblparts";
            config.fiil_CBO(sql,cboParts);
            sql = "SELECT BrandID,  Brand FROM tblbrand";
            config.fiil_CBO(sql, cboBrand);
            sql = "SELECT  LocationID,Location FROM tbllocation";
            config.fiil_CBO(sql, cboLocation);
            sql = "SELECT  CompSetID,ComputerSet FROM tblcompset";
            config.fiil_CBO(sql, cboCompSet); 
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e); 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(txtBarcode.Text == "" || txtDescription.Text == "")
            {
                funct.messagerequired();
            }

            sql = "SELECT * FROM `tblitems` WHERE `PartsID`=" + cboParts.SelectedValue + 
                " AND `LocationID`=" + cboLocation.SelectedValue + " AND `CompSetID`=" + cboCompSet.SelectedValue;
            maxrow = config.maxrow(sql); 
            if(maxrow > 0)
            {
                MessageBox.Show(cboParts.Text + " is already exist in the computer ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sql = "INSERT INTO `tblitems` (`Barcode`, `BrandID`, `Description`, `PartsID`, `RecievedDate`, `Quantity`, `LocationID`, `CompSetID`, `Status`) " + 
                             " VALUES ('" + txtBarcode.Text + "'," + cboBrand.SelectedValue + ",'" + txtDescription.Text + "'," + cboParts.SelectedValue + ",Date(Now()),1," + cboLocation.SelectedValue + "," + cboCompSet.SelectedValue + ",'Good')";
                config.Execute_CUD(sql, "error to execute the query.", "New item created successfully.");
            }

            btnNew_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
