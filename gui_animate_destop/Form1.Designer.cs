namespace gui_animate_destop
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Olayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.voiceadjust = new System.Windows.Forms.Label();
            this.volumeChangeCotroll = new HZH_Controls.Controls.UCTrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.filepath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图集模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.异常修复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.强制关闭动态壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭动态壁纸后桌面黑屏解决ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快捷工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭桌面图标显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启桌面图标显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.将本程序设置桌面快捷方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Notify_list = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示主程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭动态壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启动态壁纸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图集模式ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭主程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Olayer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Notify_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(249, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "启用动态壁纸";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 268);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 91);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(126, 295);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(512, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "选择文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Olayer
            // 
            this.Olayer.Controls.Add(this.label1);
            this.Olayer.Controls.Add(this.voiceadjust);
            this.Olayer.Controls.Add(this.volumeChangeCotroll);
            this.Olayer.Controls.Add(this.button4);
            this.Olayer.Controls.Add(this.pictureBox1);
            this.Olayer.Controls.Add(this.button3);
            this.Olayer.Controls.Add(this.checkBox1);
            this.Olayer.Controls.Add(this.filepath);
            this.Olayer.Controls.Add(this.button2);
            this.Olayer.Controls.Add(this.pictureBox2);
            this.Olayer.Controls.Add(this.button1);
            this.Olayer.Controls.Add(this.menuStrip1);
            this.Olayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Olayer.Location = new System.Drawing.Point(0, 0);
            this.Olayer.Margin = new System.Windows.Forms.Padding(4);
            this.Olayer.Name = "Olayer";
            this.Olayer.Size = new System.Drawing.Size(669, 325);
            this.Olayer.TabIndex = 2;
            this.Olayer.Paint += new System.Windows.Forms.PaintEventHandler(this.Olayer_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(439, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "0%";
            // 
            // voiceadjust
            // 
            this.voiceadjust.AutoSize = true;
            this.voiceadjust.BackColor = System.Drawing.Color.Transparent;
            this.voiceadjust.Location = new System.Drawing.Point(113, 224);
            this.voiceadjust.Name = "voiceadjust";
            this.voiceadjust.Size = new System.Drawing.Size(67, 15);
            this.voiceadjust.TabIndex = 11;
            this.voiceadjust.Text = "音量调整";
            // 
            // volumeChangeCotroll
            // 
            this.volumeChangeCotroll.BackColor = System.Drawing.Color.Transparent;
            this.volumeChangeCotroll.DcimalDigits = 0;
            this.volumeChangeCotroll.IsShowTips = false;
            this.volumeChangeCotroll.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.volumeChangeCotroll.LineWidth = 10F;
            this.volumeChangeCotroll.Location = new System.Drawing.Point(186, 215);
            this.volumeChangeCotroll.MaxValue = 100F;
            this.volumeChangeCotroll.MinValue = 0F;
            this.volumeChangeCotroll.Name = "volumeChangeCotroll";
            this.volumeChangeCotroll.Size = new System.Drawing.Size(250, 30);
            this.volumeChangeCotroll.TabIndex = 10;
            this.volumeChangeCotroll.Text = "ucTrackBar1";
            this.volumeChangeCotroll.TipsFormat = null;
            this.volumeChangeCotroll.Value = 0F;
            this.volumeChangeCotroll.ValueColor = System.Drawing.Color.DodgerBlue;
            this.volumeChangeCotroll.ValueChanged += new System.EventHandler(this.VolumeChange);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(451, 285);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "隐藏到托盘";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(565, 285);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "设置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(279, 189);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "关闭视频声音";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.ChooseVolumeChange);
            // 
            // filepath
            // 
            this.filepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filepath.Location = new System.Drawing.Point(157, 69);
            this.filepath.Margin = new System.Windows.Forms.Padding(4);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(329, 25);
            this.filepath.TabIndex = 5;
            this.filepath.TextChanged += new System.EventHandler(this.filepath_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.异常修复ToolStripMenuItem,
            this.快捷工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(669, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.图集模式ToolStripMenuItem,
            this.最小化ToolStripMenuItem,
            this.关闭程序ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 图集模式ToolStripMenuItem
            // 
            this.图集模式ToolStripMenuItem.Name = "图集模式ToolStripMenuItem";
            this.图集模式ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.图集模式ToolStripMenuItem.Text = "图集模式";
            this.图集模式ToolStripMenuItem.Click += new System.EventHandler(this.图集模式ToolStripMenuItem_Click);
            // 
            // 最小化ToolStripMenuItem
            // 
            this.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem";
            this.最小化ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.最小化ToolStripMenuItem.Text = "最小化";
            this.最小化ToolStripMenuItem.Click += new System.EventHandler(this.最小化ToolStripMenuItem_Click);
            // 
            // 关闭程序ToolStripMenuItem
            // 
            this.关闭程序ToolStripMenuItem.Name = "关闭程序ToolStripMenuItem";
            this.关闭程序ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.关闭程序ToolStripMenuItem.Text = "关闭程序";
            this.关闭程序ToolStripMenuItem.Click += new System.EventHandler(this.关闭程序ToolStripMenuItem_Click);
            // 
            // 异常修复ToolStripMenuItem
            // 
            this.异常修复ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.强制关闭动态壁纸ToolStripMenuItem,
            this.关闭动态壁纸后桌面黑屏解决ToolStripMenuItem});
            this.异常修复ToolStripMenuItem.Name = "异常修复ToolStripMenuItem";
            this.异常修复ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.异常修复ToolStripMenuItem.Text = "异常修复";
            // 
            // 强制关闭动态壁纸ToolStripMenuItem
            // 
            this.强制关闭动态壁纸ToolStripMenuItem.Name = "强制关闭动态壁纸ToolStripMenuItem";
            this.强制关闭动态壁纸ToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.强制关闭动态壁纸ToolStripMenuItem.Text = "强制关闭动态壁纸";
            this.强制关闭动态壁纸ToolStripMenuItem.Click += new System.EventHandler(this.强制关闭动态壁纸ToolStripMenuItem_Click);
            // 
            // 关闭动态壁纸后桌面黑屏解决ToolStripMenuItem
            // 
            this.关闭动态壁纸后桌面黑屏解决ToolStripMenuItem.Name = "关闭动态壁纸后桌面黑屏解决ToolStripMenuItem";
            this.关闭动态壁纸后桌面黑屏解决ToolStripMenuItem.Size = new System.Drawing.Size(372, 26);
            this.关闭动态壁纸后桌面黑屏解决ToolStripMenuItem.Text = "关闭动态壁纸后桌面黑屏解决(不建议使用)";
            this.关闭动态壁纸后桌面黑屏解决ToolStripMenuItem.Click += new System.EventHandler(this.关闭动态壁纸后桌面黑屏解决ToolStripMenuItem_Click);
            // 
            // 快捷工具ToolStripMenuItem
            // 
            this.快捷工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭桌面图标显示ToolStripMenuItem,
            this.开启桌面图标显示ToolStripMenuItem,
            this.将本程序设置桌面快捷方式ToolStripMenuItem});
            this.快捷工具ToolStripMenuItem.Name = "快捷工具ToolStripMenuItem";
            this.快捷工具ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.快捷工具ToolStripMenuItem.Text = "快捷工具";
            // 
            // 关闭桌面图标显示ToolStripMenuItem
            // 
            this.关闭桌面图标显示ToolStripMenuItem.Name = "关闭桌面图标显示ToolStripMenuItem";
            this.关闭桌面图标显示ToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.关闭桌面图标显示ToolStripMenuItem.Text = "关闭桌面图标显示";
            // 
            // 开启桌面图标显示ToolStripMenuItem
            // 
            this.开启桌面图标显示ToolStripMenuItem.Name = "开启桌面图标显示ToolStripMenuItem";
            this.开启桌面图标显示ToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.开启桌面图标显示ToolStripMenuItem.Text = "开启桌面图标显示";
            // 
            // 将本程序设置桌面快捷方式ToolStripMenuItem
            // 
            this.将本程序设置桌面快捷方式ToolStripMenuItem.Name = "将本程序设置桌面快捷方式ToolStripMenuItem";
            this.将本程序设置桌面快捷方式ToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.将本程序设置桌面快捷方式ToolStripMenuItem.Text = "将本程序设置桌面快捷方式";
            this.将本程序设置桌面快捷方式ToolStripMenuItem.Click += new System.EventHandler(this.将本程序设置桌面快捷方式ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.Notify_list;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "动态壁纸修改器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.Reopen);
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Notify_click);
            this.notifyIcon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            // 
            // Notify_list
            // 
            this.Notify_list.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Notify_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示主程序ToolStripMenuItem,
            this.设置ToolStripMenuItem1,
            this.关闭动态壁纸ToolStripMenuItem,
            this.开启动态壁纸ToolStripMenuItem,
            this.图集模式ToolStripMenuItem1,
            this.关闭主程序ToolStripMenuItem});
            this.Notify_list.Name = "Notify_list";
            this.Notify_list.Size = new System.Drawing.Size(169, 148);
            this.Notify_list.Opening += new System.ComponentModel.CancelEventHandler(this.Notify_list_Opening);
            // 
            // 显示主程序ToolStripMenuItem
            // 
            this.显示主程序ToolStripMenuItem.Name = "显示主程序ToolStripMenuItem";
            this.显示主程序ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.显示主程序ToolStripMenuItem.Text = "显示主程序";
            this.显示主程序ToolStripMenuItem.Click += new System.EventHandler(this.显示主程序ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem1
            // 
            this.设置ToolStripMenuItem1.Name = "设置ToolStripMenuItem1";
            this.设置ToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.设置ToolStripMenuItem1.Text = "设置";
            this.设置ToolStripMenuItem1.Click += new System.EventHandler(this.设置ToolStripMenuItem1_Click);
            // 
            // 关闭动态壁纸ToolStripMenuItem
            // 
            this.关闭动态壁纸ToolStripMenuItem.Name = "关闭动态壁纸ToolStripMenuItem";
            this.关闭动态壁纸ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.关闭动态壁纸ToolStripMenuItem.Text = "关闭动态壁纸";
            this.关闭动态壁纸ToolStripMenuItem.Click += new System.EventHandler(this.关闭动态壁纸ToolStripMenuItem_Click);
            // 
            // 开启动态壁纸ToolStripMenuItem
            // 
            this.开启动态壁纸ToolStripMenuItem.Name = "开启动态壁纸ToolStripMenuItem";
            this.开启动态壁纸ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.开启动态壁纸ToolStripMenuItem.Text = "开启动态壁纸";
            this.开启动态壁纸ToolStripMenuItem.Click += new System.EventHandler(this.开启动态壁纸ToolStripMenuItem_Click);
            // 
            // 图集模式ToolStripMenuItem1
            // 
            this.图集模式ToolStripMenuItem1.Name = "图集模式ToolStripMenuItem1";
            this.图集模式ToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.图集模式ToolStripMenuItem1.Text = "图集模式";
            this.图集模式ToolStripMenuItem1.Click += new System.EventHandler(this.图集模式ToolStripMenuItem1_Click);
            // 
            // 关闭主程序ToolStripMenuItem
            // 
            this.关闭主程序ToolStripMenuItem.Name = "关闭主程序ToolStripMenuItem";
            this.关闭主程序ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.关闭主程序ToolStripMenuItem.Text = "关闭主程序";
            this.关闭主程序ToolStripMenuItem.Click += new System.EventHandler(this.关闭主程序ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 325);
            this.Controls.Add(this.Olayer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "动态壁纸客户端V";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Olayer.ResumeLayout(false);
            this.Olayer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Notify_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Olayer;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最小化ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip Notify_list;
        private System.Windows.Forms.ToolStripMenuItem 显示主程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 关闭动态壁纸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启动态壁纸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭主程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 异常修复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 强制关闭动态壁纸ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭动态壁纸后桌面黑屏解决ToolStripMenuItem;
        private HZH_Controls.Controls.UCTrackBar volumeChangeCotroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label voiceadjust;
        private System.Windows.Forms.ToolStripMenuItem 图集模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图集模式ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 快捷工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭桌面图标显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启桌面图标显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 将本程序设置桌面快捷方式ToolStripMenuItem;
    }
}

