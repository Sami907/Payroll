using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMSLibrary
{
    public class GlobalCls
    {
        static SqlConnection cn = DBConnection.GetConnection();
        public static DataTable RetrieveData(string sQuery)
        {
            DataTable dataTable = new DataTable();  
            SqlDataAdapter sda = new SqlDataAdapter(sQuery, DBConnection.GetConnection());
            sda.Fill(dataTable);
            return dataTable;
        }

        public static void ClearGridRows(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.Rows.Clear();
            }
        }

        public static void ExecuteCommand(string sCommand)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand(sCommand, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public static string GetSystemUser()
        {
            DataTable dt = RetrieveData("Select left(GetDate(),12) + ' ' + right(GETDATE(),6) + ' ' + SYSTEM_USER SystemUser");
            return dt.Rows[0]["SystemUser"].ToString();
        }

        public static string ConvertPasswordToDecrypt(string TableName, long UniqueId,string UniqueIdColumn,string PasswordColumn)
        {
            DataTable dt = RetrieveData("Select DeCRYPTBYPASSPHRASE('"+GlobalVars.PassPhrase+"',"+PasswordColumn+") DecryptedPassword from " + TableName + " where " + UniqueIdColumn + " = " + UniqueId);
            return dt.Rows[0]["DecryptedPassword"].ToString();
        }

        public static void MakeSerial(DataGridView gridView,string GridSerialColumnName)
        {
            int i = 1;
            foreach (DataGridViewRow row in gridView.Rows)
            {
                row.Cells[GridSerialColumnName].Value = i; i++;
            }
        }

        public static void MaximizeForm(Form frm)
        {
            frm.WindowState = FormWindowState.Maximized;
        }

        public static long GetMax(string TableName,string ColumnName)
        {
            DataTable dt = RetrieveData("Select Max(" + ColumnName + ") MaxValue From " + TableName + "");
            return Convert.ToInt64(dt.Rows[0]["MaxValue"]);
        }

        public static long GetMin(string TableName, string ColumnName)
        {
            DataTable dt = RetrieveData("Select Min(" + ColumnName + ") MinValue From " + TableName + "");
            return Convert.ToInt64(dt.Rows[0]["MinValue"]);
        }

        public static void BrowseImage(PictureBox pic)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                    pic.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static byte[] ConvertImageToBinary(PictureBox pic)
        {
            Image image = pic.Image;
            byte[] imageData = null;

            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
            }

            return imageData;
        }

        public static void BrowseImage(PictureBox pic,TextBox txtPath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                    pic.Image = Image.FromFile(imagePath);
                    txtPath.Text = imagePath.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
