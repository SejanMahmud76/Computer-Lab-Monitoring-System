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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void reports(string sql, string rptname)
        {

            try
            {

                config.loadReports(sql);

                string reportname = rptname;


                CrystalDecisions.CrystalReports.Engine.ReportDocument reportdoc = new CrystalDecisions.CrystalReports.Engine.ReportDocument(); ;

                string strReportPath = Application.StartupPath + "\\reports\\" + reportname + ".rpt";


                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(config.dt);

                crystalReportViewer1.ReportSource = reportdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }


        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            sql = "SELECT LocationID,Location FROM tbllocation";
            config.fiil_CBO(sql, cboLocation);

            sql = "SELECT PartsID,Parts FROM tblparts";
            config.fiil_CBO(sql, cboParts); 
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            if( cboLocation.Text == "Select" && cboParts.Text == "Select"){
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID";
            }
            else if (cboLocation.Text == "Select" && cboParts.Text != "Select"){
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " + 
                    " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                    " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " + 
                    " AND i.CompSetID=c.CompSetID AND Parts Like '%" + cboParts.Text + "%'";

            }
            else if (cboLocation.Text != "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " + 
                    " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " + 
                    " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " + 
                    " AND i.CompSetID=c.CompSetID AND Location Like '%" + cboLocation.Text + "%'";
            }
            else
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                    " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                    " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                    " AND i.CompSetID=c.CompSetID AND Location Like '%" + cboLocation.Text + "%' AND Parts Like '%" + cboParts.Text + "%'";
            }
             
            reports(sql, "listofitems");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (cboLocation.Text == "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                    " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                    " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                    " AND i.CompSetID=c.CompSetID AND Status='Lost'";
            }
            else if (cboLocation.Text == "Select" && cboParts.Text != "Select")
            {

                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                   " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                   " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                   " AND i.CompSetID=c.CompSetID AND Status='Lost' AND Parts Like '%" + cboParts.Text + "%'";
            }
            else if (cboLocation.Text != "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                   " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                   " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                   " AND i.CompSetID=c.CompSetID AND Status='Lost' AND Location Like '%" + cboLocation.Text + "%'";
            }
            else
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                  " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                  " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                  " AND i.CompSetID=c.CompSetID AND Status='Lost' AND Location Like '%" + cboLocation.Text + "%' AND Parts Like '%" + cboParts.Text + "%'";
            }
             
            reports(sql, "lostitems");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (cboLocation.Text == "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND Status='Maintenance'";

            }
            else if (cboLocation.Text == "Select" && cboParts.Text != "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                   " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                   " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                   " AND i.CompSetID=c.CompSetID AND Status='Maintenance' AND Parts Like '%" + cboParts.Text + "%'";


            }
            else if (cboLocation.Text != "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                   " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                   " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                   " AND i.CompSetID=c.CompSetID AND Status='Maintenance' AND Location Like '%" + cboLocation.Text + "%'";
            }
            else
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                    " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                    " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                    " AND i.CompSetID=c.CompSetID AND Status='Maintenance' AND Location Like '%" + cboLocation.Text + "%' AND Parts Like '%" + cboParts.Text + "%'";
            }
            reports(sql, "maintenanceitems");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (cboLocation.Text == "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` AND i.CompSetID=c.CompSetID AND Status='Damaged'";
            }
            else if (cboLocation.Text == "Select" && cboParts.Text != "Select") 
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                   " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                   " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                   " AND i.CompSetID=c.CompSetID AND Status='Damaged' AND Parts Like '%" + cboParts.Text + "%'";
            }
            else if (cboLocation.Text != "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                   " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                   " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                   " AND i.CompSetID=c.CompSetID AND Status='Damaged' AND Location Like '%" + cboLocation.Text + "%'";
            }
            else
            {
                sql = "SELECT ItemID, `Barcode`,`Parts`,`Brand`, i.`Description`,`Location`, `ComputerSet`,Status,RecievedDate " +
                        " FROM `tblbrand` b,`tblitems` i, `tblparts` p, `tbllocation` l,tblcompset c " +
                        " WHERE b.`BrandID`=i.`BrandID` AND i.`PartsID`=p.`PartsID` AND i.`LocationID`=l.`LocationID` " +
                        " AND i.CompSetID=c.CompSetID AND Status='Damaged' AND Location Like '%" + cboLocation.Text + "%' AND Parts Like '%" + cboParts.Text + "%'";
             } 
            reports(sql, "damageitems");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (cboLocation.Text == "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT * FROM `tbltransfer` ";
            }
            else if (cboLocation.Text == "Select" && cboParts.Text != "Select")
            {
                sql = "SELECT * FROM `tbltransfer` WHERE Parts Like '%" + cboParts.Text + "%'";
            }
            else if (cboLocation.Text != "Select" && cboParts.Text == "Select")
            {
                sql = "SELECT * FROM `tbltransfer` WHERE LocationTO Like '%" + cboLocation.Text + "%'";
            }
            else  
            {
                sql = "SELECT * FROM `tbltransfer` WHERE LocationTO Like '%" + cboLocation.Text + "%' AND Parts Like '%" + cboParts.Text + "%'";
            } 
            reports(sql, "transfereditems");
        }
    }
}
