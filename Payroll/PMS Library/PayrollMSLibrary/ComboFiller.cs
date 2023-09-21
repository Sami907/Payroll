using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMSLibrary
{
    public class ComboFiller
    {
        public static void FillUserRole(ComboBox combo)
        {
            DataTable dt = GlobalCls.RetrieveData("Select Id,Name from UserRole");
            combo.DisplayMember = "Name";
            combo.ValueMember = "Id";    
            combo.DataSource = dt;
        }

        public static void FillUserStatus(ComboBox combo)
        {
            DataTable dt = GlobalCls.RetrieveData("Select Id,Name from UserStatus");
            combo.DisplayMember = "Name";
            combo.ValueMember = "Id";
            combo.DataSource = dt;
        }

        public static void FillProjectForms(ComboBox combo)
        {
            DataTable dt = GlobalCls.RetrieveData("Select Id,FormTitle from ProjectForms");
            combo.DisplayMember = "FormTitle";
            combo.ValueMember = "Id";
            combo.DataSource = dt;
        }

        public static void FillUsers(ComboBox combo)
        {
            DataTable dt = GlobalCls.RetrieveData("Select Id,UserName from Users Where IsDelete = 0 And IsActive = 0");
            combo.DisplayMember = "UserName";
            combo.ValueMember = "Id";
            combo.DataSource = dt;
        }

        public static void FillMenuItems(ComboBox combo)
        {
            DataTable dt = GlobalCls.RetrieveData("Select Id,Name from MenuStripItems");
            combo.DisplayMember = "Name";
            combo.ValueMember = "Id";
            combo.DataSource = dt;
        }
    }
}
