using PayrollMSLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PayrollMS
{
    public partial class frmCompanySetup : Form
    {
        DataTable dt = new DataTable();
        byte[] imageData;
        byte[] imageData2;
        public frmCompanySetup()
        {
            InitializeComponent();
        }

        private void companySetupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dt = GlobalCls.RetrieveData("SElect * from CompanySetup Where CompanyName = '" + txtCompName.Text + "'");
            if(dt.Rows.Count > 0)
            {
                Alerts.Message("This Company Already Exists With This Company Name " + txtCompName.Text, "Failed");
                return;
            }

            imageData = GlobalCls.ConvertImageToBinary(compLogoPictureBox);
            imageData2 = GlobalCls.ConvertImageToBinary(compLogoLandscapePictureBox);

            string str = "insert into CompanySetup (CompanyName,CompanyShortName,CompanyAddress,CompanyAddress2,CompanyAddress3,WebsiteUrl,PTCL " +
                         ",CompLogo,CompLogoLandscape,createdby,Isdelete,CompLogoPath,CompLanscapePath,CreatedOn) Values " +
                         "('" + txtCompName.Text + "','" + txtCompShort.Text + "','" + txtAddress.Text + "','" + txtAddress2.Text + "','" + txtAddress3.Text +
                         "','" + txtWebsiteUrl.Text + "','" + txtPtcl.Text + "','" + imageData + "', '" + imageData2 + "','" + GlobalCls.GetSystemUser() + "' " +
                         ",0,'" + txtCompLogoPath.Text + "','" + txtCompLandscapePath.Text + "'," + GlobalVars.UserId + ")";
            GlobalCls.ExecuteCommand(str);
            Alerts.Message("Company Details Saved..", "Completed");
        }

        private void frmCompanySetup_Load(object sender, EventArgs e)
        {
            this.companySetupTableAdapter.Fill(this.dSCompanySetup.CompanySetup);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (rbUploadLogo.Checked == true)
            {
                GlobalCls.BrowseImage(compLogoPictureBox, txtCompLogoPath);
            }
            else if (rbUL.Checked == true) 
            {
                GlobalCls.BrowseImage(compLogoLandscapePictureBox, txtCompLandscapePath);
            }
            else
            {
                Alerts.Message("Select atleast one option to upload an image", "");
            }
        }

        private void DisplayRecord()
        {
            if (idTextBox.Text != "")
            {
                string sQry = "Select * from CompanySetup Where IsDelete = 0 And Id = " + idTextBox.Text;
                dt = GlobalCls.RetrieveData(sQry);
                if (dt.Rows.Count > 0)
                {
                    txtCompName.Text = dt.Rows[0]["CompanyName"].ToString();
                    txtCompShort.Text = dt.Rows[0]["CompanyShortName"].ToString();
                    txtAddress.Text = dt.Rows[0]["CompanyAddress"].ToString();
                    txtAddress2.Text = dt.Rows[0]["CompanyAddress2"].ToString();
                    txtAddress3.Text = dt.Rows[0]["CompanyAddress3"].ToString();
                    txtWebsiteUrl.Text = dt.Rows[0]["WebsiteUrl"].ToString();
                    txtPtcl.Text = dt.Rows[0]["ptcl"].ToString();
                    txtCompLogoPath.Text = dt.Rows[0]["CompLogoPath"].ToString();
                    txtCompLandscapePath.Text = dt.Rows[0]["CompLanscapePath"].ToString();

                    string sCompLogoPath = Convert.ToString(dt.Rows[0]["CompLogoPath"]);
                    if (sCompLogoPath != "")
                    {
                        try
                        {
                            compLogoPictureBox.Image = Image.FromFile(sCompLogoPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Image Not Found On This Path : {ex.Message}", "Error loading the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    string sCompLogoLandscapePath = Convert.ToString(dt.Rows[0]["CompLanscapePath"]);
                    if (sCompLogoLandscapePath != "")
                    {
                        try
                        {
                            compLogoLandscapePictureBox.Image = Image.FromFile(sCompLogoLandscapePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Image Not Found On This Path : {ex.Message}", "Error loading the image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void companySetupBindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.companySetupTableAdapter.Fill(this.dSCompanySetup.CompanySetup);
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        private void companySetupBindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text == "")
            {
                Alerts.Message("Please Refresh Or Move Record..", "");
                return;
            }

            imageData = GlobalCls.ConvertImageToBinary(compLogoPictureBox);
            imageData2 = GlobalCls.ConvertImageToBinary(compLogoLandscapePictureBox);

            string str = "Update CompanySetup set CompanyName = '" + txtCompName.Text + "',CompanyShortName = '" + txtCompShort.Text + "' " +
                         ",CompanyAddress = '" + txtAddress.Text + "',CompanyAddress2 = '" + txtAddress2.Text + "',CompanyAddress3 = '" + txtAddress3.Text + "' " +
                         ",WebsiteUrl = '" + txtWebsiteUrl.Text + "',PTCL = '" + txtPtcl.Text + "',CompLogo = '" + imageData + "',CompLogoLandscape = '" + imageData2 + "' " +
                         ",UpdatedBy = '" + GlobalCls.GetSystemUser() + "',CompLogoPath = '" + txtCompLogoPath.Text + "',CompLanscapePath = '" + txtCompLandscapePath.Text + "' " +
                         ",UpdatedOn = " + GlobalVars.UserId + " Where Id = " + int.Parse(idTextBox.Text);
            GlobalCls.ExecuteCommand(str);
            Alerts.Message("Company Details Updated..", "Completed");
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string str = "Update CompanySetup set IsDelete = 1 Where Id = " + int.Parse(idTextBox.Text);
            GlobalCls.ExecuteCommand(str);
            Alerts.Message("Company Details Deleted..", "Completed");
        }
    }
}
