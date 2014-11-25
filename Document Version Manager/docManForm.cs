using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SharePoint;

namespace Document_Version_Manager
{
    public partial class docManForm : Form
    {
        SPSite site;
        SPWeb web;
        SPDocumentLibrary library;
        SPListItemCollection selectedItems;
        //SPListItemVersionWrapper version;

        public docManForm()
        {
            InitializeComponent();
        }

        //private void btnGetVersions_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        site = new SPSite(txtSiteUrl.Text);
        //        web = site.OpenWeb();
        //        library = web.Lists[txtLibrary.Text] as SPDocumentLibrary;
        //        if (library != null)
        //        {
        //            //MessageBox.Show("Library Found");
        //            foreach (SPListItem doc in library.Items)
        //            {
        //                foreach (SPListItemVersion version in doc.Versions)
        //                {
        //                    SPListItemVersionWrapper v = new SPListItemVersionWrapper(version);
        //                    ddlVersion.Items.Add(v);
        //                }
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error Occurred: " + ex.Message);
        //    }
        //}

        private void btnSetDate_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = "Working...";
                lblStatus.BackColor = Color.Transparent;
                //SPListItemVersionWrapper w = ddlVersion.SelectedItem as SPListItemVersionWrapper;
                //SPListItemVersion ver = w.Version;
                //SPListItem item = ver.ListItem;
                //ver["Modified"] = dateModified.Value;
                //item["Modified"] = dateModified.Value;
                //item.SystemUpdate();
                foreach (var item in lstDocuments.SelectedItems)
                {
                    SPListItem doc = ((SPFile)item).Item;

                    //Ensure Created Date is on or before Modified Date
                    // Case 1 - Created date being set, modified date not set
                    if (chkDateCreated.Checked && !chkDateModified.Checked)
                    {
                        // Ensure created date being set is lesser than or equal to modified date on doc
                        DateTime docModified = (DateTime) doc["Modified"];
                        if(docModified <= dateCreated.Value){
                            chkDateModified.Enabled = false;
                            dateModified.Enabled = false;
                            chkDateModified.Checked = true;
                            dateModified.Value = dateCreated.Value;
                            chkDateModified.Enabled = true;
                            dateModified.Enabled = true;
                            lblStatus.Text = "Dates Adjusted. ";
                        }
                    }
                    // Case 2 - Created date not set, modified date being set
                    else if (!chkDateCreated.Checked && chkDateModified.Checked)
                    {
                        // Ensure created date on doc is lesser than or equal to modified date being set
                        DateTime docCreated = (DateTime) doc["Created"];
                        if (docCreated >= dateModified.Value)
                        {
                            chkDateCreated.Enabled = false;
                            dateCreated.Enabled = false;
                            chkDateCreated.Checked = true;
                            dateCreated.Value = dateModified.Value;
                            chkDateCreated.Enabled = true;
                            dateCreated.Enabled = true;
                            lblStatus.Text = "Dates Adjusted. ";
                        }
                    }
                    // Case 3 - Created date set, modified date set
                    else if (chkDateCreated.Checked && chkDateModified.Checked)
                    {
                        // Ensure Created Date being set is less than Modified Date being set
                        if (dateCreated.Value >= dateModified.Value)
                        {
                            //MessageBox.Show("Created date less than modified date being set for \n" + doc.Title + "\n Dates adjusted");
                            lblStatus.Text = "Dates Adjusted. ";
                            dateCreated.Enabled = false;
                            dateCreated.Value = dateModified.Value;
                            dateCreated.Enabled = true;
                        }
                    }

                    Random secs = new Random();
                    int min = 32400;
                    if (chkDateCreated.Checked)
                    {
                        min = secs.Next(min, 64800);
                        doc["Created"] = dateCreated.Value.Date.AddSeconds(min);
                    }
                    if (chkCreatedBy.Checked)
                    {
                        //If txtCreatedBy field is empty, set created by and modified by as same value.  One of them should be available.
                        doc["Created By"] = txtCreatedBy.TextLength==0? web.AllUsers[txtModifiedBy.Text] : web.AllUsers[txtCreatedBy.Text];
                    }
                    if (chkDateModified.Checked) { 
                        doc["Modified"] = dateModified.Value.Date.AddSeconds(secs.Next(min, 86400));
                    }
                    if (chkModifiedBy.Checked)
                    {
                        //If txtModifiedBy field is empty, set created by and modified by as same value. One of them should be available.
                        doc["Modified By"] = txtModifiedBy.TextLength == 0 ? web.AllUsers[txtCreatedBy.Text] : web.AllUsers[txtModifiedBy.Text];
                    }
                    doc.Update();
                }
                lblStatus.Text += "Success";
                lblStatus.BackColor = Color.LightGreen;
                //Clear item selection in list if successfully updated 
                // - helps proceed to next set of documents faster
                lstDocuments.ClearSelected();
                //MessageBox is too obtrusive for fast operations - used Status label instead.
                //MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void docManForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (web != null)
            {
                web.Close();
                web.Dispose();
            }
            if (site != null)
            {
                site.Close();
                site.Dispose();
            }
        }

        //private void btnLoadFiles_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        site = new SPSite(txtSiteUrl.Text);
        //        web = site.OpenWeb();
        //        //library = web.Lists[txtLibrary.Text] as SPDocumentLibrary;
        //        if (library != null)
        //        {
        //            //MessageBox.Show("Library Found");
        //            foreach (SPListItem doc in library.Items)
        //            {
        //                foreach (SPListItemVersion version in doc.Versions)
        //                {
        //                    SPListItemVersionWrapper v = new SPListItemVersionWrapper(version);
        //                    ddlVersion.Items.Add(v);
        //                }
        //            }
        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error Occurred: " + ex.Message);
        //    }
        //}

        private void btnGetLibraries_Click(object sender, EventArgs e)
        {
            try
            {
                site = new SPSite(txtSiteUrl.Text);
                web = site.OpenWeb();
                SPListCollection docLibs = web.GetListsOfType(SPBaseType.DocumentLibrary);
                ddlLibraries.Items.Clear();
                foreach (SPList lib in docLibs)
                {
                    if (!lib.Hidden)
                    {
                        ddlLibraries.Items.Add(lib);
                    }
                }
                ddlLibraries.DisplayMember = "Title";
                ddlLibraries.ValueMember = "ID";
                ddlLibraries.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void ddlLibraries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                library = ddlLibraries.SelectedItem as SPDocumentLibrary;
                SPListItemCollection items = library.Items;
                //lstDocuments.DataSource = items;
                lstDocuments.Items.Clear();

                AddFolderItemsToList(library.RootFolder);

                //foreach (SPListItem doc in items)
                //{
                //    lstDocuments.Items.Add(doc);
                //}
                pnlDocuments.Enabled = true;
                ////Display Item Path in Checkbox list. 
                //clbDocuments.DisplayMember = "Url";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        private void AddFolderItemsToList(SPFolder folder)
        {
            if (folder.Name !="Forms")
            {
                foreach (SPFile file in folder.Files)
                {
                    lstDocuments.Items.Add(file);
                }
                foreach (SPFolder subfolder in folder.SubFolders)
                {
                    AddFolderItemsToList(subfolder);
                }
            }
        }

        private void lstDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlModifyDate.Enabled == false)
            {
                pnlModifyDate.Enabled = true;
            }
            lblItemCount.Text = lstDocuments.SelectedItems.Count.ToString();
        }

        private void lnlSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            int n = lstDocuments.Items.Count;
            //Disable event firing on listview
            lstDocuments.Enabled = false;
            if (chkSelectAll.Checked)
            {
                for (int i = 0; i < n; i++)
                {
                    lstDocuments.SetSelected(i, true);
                }
            }
            else
            {
                lstDocuments.ClearSelected();
            }
            lstDocuments.Enabled = true;
        }

        private void chkDateCreated_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateCreated.Checked)
            {
                dateCreated.Enabled = true;
            }
            else
            {
                dateCreated.Enabled = false;
                //When dateCreated is disabled, dateModified should have no min. restriction.
                //dateModified.MinDate = DateTimePicker.MinimumDateTime;
            }
        }

        private void chkDateModified_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateModified.Checked)
            {
                dateModified.Enabled = true;
            }
            else
            {
                dateModified.Enabled = false;
                //When dateModified is disabled, dateCreated should have no max. restriction.
                //dateCreated.MaxDate = DateTimePicker.MaximumDateTime;
            }
        }

        private void chkCreatedBy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreatedBy.Checked)
            {
                txtCreatedBy.Enabled = true;
            }
            else
            {
                txtCreatedBy.Enabled = false;
            }
        }

        private void chkModifiedBy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModifiedBy.Checked)
            {
                txtModifiedBy.Enabled = true;
            }
            else
            {
                txtModifiedBy.Enabled = false;
            }
        }

        private void dateCreated_ValueChanged(object sender, EventArgs e)
        {
            //dateModified.MinDate = dateCreated.Value;
        }

        private void dateModified_ValueChanged(object sender, EventArgs e)
        {
            //dateCreated.MaxDate = dateModified.Value;
        }
    }
}

//1. Provide Check All/Uncheck All buttons to select / unselect all items in CheckBoxList
//2. Show confirmation message on set  date button click
//3. Show number of items selected in a label as user selects items.