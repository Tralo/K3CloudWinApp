using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kingdee.BOS.WebApi.Client;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Configuration;
namespace K3CloudWinApp
{
    public partial class MainStart : Form
    {
        private string path = "";
        public MainStart()
        {
            InitializeComponent();
            
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Write_keyValue(path, "url", tb_url.Text);
            Write_keyValue(path, "dbid", tb_dbid.Text);
            Write_keyValue(path, "user", tb_user.Text);
            Write_keyValue(path, "pwd", tb_pwd.Text);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string url = tb_url.Text;
            string dbid = tb_dbid.Text;
            string user = tb_user.Text;
            string pwd = tb_pwd.Text;
            if (Utils.isEmpty(url))
            {
                Utils.showTip("站点地址不能为空");
                return;
            }
            if (Utils.isEmpty(dbid))
            {
                Utils.showTip("账套id不能为空");
                return;
            }
            if (Utils.isEmpty(user))
            {
                Utils.showTip("用户名不能为空");
                return;
            }
            if (Utils.isEmpty(pwd))
            {
                Utils.showTip("用户密码不能为空");
                return;
            }
            K3CloudApiClient client = new K3CloudApiClient(url);
            var loginResult = client.ValidateLogin(dbid, user, pwd, 2052);
            var resultType = JObject.Parse(loginResult)["LoginResultType"].Value<int>();
            if (resultType == 1)
            {
                Utils.showTip("连接成功");
                Global.client = client;
                Global.map.Add(1, "BD_Customer");
                Global.map.Add(2, "BD_MATERIAL");
                Global.map.Add(3, "BD_Supplier");
                this.Close();
                Thread th = new Thread(delegate()
                {
                    new Main().ShowDialog();
                });
                th.Start();
            }
            else
            {
                Utils.showTip("连接失败，请检查网络问题或者账号密码");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_url.Text = Global.url;
            tb_dbid.Text = Global.dbid;
            tb_user.Text = Global.user;
            tb_pwd.Text = Global.pwd;
            //path = Application.ExecutablePath + ".config";
            //tb_url.Text = Read_keyValue(path, "url");
            //tb_dbid.Text = Read_keyValue(path, "dbid");
            //tb_user.Text = Read_keyValue(path, "user");
            //tb_pwd.Text = Read_keyValue(path, "pwd");
            
        }

        string Read_keyValue(string path, string keyName)
        {
            
            Configuration config = ConfigurationManager.OpenExeConfiguration(path);
            Console.WriteLine(keyName + "   " + path);
            Console.ReadLine();
            return config.AppSettings.Settings[keyName].Value;
            
        }

        private void Write_keyValue(string path, String keyName, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(path);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == keyName)
                {
                    config.AppSettings.Settings.Remove(key);
                }
            }
            config.AppSettings.Settings.Add(keyName, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("AppSettings");
        }

        
    }
}
