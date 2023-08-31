using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTools.Tools.ImageCompress {
    public partial class FrmImageCompress : FrmBase {
        public FrmImageCompress() {
            InitializeComponent();
            Init(this);

        }

        private void btnConvert_Click(object sender, EventArgs e) {
            Console.WriteLine(ConfigPath);
            Console.WriteLine(LogPath);
            Console.WriteLine();
        }
    }
}
