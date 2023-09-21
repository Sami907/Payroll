using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMSLibrary
{
    public class Alerts
    {
        public static void Message(string sMsg,string sMsgTitle)
        {
            MessageBox.Show(sMsg, sMsgTitle);
        }
    }
}
