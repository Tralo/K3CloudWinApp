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
        private Client client;
        public Main()
        {
            InitializeComponent();
            client = new Client();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            Global.curType = 1;
            client.ShowDialog(this);
        }

        private void btn_material_Click(object sender, EventArgs e)
        {
            Global.curType = 2;
        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            Global.curType = 3;
        }
    }
}
