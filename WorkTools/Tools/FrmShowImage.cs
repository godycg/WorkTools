using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTools.Tools {
    public partial class FrmShowImage : Form {
        public FrmShowImage() {
            InitializeComponent();
        }

        private string imagePath;

        public FrmShowImage(string imgPath) : this() {
            this.imagePath = imgPath;
            if (System.IO.File.Exists(imagePath)) // 判断文件是否存在
            {
                pictureBox1.Image = Image.FromFile(imagePath); // 加载并显示图片
            }
        }
    }
}
