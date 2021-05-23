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
            Console.Write(Global.db_table);
            Console.ReadLine();
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
                resStr = "{'CreateOrgId':0,'Numbers':[" + number + "],'Ids':'','NetworkCtrl':''}";
            }
            string result = Global.client.Delete(Global.db_table, resStr);
            tb_show.Text = "";
            tb_show.Text = "删除结果：   " + result;
        }

        
    }
}
