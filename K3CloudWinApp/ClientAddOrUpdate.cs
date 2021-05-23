using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3CloudWinApp
{
    public partial class ClientAddOrUpdate : Form
    {
        public ClientAddOrUpdate()
        {
            InitializeComponent();
        }

        private void btn_addUpdate_Click(object sender, EventArgs e)
        {
            string str ="{" + 
                    "'NeedUpDateFields': []," + 
                    " 'NeedReturnFields': []," + 
                    "'IsDeleteEntry': 'true'," + 
                    " 'SubSystemId': ''," + 
                    "'IsVerifyBaseDataField': 'false'," + 
                    "'IsEntryBatchFill': 'true'," + 
                    "'ValidateFlag': 'true'," +
                    "'NumberSearch': 'true'," + 
                    "'InterationFlags': ''," +
                    "'Model': {" + 
                    "'FCUSTID': 0," +
                    "'FCreateOrgId': {" +
                    "'FNumber': '103'" +     //销售公司
                    "}," +
                    " 'FNumber': ''," +
                    " 'FUseOrgId': {" +
                        "'FNumber': '103'" +   //销售公司
                    "}," + 
                    " 'FName': 'Demo测试'," + 
                    " 'FTRADINGCURRID': {" +   //币别
                    " 'FNumber': 'PRE001'" +
                    " }}}";
            string reslut = Global.client.Save(Global.db_table, str);
            tb_show.Text = "";
            tb_show.Text = str;

    
        }
    }
}
