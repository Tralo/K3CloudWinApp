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
    public partial class Main : Form
    {
        private WebApi webApi;
        public Main()
        {
            InitializeComponent();
            
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            closeBefore();
            Global.curType = 1;
            Global.db_table = Global.map[Global.curType];
            webApi = new WebApi();
            webApi.ShowDialog(this);
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            closeBefore();
            
            Global.curType = 2;
            Global.db_table = Global.map[Global.curType];
            webApi = new WebApi();
            webApi.ShowDialog(this);
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            closeBefore();
            Global.curType = 3;
            Global.db_table = Global.map[Global.curType];
            webApi = new WebApi();
            webApi.ShowDialog(this);
        }

        private void closeBefore()
        {
            if (webApi != null)
            {
                webApi.Dispose();
            }
        }
    }
}
