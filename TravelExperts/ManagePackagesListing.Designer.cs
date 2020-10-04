namespace TravelExperts
{
    partial class ManagePackagesListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvPackageList = new System.Windows.Forms.DataGridView();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.lblAddPackage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackageList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPackageList
            // 
            this.gvPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPackageList.Location = new System.Drawing.Point(12, 70);
            this.gvPackageList.Name = "gvPackageList";
            this.gvPackageList.Size = new System.Drawing.Size(178, 266);
            this.gvPackageList.TabIndex = 0;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(237, 70);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(83, 23);
            this.btnAddPackage.TabIndex = 1;
            this.btnAddPackage.Text = "Add Package";
            this.btnAddPackage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.Location = new System.Drawing.Point(237, 183);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(75, 23);
            this.btnEditPackage.TabIndex = 2;
            this.btnEditPackage.Text = "Edit";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(237, 290);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePackage.TabIndex = 3;
            this.btnDeletePackage.Text = "Delete";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.btnDeletePackage_Click);
            // 
            // lblAddPackage
            // 
            this.lblAddPackage.AutoSize = true;
            this.lblAddPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPackage.Location = new System.Drawing.Point(108, 22);
            this.lblAddPackage.Name = "lblAddPackage";
            this.lblAddPackage.Size = new System.Drawing.Size(141, 20);
            this.lblAddPackage.TabIndex = 4;
            this.lblAddPackage.Text = "Manage Packages";
            // 
            // ManagePackagesListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 347);
            this.Controls.Add(this.lblAddPackage);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.gvPackageList);
            this.Name = "ManagePackagesListing";
            this.Text = "Manage Package";
            this.Load += new System.EventHandler(this.ManagePackagesListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPackageList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPackageList;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Label lblAddPackage;
    }
}