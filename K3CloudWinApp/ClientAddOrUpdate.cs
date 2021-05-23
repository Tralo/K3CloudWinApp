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
            string clientName = tb_clientname.Text;
            if (Utils.isEmpty(clientName))
            {
                Utils.showTip("名称不能为空");
                return;
            }
            string str ="{" + 
                    "'NeedUpDateFields': []," +
                    " 'NeedReturnFields': ['FCUSTID','FNUMBER']," + 
                    "'IsDeleteEntry': 'true'," + 
                    " 'SubSystemId': ''," + 
                    "'IsVerifyBaseDataField': 'false'," + 
                    "'IsEntryBatchFill': 'true'," + 
                    "'ValidateFlag': 'true'," +
                    "'NumberSearch': 'true'," + 
                    "'InterationFlags': ''," +
                    "'Model': {" + 
                    //"'FCUSTID': 0," +    //需要更新的话
                    "'FCreateOrgId': {" +
                    "'FNumber': '103'" +     //销售公司
                    "}," +
                    " 'FNumber': ''," +
                    " 'FUseOrgId': {" +
                        "'FNumber': '103'" +   //销售公司
                    "}," +
                    " 'FName': '" + clientName + "'," + 
                    " 'FTRADINGCURRID': {" +   //币别
                    " 'FNumber': 'PRE001'" +
                    " }}}";
            string reslut = Global.client.Save(Global.db_table, str);
            tb_show.Text = "";
            tb_show.Text = "新增结果: "+reslut;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string custId = tb_custId.Text;
            if (Utils.isEmpty(custId))
            {
                Utils.showTip("客户FCUSTID不能为空");
                return;
            }
            string clientName = tb_clientname.Text;
            if (Utils.isEmpty(clientName))
            {
                Utils.showTip("名称不能为空");
                return;
            }
            string str = "{" +
                    "'NeedUpDateFields': []," +
                    " 'NeedReturnFields': ['FCUSTID','FName']," +
                    "'IsDeleteEntry': 'true'," +
                    " 'SubSystemId': ''," +
                    "'IsVerifyBaseDataField': 'false'," +
                    "'IsEntryBatchFill': 'true'," +
                    "'ValidateFlag': 'true'," +
                    "'NumberSearch': 'true'," +
                    "'InterationFlags': ''," +
                    "'Model': {" +
                    "'FCUSTID': " + custId + "," +    //需要更新的话
                    "'FCreateOrgId': {" +
                    "'FNumber': '103'" +     //销售公司
                    "}," +
                    " 'FNumber': ''," +
                    " 'FUseOrgId': {" +
                        "'FNumber': '103'" +   //销售公司
                    "}," +
                    " 'FName': '" + clientName + "'," +
                    " 'FTRADINGCURRID': {" +   //币别
                    " 'FNumber': 'PRE001'" +
                    " }}}";
            string reslut = Global.client.Save(Global.db_table, str);
            tb_show.Text = "";
            tb_show.Text = "更新结果: " + reslut;
        }
    }
}
