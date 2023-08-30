using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkTools.Tools;

namespace WorkTools {
    public partial class FrmMain : Form {

        List<Tools.FrmBase> forms;

        public FrmMain() {
            InitializeComponent();

            forms = new List<Tools.FrmBase>() {
                new Tools.FrmBase(),
                new Tools.OneInvoice.FrmOneInvoice(),
                new Tools.ImageCompress.FrmImageCompress(),
            };
            foreach (FrmBase form in forms) {
                form.FormClosing += (s, e) => {
                    //(s as FrmBase).WindowState = FormWindowState.Minimized;
                    (s as FrmBase).Hide();
                    e.Cancel = true;
                };
                Button btn = new Button();
                btn.Size = new Size(90, 40);
                btn.Click += (s, e) => {
                    form.Show();
                    //form.WindowState |= FormWindowState.Normal;
                    form.Activate();
                };
                btn.Text = form.Text;
                this.Controls.Add(btn);
                btn.Dock = DockStyle.Top;
            }
        }
    }
}
