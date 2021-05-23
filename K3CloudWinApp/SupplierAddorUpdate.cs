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
    public partial class SupplierAddorUpdate : Form
    {
        public SupplierAddorUpdate()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string fname = tb_fname.Text;
            if (Utils.isEmpty(fname))
            {
                Utils.showTip("供应商名称必须输入");
                return;
            }
            string jsonStr = "{ " +
                "'NeedUpDateFields': []," +
                "'NeedReturnFields': ['FSUPPLIERID']," +
                "'IsDeleteEntry': 'true'," + 
                "'SubSystemId': ''," +
                " 'IsVerifyBaseDataField': 'false'," +
                "'IsEntryBatchFill': 'true'," +
                "'ValidateFlag': 'true'," + 
                "'NumberSearch': 'true'," +
                "'InterationFlags': ''," + 
                " 'Model': {" + 
                "'FSupplierId': 0," + //更新时可以
                "'FCreateOrgId': {" +
                "'FNumber': '101.2'" +    //这里用总装事业部，只有块组织有这权限
                "}," + 
                "'FNumber': ''," +   //更新时可以
                "'FUseOrgId': {" + 
                "'FNumber': '101.2'" +    //这里用总装事业部，只有块组织有这权限
                "}," +
                "'FName': '" + fname + "'," +
                "'FFinanceInfo': {" +
                "'FPayCurrencyId': {" + 
                "'FNumber': 'PRE001' } } } }";   //结算币别
            string reslut = Global.client.Save(Global.db_table, jsonStr);
            tb_show.Text = "";
            tb_show.Text = "新增结果: " + reslut;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            if (Utils.isEmpty(id))
            {
                Utils.showTip("请输入供应商内码(FSUPPLIERID)");
                return;
            }

            string fname = tb_fname.Text;
            if (Utils.isEmpty(fname))
            {
                Utils.showTip("供应商名称不能为空！");
                return;
            }
            string jsonStr = "{ " +
                "'NeedUpDateFields': []," +
                "'NeedReturnFields': ['FSUPPLIERID']," +
                "'IsDeleteEntry': 'true'," +
                "'SubSystemId': ''," +
                " 'IsVerifyBaseDataField': 'false'," +
                "'IsEntryBatchFill': 'true'," +
                "'ValidateFlag': 'true'," +
                "'NumberSearch': 'true'," +
                "'InterationFlags': ''," +
                " 'Model': {" +
                "'FSupplierId': " + id + "," + //更新时可以
                "'FCreateOrgId': {" +
                "'FNumber': '101.2'" +    //这里用总装事业部，只有块组织有这权限
                "}," +
                "'FNumber': ''," +   //更新时可以
                "'FUseOrgId': {" +
                "'FNumber': '101.2'" +    //这里用总装事业部，只有块组织有这权限
                "}," +
                "'FName': '" + fname + "'," +
                "'FFinanceInfo': {" +
                "'FPayCurrencyId': {" +
                "'FNumber': 'PRE001' } } } }";   //结算币别
            string reslut = Global.client.Save(Global.db_table, jsonStr);
            tb_show.Text = "";
            tb_show.Text = "修改结果: " + reslut;
        }
    }
}
