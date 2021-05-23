using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingdee.BOS.WebApi.Client;

namespace K3CloudWinApp
{
    class Global
    {
        public static string url = "http://laptop-5kbel9pf/K3Cloud/";
        public static string dbid = "605010f9363c24";
        public static string user = "Tralo";
        public static string pwd = "123456";
        public static K3CloudApiClient client;
        public static Dictionary<int, string> map = new Dictionary<int, string>();
        public static int curType = 1; // 1: 客户， 2: 物料    3：供应商
        public static string db_table;
        public static int op = 1;  //1: 新增        2: 更新

    }
}
