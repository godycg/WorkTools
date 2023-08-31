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
            //frm.ConfigPath = Path.Combine(Application.StartupPath, "Config", frm.AccessibilityObject.Name + ".ini");
            //frm.LogPath = Path.Combine(Application.StartupPath, "Log", frm.AccessibilityObject.Name + ".log");
            CreateFile(frm.ConfigPath);
            //CreateFile(frm.LogPath);
        }

        private string configPath;

        /// <summary>
        /// 配置文件
        /// </summary>
        public string ConfigPath {
            get { 
                configPath = Path.Combine(Application.StartupPath, "Config", this.AccessibilityObject.Name + ".ini");
                return configPath; 
            }
        }

        private string logPath;
        /// <summary>
        /// 日志文件，根据每天的日期定义不同名称
        /// </summary>
        public string LogPath {
            get {
                logPath = Path.Combine(Application.StartupPath, "Log", this.AccessibilityObject.Name, $"{DateTime.Now.ToString("yyyy-MM-dd")}.log");
                return logPath;
            }
        }


        /// <summary>
        /// 文件路径
        /// </summary>
        /// <param name="path"></param>
        private void CreateFile(string path) {
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

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="log"></param>
        protected void SetLog(string log) {
            CreateFile(this.LogPath);
            try {
                using (FileStream fs = new FileStream(LogPath, FileMode.Append, FileAccess.Write, FileShare.Write)) {
                    using (StreamWriter sw = new StreamWriter(fs)) {
                        sw.AutoFlush = true;
                        sw.WriteLine(DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]") + log);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
