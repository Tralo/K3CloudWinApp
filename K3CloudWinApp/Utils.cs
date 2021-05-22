using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3CloudWinApp
{
    class Utils
    {
        public static Boolean isEmpty(string str)
        {
            return str == null || str.Length == 0;
        }

        public static void showTip(string txt)
        {
            MessageBox.Show(txt);
        }

        public static Boolean checkIdOrNumber(string id, string number)
        {
            return !isEmpty(id) ? true : !isEmpty(number);
        }
    }
}
