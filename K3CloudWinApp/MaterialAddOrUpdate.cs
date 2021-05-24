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
    public partial class MaterialAddOrUpdate : Form
    {
        public MaterialAddOrUpdate()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string fname = tb_fname.Text;
            if (Utils.isEmpty(fname))
            {
                Utils.showTip("物料名称不能为空");
                return;
            }
            string fnumber = tb_number.Text;
            if (Utils.isEmpty(fnumber))
            {
                Utils.showTip("物料编码不能为空");
                return;
            }
            string jsonStr = "{" +
                "'NeedUpDateFields': []," +
                "'NeedReturnFields': ['FMATERIALID','FNUMBER']," +
                "'IsDeleteEntry': 'true'," +
                "'SubSystemId': ''," +
                "'IsVerifyBaseDataField': 'false'," +
                "'IsEntryBatchFill': 'true'," +
                " 'ValidateFlag': 'true'," +
                "'NumberSearch': 'true'," +
                "'InterationFlags': ''," +
                "'Model': {" +
                "'FMATERIALID': 0," +
                "'FCreateOrgId': {" +  //创建组织
                "'FNumber': '101.2'" +
                "}," +
                "'FUseOrgId': {" + //使用组织
                "'FNumber': '101.2'" +
                "}," +
                "'FNumber': '" + fnumber + "'," +  //更新时可以
                "'FName': '" + fname + " '," + // 名称
            "}}";
            string reslut = Global.client.Save(Global.db_table, jsonStr);
            tb_show.Text = "";
            tb_show.Text = "新增结果: " + reslut;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string fname = tb_fname.Text;
            if (Utils.isEmpty(fname))
            {
                Utils.showTip("物料名称不能为空");
                return;
            }
            string id = tb_id.Text;
            if (Utils.isEmpty(id))
            {
                Utils.showTip("物料内码不能为空");
                return;
            }
            string fnumber = tb_number.Text;
            if (Utils.isEmpty(fnumber))
            {
                Utils.showTip("物料编码不能为空");
                return;
            }
            string jsonStr = "{" +
                "'NeedUpDateFields': []," +
                "'NeedReturnFields': ['FNUMBER','FName']," +
                "'IsDeleteEntry': 'true'," +
                "'SubSystemId': ''," +
                "'IsVerifyBaseDataField': 'false'," +
                "'IsEntryBatchFill': 'true'," +
                " 'ValidateFlag': 'true'," +
                "'NumberSearch': 'true'," +
                "'InterationFlags': ''," +
                "'Model': {" +
                "'FMATERIALID': " + id + "," +
                "'FCreateOrgId': {" +  //创建组织
                "'FNumber': '101.2'" +
                "}," +
                "'FUseOrgId': {" + //使用组织
                "'FNumber': '101.2'" +
                "}," +
                "'FNumber': '" + fnumber + "'," +  //更新时可以
                "'FName': '" + fname + " '," + // 名称
            "}}";
            string reslut = Global.client.Save(Global.db_table, jsonStr);
            tb_show.Text = "";
            tb_show.Text = "更新结果: " + reslut;
        }
    }
}
