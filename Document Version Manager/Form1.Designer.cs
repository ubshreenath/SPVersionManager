namespace Document_Version_Manager
{
    partial class docManForm
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
            this.txtSiteUrl = new System.Windows.Forms.TextBox();
            this.lblSiteUrl = new System.Windows.Forms.Label();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.btnGetLibraries = new System.Windows.Forms.Button();
            this.ddlLibraries = new System.Windows.Forms.ComboBox();
            this.lstDocuments = new System.Windows.Forms.ListBox();
            this.pnlModifyDate = new System.Windows.Forms.Panel();
            this.chkModifiedBy = new System.Windows.Forms.CheckBox();
            this.chkCreatedBy = new System.Windows.Forms.CheckBox();
            this.chkDateModified = new System.Windows.Forms.CheckBox();
            this.chkDateCreated = new System.Windows.Forms.CheckBox();
            this.lblModifiedBy = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.txtModifiedBy = new System.Windows.Forms.TextBox();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.dateModified = new System.Windows.Forms.DateTimePicker();
            this.pnlDocuments = new System.Windows.Forms.Panel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.pnlModifyDate.SuspendLayout();
            this.pnlDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSiteUrl
            // 
            this.txtSiteUrl.Location = new System.Drawing.Point(12, 29);
            this.txtSiteUrl.Name = "txtSiteUrl";
            this.txtSiteUrl.Size = new System.Drawing.Size(219, 20);
            this.txtSiteUrl.TabIndex = 0;
            // 
            // lblSiteUrl
            // 
            this.lblSiteUrl.AutoSize = true;
            this.lblSiteUrl.Location = new System.Drawing.Point(12, 13);
            this.lblSiteUrl.Name = "lblSiteUrl";
            this.lblSiteUrl.Size = new System.Drawing.Size(50, 13);
            this.lblSiteUrl.TabIndex = 1;
            this.lblSiteUrl.Text = "Site URL";
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.Location = new System.Drawing.Point(12, 52);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(38, 13);
            this.lblLibrary.TabIndex = 2;
            this.lblLibrary.Text = "Library";
            // 
            // dateCreated
            // 
            this.dateCreated.Enabled = false;
            this.dateCreated.Location = new System.Drawing.Point(92, 29);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(175, 20);
            this.dateCreated.TabIndex = 200;
            this.dateCreated.ValueChanged += new System.EventHandler(this.dateCreated_ValueChanged);
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(89, 13);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(70, 13);
            this.lblDateCreated.TabIndex = 6;
            this.lblDateCreated.Text = "Date Created";
            // 
            // btnSetDate
            // 
            this.btnSetDate.Location = new System.Drawing.Point(28, 154);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(233, 23);
            this.btnSetDate.TabIndex = 500;
            this.btnSetDate.Text = "&Set Properties";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // btnGetLibraries
            // 
            this.btnGetLibraries.Location = new System.Drawing.Point(237, 27);
            this.btnGetLibraries.Name = "btnGetLibraries";
            this.btnGetLibraries.Size = new System.Drawing.Size(35, 23);
            this.btnGetLibraries.TabIndex = 50;
            this.btnGetLibraries.Text = "Go";
            this.btnGetLibraries.UseVisualStyleBackColor = true;
            this.btnGetLibraries.Click += new System.EventHandler(this.btnGetLibraries_Click);
            // 
            // ddlLibraries
            // 
            this.ddlLibraries.Enabled = false;
            this.ddlLibraries.FormattingEnabled = true;
            this.ddlLibraries.Location = new System.Drawing.Point(12, 68);
            this.ddlLibraries.Name = "ddlLibraries";
            this.ddlLibraries.Size = new System.Drawing.Size(257, 21);
            this.ddlLibraries.TabIndex = 75;
            this.ddlLibraries.SelectedIndexChanged += new System.EventHandler(this.ddlLibraries_SelectedIndexChanged);
            // 
            // lstDocuments
            // 
            this.lstDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDocuments.DisplayMember = "Url";
            this.lstDocuments.FormattingEnabled = true;
            this.lstDocuments.HorizontalScrollbar = true;
            this.lstDocuments.Location = new System.Drawing.Point(0, 26);
            this.lstDocuments.Name = "lstDocuments";
            this.lstDocuments.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDocuments.Size = new System.Drawing.Size(486, 212);
            this.lstDocuments.Sorted = true;
            this.lstDocuments.TabIndex = 150;
            this.lstDocuments.SelectedIndexChanged += new System.EventHandler(this.lstDocuments_SelectedIndexChanged);
            // 
            // pnlModifyDate
            // 
            this.pnlModifyDate.Controls.Add(this.chkModifiedBy);
            this.pnlModifyDate.Controls.Add(this.chkCreatedBy);
            this.pnlModifyDate.Controls.Add(this.chkDateModified);
            this.pnlModifyDate.Controls.Add(this.chkDateCreated);
            this.pnlModifyDate.Controls.Add(this.lblModifiedBy);
            this.pnlModifyDate.Controls.Add(this.lblCreatedBy);
            this.pnlModifyDate.Controls.Add(this.txtModifiedBy);
            this.pnlModifyDate.Controls.Add(this.txtCreatedBy);
            this.pnlModifyDate.Controls.Add(this.lblDateModified);
            this.pnlModifyDate.Controls.Add(this.dateModified);
            this.pnlModifyDate.Controls.Add(this.dateCreated);
            this.pnlModifyDate.Controls.Add(this.lblDateCreated);
            this.pnlModifyDate.Controls.Add(this.btnSetDate);
            this.pnlModifyDate.Enabled = false;
            this.pnlModifyDate.Location = new System.Drawing.Point(209, 0);
            this.pnlModifyDate.Name = "pnlModifyDate";
            this.pnlModifyDate.Size = new System.Drawing.Size(292, 180);
            this.pnlModifyDate.TabIndex = 13;
            // 
            // chkModifiedBy
            // 
            this.chkModifiedBy.AutoSize = true;
            this.chkModifiedBy.Checked = true;
            this.chkModifiedBy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkModifiedBy.Location = new System.Drawing.Point(273, 131);
            this.chkModifiedBy.Name = "chkModifiedBy";
            this.chkModifiedBy.Size = new System.Drawing.Size(15, 14);
            this.chkModifiedBy.TabIndex = 504;
            this.chkModifiedBy.UseVisualStyleBackColor = true;
            this.chkModifiedBy.CheckedChanged += new System.EventHandler(this.chkModifiedBy_CheckedChanged);
            // 
            // chkCreatedBy
            // 
            this.chkCreatedBy.AutoSize = true;
            this.chkCreatedBy.Checked = true;
            this.chkCreatedBy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreatedBy.Location = new System.Drawing.Point(273, 70);
            this.chkCreatedBy.Name = "chkCreatedBy";
            this.chkCreatedBy.Size = new System.Drawing.Size(15, 14);
            this.chkCreatedBy.TabIndex = 503;
            this.chkCreatedBy.UseVisualStyleBackColor = true;
            this.chkCreatedBy.CheckedChanged += new System.EventHandler(this.chkCreatedBy_CheckedChanged);
            // 
            // chkDateModified
            // 
            this.chkDateModified.AutoSize = true;
            this.chkDateModified.Checked = true;
            this.chkDateModified.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateModified.Location = new System.Drawing.Point(273, 104);
            this.chkDateModified.Name = "chkDateModified";
            this.chkDateModified.Size = new System.Drawing.Size(15, 14);
            this.chkDateModified.TabIndex = 502;
            this.chkDateModified.UseVisualStyleBackColor = true;
            this.chkDateModified.CheckedChanged += new System.EventHandler(this.chkDateModified_CheckedChanged);
            // 
            // chkDateCreated
            // 
            this.chkDateCreated.AutoSize = true;
            this.chkDateCreated.Location = new System.Drawing.Point(273, 32);
            this.chkDateCreated.Name = "chkDateCreated";
            this.chkDateCreated.Size = new System.Drawing.Size(15, 14);
            this.chkDateCreated.TabIndex = 501;
            this.chkDateCreated.UseVisualStyleBackColor = true;
            this.chkDateCreated.CheckedChanged += new System.EventHandler(this.chkDateCreated_CheckedChanged);
            // 
            // lblModifiedBy
            // 
            this.lblModifiedBy.AutoSize = true;
            this.lblModifiedBy.Location = new System.Drawing.Point(25, 131);
            this.lblModifiedBy.Name = "lblModifiedBy";
            this.lblModifiedBy.Size = new System.Drawing.Size(62, 13);
            this.lblModifiedBy.TabIndex = 15;
            this.lblModifiedBy.Text = "Modified By";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(89, 52);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(59, 13);
            this.lblCreatedBy.TabIndex = 14;
            this.lblCreatedBy.Text = "Created By";
            // 
            // txtModifiedBy
            // 
            this.txtModifiedBy.Location = new System.Drawing.Point(92, 128);
            this.txtModifiedBy.Name = "txtModifiedBy";
            this.txtModifiedBy.Size = new System.Drawing.Size(175, 20);
            this.txtModifiedBy.TabIndex = 350;
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(92, 67);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(175, 20);
            this.txtCreatedBy.TabIndex = 300;
            // 
            // lblDateModified
            // 
            this.lblDateModified.AutoSize = true;
            this.lblDateModified.Location = new System.Drawing.Point(14, 104);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(73, 13);
            this.lblDateModified.TabIndex = 11;
            this.lblDateModified.Text = "Date Modified";
            // 
            // dateModified
            // 
            this.dateModified.Location = new System.Drawing.Point(92, 102);
            this.dateModified.Name = "dateModified";
            this.dateModified.Size = new System.Drawing.Size(175, 20);
            this.dateModified.TabIndex = 250;
            this.dateModified.ValueChanged += new System.EventHandler(this.dateModified_ValueChanged);
            // 
            // pnlDocuments
            // 
            this.pnlDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDocuments.Controls.Add(this.lblItemCount);
            this.pnlDocuments.Controls.Add(this.chkSelectAll);
            this.pnlDocuments.Controls.Add(this.lstDocuments);
            this.pnlDocuments.Enabled = false;
            this.pnlDocuments.Location = new System.Drawing.Point(12, 186);
            this.pnlDocuments.Name = "pnlDocuments";
            this.pnlDocuments.Size = new System.Drawing.Size(489, 257);
            this.pnlDocuments.TabIndex = 14;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(9, 3);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(123, 17);
            this.chkSelectAll.TabIndex = 100;
            this.chkSelectAll.TabStop = false;
            this.chkSelectAll.Text = "Select / Unselect All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(83, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 76;
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Location = new System.Drawing.Point(450, 7);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(0, 13);
            this.lblItemCount.TabIndex = 151;
            // 
            // docManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 455);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.ddlLibraries);
            this.Controls.Add(this.btnGetLibraries);
            this.Controls.Add(this.lblLibrary);
            this.Controls.Add(this.lblSiteUrl);
            this.Controls.Add(this.txtSiteUrl);
            this.Controls.Add(this.pnlDocuments);
            this.Controls.Add(this.pnlModifyDate);
            this.Name = "docManForm";
            this.Text = "Document Version Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.docManForm_FormClosing);
            this.pnlModifyDate.ResumeLayout(false);
            this.pnlModifyDate.PerformLayout();
            this.pnlDocuments.ResumeLayout(false);
            this.pnlDocuments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSiteUrl;
        private System.Windows.Forms.Label lblSiteUrl;
        private System.Windows.Forms.Label lblLibrary;
        private System.Windows.Forms.DateTimePicker dateCreated;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.Button btnGetLibraries;
        private System.Windows.Forms.ComboBox ddlLibraries;
        private System.Windows.Forms.ListBox lstDocuments;
        private System.Windows.Forms.Panel pnlModifyDate;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.DateTimePicker dateModified;
        private System.Windows.Forms.Panel pnlDocuments;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label lblModifiedBy;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.TextBox txtModifiedBy;
        private System.Windows.Forms.TextBox txtCreatedBy;
        private System.Windows.Forms.CheckBox chkModifiedBy;
        private System.Windows.Forms.CheckBox chkCreatedBy;
        private System.Windows.Forms.CheckBox chkDateModified;
        private System.Windows.Forms.CheckBox chkDateCreated;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblItemCount;
    }
}

