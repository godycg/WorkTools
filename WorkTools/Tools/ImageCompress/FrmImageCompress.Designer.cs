namespace WorkTools.Tools.ImageCompress {
    partial class FrmImageCompress {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteXsqdImage = new System.Windows.Forms.Button();
            this.btnDeleteInvoiceImage = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarXsqd = new System.Windows.Forms.ProgressBar();
            this.btnSetInvoicePath = new System.Windows.Forms.Button();
            this.progressBarInvoice = new System.Windows.Forms.ProgressBar();
            this.txtInvoicePath = new System.Windows.Forms.TextBox();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.btnSetXsqdPath = new System.Windows.Forms.Button();
            this.lblInvoicePath = new System.Windows.Forms.Label();
            this.txtXsqdPath = new System.Windows.Forms.TextBox();
            this.lblXsqdPath = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnDeleteXsqdImage);
            this.panel1.Controls.Add(this.btnDeleteInvoiceImage);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBarXsqd);
            this.panel1.Controls.Add(this.btnSetInvoicePath);
            this.panel1.Controls.Add(this.progressBarInvoice);
            this.panel1.Controls.Add(this.txtInvoicePath);
            this.panel1.Controls.Add(this.txtInvoice);
            this.panel1.Controls.Add(this.btnSetXsqdPath);
            this.panel1.Controls.Add(this.lblInvoicePath);
            this.panel1.Controls.Add(this.txtXsqdPath);
            this.panel1.Controls.Add(this.lblXsqdPath);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 338);
            this.panel1.TabIndex = 12;
            // 
            // btnDeleteXsqdImage
            // 
            this.btnDeleteXsqdImage.Location = new System.Drawing.Point(12, 286);
            this.btnDeleteXsqdImage.Name = "btnDeleteXsqdImage";
            this.btnDeleteXsqdImage.Size = new System.Drawing.Size(147, 23);
            this.btnDeleteXsqdImage.TabIndex = 14;
            this.btnDeleteXsqdImage.Text = "删除对应出库单图片";
            this.btnDeleteXsqdImage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInvoiceImage
            // 
            this.btnDeleteInvoiceImage.Location = new System.Drawing.Point(12, 151);
            this.btnDeleteInvoiceImage.Name = "btnDeleteInvoiceImage";
            this.btnDeleteInvoiceImage.Size = new System.Drawing.Size(147, 23);
            this.btnDeleteInvoiceImage.TabIndex = 13;
            this.btnDeleteInvoiceImage.Text = "删除对应发票图片";
            this.btnDeleteInvoiceImage.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(262, 27);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 11;
            this.btnConvert.Text = "压缩";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "发票号";
            // 
            // progressBarXsqd
            // 
            this.progressBarXsqd.Location = new System.Drawing.Point(12, 257);
            this.progressBarXsqd.MarqueeAnimationSpeed = 10;
            this.progressBarXsqd.Name = "progressBarXsqd";
            this.progressBarXsqd.Size = new System.Drawing.Size(457, 23);
            this.progressBarXsqd.Step = 1;
            this.progressBarXsqd.TabIndex = 10;
            // 
            // btnSetInvoicePath
            // 
            this.btnSetInvoicePath.Location = new System.Drawing.Point(475, 93);
            this.btnSetInvoicePath.Name = "btnSetInvoicePath";
            this.btnSetInvoicePath.Size = new System.Drawing.Size(75, 23);
            this.btnSetInvoicePath.TabIndex = 1;
            this.btnSetInvoicePath.Text = "选择";
            this.btnSetInvoicePath.UseVisualStyleBackColor = true;
            // 
            // progressBarInvoice
            // 
            this.progressBarInvoice.Location = new System.Drawing.Point(12, 122);
            this.progressBarInvoice.MarqueeAnimationSpeed = 10;
            this.progressBarInvoice.Name = "progressBarInvoice";
            this.progressBarInvoice.Size = new System.Drawing.Size(457, 23);
            this.progressBarInvoice.Step = 1;
            this.progressBarInvoice.TabIndex = 9;
            // 
            // txtInvoicePath
            // 
            this.txtInvoicePath.Location = new System.Drawing.Point(12, 95);
            this.txtInvoicePath.Name = "txtInvoicePath";
            this.txtInvoicePath.Size = new System.Drawing.Size(457, 21);
            this.txtInvoicePath.TabIndex = 1;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Location = new System.Drawing.Point(12, 29);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(244, 21);
            this.txtInvoice.TabIndex = 0;
            // 
            // btnSetXsqdPath
            // 
            this.btnSetXsqdPath.Location = new System.Drawing.Point(475, 228);
            this.btnSetXsqdPath.Name = "btnSetXsqdPath";
            this.btnSetXsqdPath.Size = new System.Drawing.Size(75, 23);
            this.btnSetXsqdPath.TabIndex = 7;
            this.btnSetXsqdPath.Text = "选择";
            this.btnSetXsqdPath.UseVisualStyleBackColor = true;
            // 
            // lblInvoicePath
            // 
            this.lblInvoicePath.AutoSize = true;
            this.lblInvoicePath.Location = new System.Drawing.Point(10, 80);
            this.lblInvoicePath.Name = "lblInvoicePath";
            this.lblInvoicePath.Size = new System.Drawing.Size(101, 12);
            this.lblInvoicePath.TabIndex = 4;
            this.lblInvoicePath.Text = "发票图片文件夹：";
            // 
            // txtXsqdPath
            // 
            this.txtXsqdPath.Location = new System.Drawing.Point(12, 230);
            this.txtXsqdPath.Name = "txtXsqdPath";
            this.txtXsqdPath.Size = new System.Drawing.Size(457, 21);
            this.txtXsqdPath.TabIndex = 6;
            // 
            // lblXsqdPath
            // 
            this.lblXsqdPath.AutoSize = true;
            this.lblXsqdPath.Location = new System.Drawing.Point(10, 215);
            this.lblXsqdPath.Name = "lblXsqdPath";
            this.lblXsqdPath.Size = new System.Drawing.Size(113, 12);
            this.lblXsqdPath.TabIndex = 5;
            this.lblXsqdPath.Text = "出库单图片文件夹：";
            // 
            // FrmImageCompress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 362);
            this.Controls.Add(this.panel1);
            this.Name = "FrmImageCompress";
            this.Text = "FrmImageCompress";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteXsqdImage;
        private System.Windows.Forms.Button btnDeleteInvoiceImage;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarXsqd;
        private System.Windows.Forms.Button btnSetInvoicePath;
        private System.Windows.Forms.ProgressBar progressBarInvoice;
        private System.Windows.Forms.TextBox txtInvoicePath;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Button btnSetXsqdPath;
        private System.Windows.Forms.Label lblInvoicePath;
        private System.Windows.Forms.TextBox txtXsqdPath;
        private System.Windows.Forms.Label lblXsqdPath;
    }
}