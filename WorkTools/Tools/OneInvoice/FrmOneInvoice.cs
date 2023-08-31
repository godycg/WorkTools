using System;
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
            Init(this);
            //Console.WriteLine(ConfigPath);
        }

        public override void Init(FrmBase frm) {
            base.Init(frm);
        }

        private void button1_Click(object sender, EventArgs e) {
            Console.WriteLine(ConfigPath);
            Console.WriteLine(LogPath);
            Console.WriteLine();
        }
    }
}
