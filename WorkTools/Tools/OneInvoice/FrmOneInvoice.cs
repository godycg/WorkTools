﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTools.Tools.OneInvoice {
    public partial class FrmOneInvoice : FrmBase {
        public FrmOneInvoice() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var frm = new Tools.FrmShowImage(Path.Combine(Application.StartupPath, "PrivateData", "20230822-164642.png"));
            frm.ShowDialog();
        }
    }
}
