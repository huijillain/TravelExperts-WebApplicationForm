using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    public partial class AddEditPackages : Form
    {
        private readonly TravelExpertsEntities _db; //This was added to connect db after creating TravelExpertsDB ADO.NET Entity Data Model
        private ManagePackageListing _managePackageListing;
        private bool isEditMode;

        public AddEditPackage(ManagePackageListing managePackageListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add New Package";
            this.Text = "Add New Package";
            isEditMode = false;
            _managePackageListing = managePackageListing;
            _db = new TravelExpertsEntities();
        }
        public AddEditPackage(Product packageToEdit, ManagePackageListing managePackageListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Packages";
            this.Text = "Edit Packages";
            _managePackageListing = managePackageListing;

            if (packageToEdit == null)
            {
                MessageBox.Show("Please ensure you selected a valid Package to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new TravelExpertsEntities();
                PopulateFields(packageToEdit);
            }

        }

        private void PopulateFields(Product productToEdit)
        {
            lblPackageId.Text = packageToEdit.PackageId.ToString();
            txtPackage.Text = packageToEdit.PkgName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string package = txtPackage.Text;

                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(package))
                {
                    isValid = false;
                    errorMessage += "Error: Please Enter a Package Name";
                }

                if (isValid)
                {
                    //Declare an object of the product to be added
                    var packagelisting = new Package();

                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblPackageId.Text);
                        packagelisting = _db.Packages.FirstOrDefault(p => p.PackageId == id);

                    }
                    //Populate record object with values from the form 
                    packagelisting.PkgName = package;

                    //If not in edit mode, then add the record object to the database
                    if (!isEditMode)
                        _db.Packages.Add(packagelisting);

                    //Save Changes made to the entity
                    _db.SaveChanges();
                    _managePackageListing.PopulateGrid();

                    MessageBox.Show($"Package Name :{package} has been added");

                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
