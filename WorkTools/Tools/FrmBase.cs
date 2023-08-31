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

namespace WorkTools.Tools {
    public partial class FrmBase : Form {
        public FrmBase() {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void Init(FrmBase frm) {
            frm.ConfigPath = Path.Combine(Application.StartupPath, "Config", frm.AccessibilityObject.Name + ".ini");
            CreateConfigFile(frm.ConfigPath);
        }

        private string configPath;

        /// <summary>
        /// 创建配置文件
        /// </summary>
        public string ConfigPath {
            get { return configPath; }
            set { configPath = value; }
        }
        /// <summary>
        /// 文件路径
        /// </summary>
        /// <param name="path"></param>
        private void CreateConfigFile(string path) {
            if (string.IsNullOrWhiteSpace(path)) {
                return;
            }
            var dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir)) {
                Directory.CreateDirectory(dir);
            }
            if (File.Exists(path)) {
                return;
            }
            FileStream fs = File.Create(path);
            fs.Close();
        }
    }
}
