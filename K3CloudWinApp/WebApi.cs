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
    public partial class WebApi : Form
    {
        private string id;
        private string number;
        public WebApi()
        {
            InitializeComponent();
            switch (Global.curType)
            {
                case 1:
                    this.Text = "客户";
                    break;
                case 2:
                    this.Text = "物料";
                    break;
                case 3:
                    this.Text = "供应商";
                    break;
            }
        }

        private void btn_research_Click(object sender, EventArgs e)
        {
           
            if (!check())
            {
                Utils.showTip("请输入内码或者编码");
                return;
            }
            string resStr = "";
            if (!Utils.isEmpty(id))
            {
                resStr = "{'CreateOrgId':0,'Number':'','Id':'" + id +"'}";
            }
            else
            {
                resStr = "{'CreateOrgId':0,'Number':'" + number + "','Id':''}";
            }

            string result = Global.client.View(Global.db_table, resStr);
            tb_show.Text = "";
            tb_show.Text = result;
        }

        private Boolean check()
        {
            id = tb_id.Text;
            number = tb_number.Text;
            return Utils.checkIdOrNumber(id, number);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                Utils.showTip("请输入内码或者编码");
                return;
            }
            string resStr = "";
            if (!Utils.isEmpty(id))
            {
                resStr = "{'CreateOrgId':0,'Numbers':[],'Ids':'" + id + "','NetworkCtrl':''}";
            }
            else
            {
                resStr = "{'CreateOrgId':0,'Numbers':['" + number + "'],'Ids':'','NetworkCtrl':''}";
            }
            string result = Global.client.Delete(Global.db_table, resStr);
            tb_show.Text = "";
            tb_show.Text = "删除结果：   " + result;
        }
        private ClientAddOrUpdate clientAddOrUpdate;
        private void btn_create_Click(object sender, EventArgs e)
        {
            if (clientAddOrUpdate != null)
            {
                clientAddOrUpdate.Dispose();
            }
            clientAddOrUpdate = new ClientAddOrUpdate();
            clientAddOrUpdate.ShowDialog(this);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }
        //提交
        private void btn_post_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                Utils.showTip("请输入内码或者编码");
                return;
            }
            string resStr = "";
            if (!Utils.isEmpty(id))
            {
                resStr = "{'CreateOrgId':0,'Numbers':[],'Ids':'" + id + "','SelectedPostId':0,'NetworkCtrl':''}";
            }
            else
            {
                resStr = "{'CreateOrgId':0,'Numbers':['" + number + "'],'Ids':'','SelectedPostId':0,'NetworkCtrl':''}";
            }
            string result = Global.client.Submit(Global.db_table, resStr);
            tb_show.Text = "";
            tb_show.Text = "提交结果：   " + result;
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (!check())
            {
                Utils.showTip("请输入内码或者编码");
                return;
            }
            string resStr = "";
            if (!Utils.isEmpty(id))
            {
                resStr = "{'CreateOrgId':0,'Numbers':[],'Ids':" + id + ",'InterationFlags':'','NetworkCtrl':''}";
            }
            else
            {
                resStr = "{'CreateOrgId':0,'Numbers':['" + number + "'],'Ids':'','InterationFlags':'','NetworkCtrl':''}";
            }
            string result = Global.client.Audit(Global.db_table, resStr);
            tb_show.Text = "";
            tb_show.Text = "审核结果：   " + result;


        }

        private void btn_antiverify_Click(object sender, EventArgs e)
        {

            if (!check())
            {
                Utils.showTip("请输入内码或者编码");
                return;
            }
            string resStr = "";
            if (!Utils.isEmpty(id))
            {
                resStr = "{'CreateOrgId':0,'Numbers':[],'Ids':" + id + ",'InterationFlags':'','NetworkCtrl':''}";
            }
            else
            {
                resStr = "{'CreateOrgId':0,'Numbers':['" + number + "'],'Ids':'','InterationFlags':'','NetworkCtrl':''}";
            }
            string result = Global.client.UnAudit(Global.db_table, resStr);
            tb_show.Text = "";
            tb_show.Text = "反审核结果：   " + result;
        }

        
    }
}
