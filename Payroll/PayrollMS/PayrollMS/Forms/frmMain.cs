using PayrollMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMS.Forms
{
    public partial class frmMain : Form
    {
        MenuStrip ms = new MenuStrip();
        public frmMain()
        {
            InitializeComponent();
        }

        private void AssignModulesToUser()
        {
            ToolStripMenuItem e = new ToolStripMenuItem();
            DataTable dt = GlobalCls.RetrieveData("select u.Id as UserId, u.UserName,pf.FormName,pf.FormTitle,pf.MenuItem from Users u " +
                                                  "Inner Join UserRights ur on ur.UserId = u.Id " +
                                                  "Inner Join ProjectForms pf on pf.Id = ur.FormId " +
                                                  "where u.Id = " + GlobalVars.UserId + " And ur.AllowShowForm = 1 ");
            if(dt.Rows.Count > 0)
            {
                for(int i=0;i< dt.Rows.Count;i++)
                {
                    string MenuItemName = dt.Rows[i]["MenuItem"].ToString();
                    if(MenuItemName != "")
                    {
                        e = new ToolStripMenuItem();
                        e.Name = "itm" + MenuItemName;
                        e.Text = MenuItemName;
                        menuStrip1.Items.Add(e);

                        DataRow[] filteredRows = dt.Select("MenuItem = '" + MenuItemName + "'");
                        foreach (DataRow row in filteredRows)
                        {
                            ToolStripMenuItem s = new ToolStripMenuItem();
                            s.Name = "itm" + dt.Rows[i]["FormTitle"].ToString();
                            s.Text = dt.Rows[i]["FormTitle"].ToString();
                            e.DropDownItems.Add(s);
                        }
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            AssignModulesToUser();
        }

        private void ewqrwqToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
