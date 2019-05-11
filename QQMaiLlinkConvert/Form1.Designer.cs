namespace QQMaiLlinkConvert
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TopcheckBox = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convert
            // 
            this.convert.BackColor = System.Drawing.Color.Transparent;
            this.convert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.convert.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.convert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.convert.Location = new System.Drawing.Point(209, 96);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(256, 39);
            this.convert.TabIndex = 0;
            this.convert.Text = "转换链接并复制到剪贴板(&C)";
            this.convert.UseVisualStyleBackColor = false;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.复制QQ邮箱中转站下载链接（超星网盘网页源代码文件class）后，点击下方按钮即可获取分享链接";
            // 
            // TopcheckBox
            // 
            this.TopcheckBox.AutoSize = true;
            this.TopcheckBox.Checked = true;
            this.TopcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopcheckBox.Location = new System.Drawing.Point(35, 105);
            this.TopcheckBox.Name = "TopcheckBox";
            this.TopcheckBox.Size = new System.Drawing.Size(142, 22);
            this.TopcheckBox.TabIndex = 2;
            this.TopcheckBox.Text = "窗口是否置顶";
            this.TopcheckBox.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "2.选中超星网盘文件后，快捷键:Ctrl+Q，也可获取分享链接";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(368, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "By：阿虚同学";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(508, 174);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopcheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 230);
            this.Name = "Form1";
            this.Text = "获取QQ邮箱中转站 / 超星云盘分享链接";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TopcheckBox;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

