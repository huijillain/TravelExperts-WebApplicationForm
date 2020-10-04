using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class ManagePackagesListing : Form
    {
        private readonly TravelExpertsEntities _db;
        public ManagePackagesListing()
        {
            InitializeComponent();
            _db = new TravelExpertsEntities();
        }

        private void ManagePackagesListing_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Function to PopulateGrid. Can be called anytime we need a grid refresh   
        public void PopulateGrid()
        {

            //Select Package as PkgName from Package Table
            var packages = _db.Packages.Select(p => new
            {
                Package = p.PkgName,
                p.PackageId           //can also use PackageId = p.PackageId
            })
                .ToList();

            gvPackageList.DataSource = packages;
            gvPackageList.Columns["PackageId"].Visible = false; // or use [1] instaed of "PackageId" 
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            var addEditPackage = new AddEditPackage(this);
            addEditPackage.MdiParent = this.MdiParent;
            addEditPackage.Show();
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            try
            {
                //which row is selected          
                var id = Convert.ToString(gvPackageList.CurrentRow.Cells[0].Value);
              //var id = (int)gvPackageList.CurrentRow.Cells[0].Value; //it is the same

                //query database for record                
                var package = _db.Packages.FirstOrDefault(p => p.PkgName == id);

                //launch AddEditProduct window with Data
                var addEditPackage = new AddEditPackage(package, this);
                addEditPackage.MdiParent = this.MdiParent;
                addEditPackage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            try
            {
                //select row
                var id = Convert.ToString(gvPackageList.CurrentRow.Cells[0].Value);

                //query database for record
                var package = _db.Packages.FirstOrDefault(p => p.PkgName == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Package?",
                        "Delete", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    //delete Product from table
                    _db.Packages.Remove(package);
                    _db.SaveChanges();
                }
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            //gvPackageList.Refresh();
        }
    }
}
