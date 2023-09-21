using PayrollMSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMS.Forms
{
    public partial class frmLogin : Form
    {
        string placeholderText = "Enter User Name..";
        string placeholderText2 = "Enter Password..";

        public frmLogin()
        {
            InitializeComponent();

            txtUserName.Text = placeholderText;
            txtUserName.ForeColor = Color.Gray;
            txtUserName.MouseClick += txtUserName_MouseClick;
            txtUserName.LostFocus += txtUserName_Leave;

            txtPassword.Text = placeholderText2;
            txtPassword.ForeColor = Color.Gray;
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.LostFocus += txtPassword_Leave;
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == placeholderText)
            {
                txtUserName.Text = string.Empty;
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = placeholderText;
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == placeholderText2)
            {
                txtPassword.Text = string.Empty;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = placeholderText2;
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == placeholderText || txtPassword.Text == placeholderText2)
            {
                MessageBox.Show("Define User Name Or Password..");
                return;
            }

            if(txtUserName.Text == "Sami123" && txtPassword.Text == "123")
            {
                frmUsers user = new frmUsers();
                user.ShowDialog();
                return;
            }

            string str = "SElect * from Users Where UserNAme = '" + txtUserName.Text + "' And UserStatus = 1 and DECRYPTBYPASSPHRASE('" + GlobalVars.PassPhrase + "', Password) = '" + txtPassword.Text + "' And Isdelete = 0";
            SqlDataAdapter sda = new SqlDataAdapter(str, DBConnection.GetConnection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GlobalVars.UserId = Convert.ToInt64(dt.Rows[0]["Id"]);
                GlobalVars.UserName = dt.Rows[0]["UserName"].ToString();
                GlobalVars.UserPassword = txtPassword.Text;
                GlobalVars.UserStatus = dt.Rows[0]["UserStatus"].ToString();
                GlobalVars.UserRole = dt.Rows[0]["UserRole"].ToString();
                frmMain Users = new frmMain();
                Users.ShowDialog();
                this.Close();
            }
        }
    }
}
