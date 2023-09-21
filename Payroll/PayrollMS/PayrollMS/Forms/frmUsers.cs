using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollMS.DataSets;
using PayrollMS.DataSets.DSUserLoginTableAdapters;
using PayrollMS.Forms;
using PayrollMSLibrary;

namespace PayrollMS
{
    public partial class frmUsers : Form
    {
        int iAllowSave;
        int iAllowUpdate;
        int iAllowDelete;
        int iAllowRefresh;
        int iAllowShowForm;
        int iAllowFirst;
        int iAllowNext;
        int iAllowPrevious;
        int iAllowLast;
        public frmUsers()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.dSUserLogin.Users);
            ComboFiller.FillUserStatus(cbUserStatus);
            ComboFiller.FillUserRole(cbUserRole);
            GlobalCls.MaximizeForm(this);
            LoadForms();
        }

        private void DisplayData(long UserId = 0)
        {
            string sWhere = "";
            if(UserId > 0)
            {
                sWhere = " And Id = " + UserId + "";
            }
            DataTable Maindt = GlobalCls.RetrieveData("Select *,convert(varchar(max),DeCRYPTBYPASSPHRASE('" + GlobalVars.PassPhrase + "',Password)) DecryptedPassword from " +
                                                      "Users Where IsDelete = 0 " + sWhere + "");
            if (Maindt.Rows.Count <= 0)
            {
                Alerts.Message("No Record Found..", "");
                return;
            }
            
            txtId.Text = Maindt.Rows[0]["Id"].ToString();
            txtPassword.Text = Maindt.Rows[0]["DecryptedPassword"].ToString();
            txtUserName.Text = Maindt.Rows[0]["UserName"].ToString();
            cbUserRole.SelectedValue = Maindt.Rows[0]["UserRole"].ToString();
            cbUserStatus.SelectedValue = Maindt.Rows[0]["UserStatus"].ToString();
            DisplayDetail(Convert.ToInt64(txtId.Text));
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUserName.Text == "")
            {
                Alerts.Message("Required UserName Or Password", "");
                return;
            }

            DataTable dt = GlobalCls.RetrieveData("Select * from Users Where UserName = '" + txtUserName.Text + "' and DeCRYPTBYPASSPHRASE('" + GlobalVars.PassPhrase + "',Password) = '" + txtPassword.Text + "'");
            if (dt.Rows.Count > 0)
            {
                Alerts.Message("User Already Exists With This Credentials..", "");
                return;
            }

            string str = "Insert Into Users (UserName,Password,UserStatus,UserRole,CreatedBy,IsDelete,CreatedOn) values ('" + txtUserName.Text
                + "',(SElect ENCRYPTBYPASSPHRASE('" + GlobalVars.PassPhrase + "','" + txtPassword.Text + "'))," + cbUserStatus.SelectedValue + "," + cbUserRole.SelectedValue
                + ",'" + GlobalCls.GetSystemUser() + "',0," + GlobalVars.UserId + ")";
            GlobalCls.ExecuteCommand(str);
            SaveDetail();
            Alerts.Message("New User Added Successfull", "");

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            cbUserRole.Text = "";
            cbUserStatus.Text = "";
            txtId.Text = "";
            GlobalCls.ClearGridRows(dgvList);
            LoadForms();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                GlobalCls.ExecuteCommand("Update Users Set IsDelete = 1 Where Id = " + txtId.Text);
                Alerts.Message("User Delete Successfull..", "");
            }
        }

        private void usersBindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.dSUserLogin.Users);
            DisplayData();
        }

        private void usersBindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                Alerts.Message("Not Updated Refresh Record..", "");
                return;
            }

            string str = "Update Users set UserName = '" + txtUserName.Text + "',Password = (Select ENCRYPTBYPASSPHRASE('" + GlobalVars.PassPhrase + "','" + txtPassword.Text + "') EncryptedPassword) " +
                         ",UserStatus = " + cbUserStatus.SelectedValue + "" +
                         ",UserRole = " + cbUserRole.SelectedValue + ",UpdatedBy = '" + GlobalCls.GetSystemUser() + "',UpdatedOn = " + GlobalVars.UserId + " Where Id = " + txtId.Text;
            GlobalCls.ExecuteCommand(str);
            GlobalCls.ExecuteCommand("Delete from UserRights Where UserId = " + Convert.ToInt64(txtId.Text));
            SaveDetail(Convert.ToInt64(txtId.Text));
            Alerts.Message("User Updated Successfull", "");
        }

        private void DisplayDetail(long UserId)
        {
                for (int i = 0; i < dgvList.Rows.Count; i++)
                {
                    long lFormId = Convert.ToInt64(dgvList.Rows[i].Cells[dgvFormId.Name].Value);

                    string Qry = "select usr.UserName,pf.FormTitle,ur.AllowSave,ur.AllowUpdate,ur.AllowDelete,ur.AllowRefresh,ur.AllowFirst,ur.AllowNext," +
                                 "ur.AllowLast,ur.AllowPrevious from Users usr " +
                                 "Inner join UserRights ur on usr.Id = ur.UserId " +
                                 "Inner Join ProjectForms pf on pf.Id = ur.FormId " +
                                 "Where usr.IsDelete = 0 and ur.UserId = " + UserId + " And FormId = " + lFormId;
                    DataTable dt = GlobalCls.RetrieveData(Qry);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        iAllowSave = int.Parse(dr["AllowSave"].ToString());
                        if (iAllowSave == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowSave.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowSave.Name].Value = false;
                        }

                        iAllowUpdate = int.Parse(dr["AllowUpdate"].ToString());
                        if (iAllowUpdate == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowUpdate.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowUpdate.Name].Value = false;
                        }

                        iAllowDelete = int.Parse(dr["AllowDelete"].ToString());
                        if (iAllowDelete == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowDelete.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowDelete.Name].Value = false;
                        }

                        iAllowRefresh = int.Parse(dr["AllowRefresh"].ToString());
                        if (iAllowRefresh == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowRefresh.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowRefresh.Name].Value = false;
                        }

                        iAllowFirst = int.Parse(dr["AllowFirst"].ToString());
                        if (iAllowFirst == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowFirst.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowFirst.Name].Value = false;
                        }

                        iAllowNext = int.Parse(dr["AllowNext"].ToString());
                        if (iAllowNext == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowNext.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowNext.Name].Value = false;
                        }

                        iAllowPrevious = int.Parse(dr["AllowPrevious"].ToString());
                        if (iAllowPrevious == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowPrevious.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowPrevious.Name].Value = false;
                        }

                        iAllowLast = int.Parse(dr["AllowLast"].ToString());
                        if (iAllowLast == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowLast.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowLast.Name].Value = false;
                        }
                    }                    
                }
                else
                {
                    dgvList.Rows[i].Cells[dgvAllowSave.Name].Value = false;
                    dgvList.Rows[i].Cells[dgvAllowUpdate.Name].Value = false;
                    dgvList.Rows[i].Cells[dgvAllowDelete.Name].Value = false;
                    dgvList.Rows[i].Cells[dgvAllowRefresh.Name].Value = false;
                    dgvList.Rows[i].Cells[dgvAllowFirst.Name].Value = false;
                    dgvList.Rows[i].Cells[dgvAllowNext.Name].Value = false;
                    dgvList.Rows[i].Cells[dgvAllowLast.Name].Value = false;
                    dgvList.Rows[i].Cells[dgvAllowPrevious.Name].Value = false;
                }
            }
            GlobalCls.MakeSerial(dgvList, "dgvSno");
        }

        private void LoadForms()
        {

            DataTable dt = GlobalCls.RetrieveData("Select Id,FormTitle from ProjectForms");
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    int i = dgvList.Rows.Add();
                    dgvList.Rows[i].Cells[dgvForms.Name].Value = dr["FormTitle"].ToString();
                    dgvList.Rows[i].Cells[dgvFormId.Name].Value = dr["Id"].ToString();
                }
            }
            GlobalCls.MakeSerial(dgvList, "dgvSno");
        }

        private void SaveDetail(long UserId = 0)
        {
            dgvList.RefreshEdit();
            if(UserId <= 0)
            {
                UserId = GlobalCls.GetMax("Users", "Id");
            }


            for (int i = 0; i < dgvList.Rows.Count; i++)  
            {
                bool bAllowSave = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowSave.Name].Value);
                if (bAllowSave == true)
                {
                    iAllowSave = 1;
                }
                else
                {
                    iAllowSave = 0;
                }

                bool bAllowUpdate = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowUpdate.Name].Value);
                if (bAllowUpdate == true)
                {
                    iAllowUpdate = 1;
                }
                else
                {
                    iAllowUpdate = 0;
                }

                bool bAllowDelete = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowDelete.Name].Value);
                if (bAllowDelete == true)
                {
                    iAllowDelete = 1;
                }
                else
                {
                    iAllowDelete = 0;
                }

                bool bAllowRefresh = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowRefresh.Name].Value);
                if (bAllowRefresh == true)
                {
                    iAllowRefresh = 1;
                }
                else
                {
                    iAllowRefresh = 0;
                }

                bool bAllowShowForm = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowShowForm.Name].Value);
                if (bAllowShowForm == true)
                {
                    iAllowShowForm = 1;
                }
                else
                {
                    iAllowShowForm = 0;
                }

                bool bAllowFirst = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowFirst.Name].Value);
                if (bAllowFirst == true)
                {
                    iAllowFirst = 1;
                }
                else
                {
                    iAllowFirst = 0;
                }

                bool bAllowNext = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowNext.Name].Value);
                if (bAllowNext == true)
                {
                    iAllowNext = 1;
                }
                else
                {
                    iAllowNext = 0;
                }

                bool bAllowPrevious = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowPrevious.Name].Value);
                if (bAllowPrevious == true)
                {
                    iAllowPrevious = 1;
                }
                else
                {
                    iAllowPrevious = 0;
                }

                bool bAllowLast = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowLast.Name].Value);
                if (bAllowLast == true)
                {
                    iAllowLast = 1;
                }
                else
                {
                    iAllowLast = 0;
                }

                long lFormId = Convert.ToInt64(dgvList.Rows[i].Cells[dgvFormId.Name].Value);

                string str = "insert into UserRights (UserId,FormId,AllowSave,AllowUpdate,AllowDelete,AllowRefresh,AllowFirst,AllowLast,AllowNext,AllowPrevious,CreatedBy,AllowShowForm) " +
                    "values (" + UserId + "," + lFormId + "," + iAllowSave + "," + iAllowUpdate + "," + iAllowDelete + "," + iAllowRefresh
                    + "," + iAllowFirst + "," + iAllowLast + "," + iAllowNext + "," + iAllowPrevious + ",'" + GlobalCls.GetSystemUser() + "', " + iAllowShowForm + ")";
                GlobalCls.ExecuteCommand(str);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //var v = this.usersTableAdapter.GetData().Where(x => x.Id == Convert.ToInt64(txtId.Text)).Select(s => s.Id);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            
        }

        private void usersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DisplayData(Convert.ToInt64(txtId.Text));
            }
        }

        private void UpdateDetail(long UserId) //This Method Not Use We Use It In Case We Need..
        {
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                bool bAllowSave = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowSave.Name].Value);
                if (bAllowSave == true)
                {
                    iAllowSave = 1;
                }
                else
                {
                    iAllowSave = 0;
                }

                bool bAllowUpdate = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowUpdate.Name].Value);
                if (bAllowUpdate == true)
                {
                    iAllowUpdate = 1;
                }
                else
                {
                    iAllowUpdate = 0;
                }

                bool bAllowDelete = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowDelete.Name].Value);
                if (bAllowDelete == true)
                {
                    iAllowDelete = 1;
                }
                else
                {
                    iAllowDelete = 0;
                }

                bool bAllowRefresh = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowRefresh.Name].Value);
                if (bAllowRefresh == true)
                {
                    iAllowRefresh = 1;
                }
                else
                {
                    iAllowRefresh = 0;
                }

                bool bAllowShowForm = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowShowForm.Name].Value);
                if (bAllowShowForm == true)
                {
                    iAllowShowForm = 1;
                }
                else
                {
                    iAllowShowForm = 0;
                }

                bool bAllowFirst = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowFirst.Name].Value);
                if (bAllowFirst == true)
                {
                    iAllowFirst = 1;
                }
                else
                {
                    iAllowFirst = 0;
                }

                bool bAllowNext = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowNext.Name].Value);
                if (bAllowNext == true)
                {
                    iAllowNext = 1;
                }
                else
                {
                    iAllowNext = 0;
                }

                bool bAllowPrevious = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowPrevious.Name].Value);
                if (bAllowPrevious == true)
                {
                    iAllowPrevious = 1;
                }
                else
                {
                    iAllowPrevious = 0;
                }

                bool bAllowLast = Convert.ToBoolean(dgvList.Rows[i].Cells[dgvAllowLast.Name].Value);
                if (bAllowLast == true)
                {
                    iAllowLast = 1;
                }
                else
                {
                    iAllowLast = 0;
                }

                long lFormId = Convert.ToInt64(dgvList.Rows[i].Cells[dgvFormId.Name].Value);

                string str = "Update UserRights Set AllowSave = " + iAllowSave + ",AllowUpdate = " + iAllowUpdate + ",AllowDelete = " + iAllowDelete + ",AllowRefresh = " + iAllowRefresh + "" +
                             ",AllowFirst = " + iAllowFirst + ",AllowLast = " + iAllowLast + ",AllowNext = " + iAllowNext + ",AllowPrevious = " + iAllowPrevious + ",CreatedBy = " + GlobalCls.GetSystemUser() +
                             " Where UserID = " + UserId + " And FormId = " + lFormId + ")";
                GlobalCls.ExecuteCommand(str);
            }
        }
    }
}
