﻿using System;
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
            client.ShowDialog(this);
        }
    }
}
