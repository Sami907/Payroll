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
using PayrollMSLibrary;

namespace PayrollMS
{
    public partial class frmUsers : Form
    {
        int iCurrentIndex = 0;
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

        private void DisplayData(int ind = 0)
        {
            this.usersTableAdapter.Fill(this.dSUserLogin.Users);
            DataTable dt = GlobalCls.RetrieveData("Select *,convert(varchar(max),DeCRYPTBYPASSPHRASE('" + GlobalVars.PassPhrase + "',Password)) DecryptedPassword from Users Where IsDelete = 0");
            if (dt.Rows.Count <= 0)
            {
                Alerts.Message("No Record Found..", "");
                return;
            }
            
            txtId.Text = dt.Rows[ind]["Id"].ToString();
            txtPassword.Text = dt.Rows[ind]["DecryptedPassword"].ToString();
            txtUserName.Text = dt.Rows[ind]["UserName"].ToString();
            cbUserRole.SelectedValue = dt.Rows[ind]["UserRole"].ToString();
            cbUserStatus.SelectedValue = dt.Rows[ind]["UserStatus"].ToString();
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

            string str = "Insert Into Users (UserName,Password,UserStatus,UserRole,CreatedBy,IsDelete) values ('" + txtUserName.Text
                + "',(SElect ENCRYPTBYPASSPHRASE('" + GlobalVars.PassPhrase + "','" + txtPassword.Text + "'))," + cbUserStatus.SelectedValue + "," + cbUserRole.SelectedValue
                + ",'" + GlobalCls.GetSystemUser() + "',0)";
            GlobalCls.ExecuteCommand(str);
            Alerts.Message("New User Added Successfull", "");

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            cbUserRole.Text = "";
            cbUserStatus.Text = "";
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
                         ",UserRole = " + cbUserRole.SelectedValue + ",UpdatedBy = '" + GlobalCls.GetSystemUser() + "' Where Id = " + txtId.Text;
            GlobalCls.ExecuteCommand(str);
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
                        int iAllowSave = int.Parse(dr["AllowSave"].ToString());
                        if (iAllowSave == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowSave.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowSave.Name].Value = false;
                        }

                        int iAllowUpdate = int.Parse(dr["AllowUpdate"].ToString());
                        if (iAllowUpdate == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowUpdate.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowUpdate.Name].Value = false;
                        }

                        int iAllowDelete = int.Parse(dr["AllowDelete"].ToString());
                        if (iAllowDelete == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowDelete.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowDelete.Name].Value = false;
                        }

                        int iAllowRefresh = int.Parse(dr["AllowRefresh"].ToString());
                        if (iAllowRefresh == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowRefresh.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowRefresh.Name].Value = false;
                        }

                        int iAllowFirst = int.Parse(dr["AllowFirst"].ToString());
                        if (iAllowFirst == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowFirst.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowFirst.Name].Value = false;
                        }

                        int iAllowNext = int.Parse(dr["AllowNext"].ToString());
                        if (iAllowNext == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowNext.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowNext.Name].Value = false;
                        }

                        int iAllowPrevious = int.Parse(dr["AllowPrevious"].ToString());
                        if (iAllowPrevious == 1)
                        {
                            dgvList.Rows[i].Cells[dgvAllowPrevious.Name].Value = true;
                        }
                        else
                        {
                            dgvList.Rows[i].Cells[dgvAllowPrevious.Name].Value = false;
                        }

                        int iAllowLast = int.Parse(dr["AllowLast"].ToString());
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

        private void SaveDetail()
        {
            int iAllowSave;
            int iAllowUpdate;
            int iAllowDelete;
            int iAllowRefresh;
            int iAllowFirst;
            int iAllowNext;
            int iAllowPrevious;
            int iAllowLast;

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

                string str = "insert into UserRights (UserId,FormId,AllowSave,AllowUpdate,AllowDelete,AllowRefresh,AllowFirst,AllowLast,AllowNext,AllowPrevious,CreatedBy) " +
                    "values (" + Convert.ToInt64(txtId.Text) + ")," + lFormId + ",";
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            iCurrentIndex = -1;
            iCurrentIndex += int.Parse(bindingNavigatorPositionItem.Text) ;
            DisplayData(iCurrentIndex - 1);
        }

        private void usersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            iCurrentIndex = -1;
            iCurrentIndex += int.Parse(bindingNavigatorPositionItem.Text) ;
            DisplayData(iCurrentIndex);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            iCurrentIndex = -1;
            iCurrentIndex += int.Parse(bindingNavigatorPositionItem.Text) -1;
            DisplayData(iCurrentIndex);
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            iCurrentIndex = int.Parse(bindingNavigatorPositionItem.Text);
            DisplayData(iCurrentIndex);
        }
    }
}
