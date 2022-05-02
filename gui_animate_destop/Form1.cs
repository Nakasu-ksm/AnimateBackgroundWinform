using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using IWshRuntimeLibrary;
using System.Drawing;
using System.Linq;
using System.Threading;

using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_animate_destop
{
    
    public partial class Form1 : Form
    {
        public static SettingForm setting;
        public static Form1 form1;
        //判断是否已经启动动态壁纸
        public int isOpen=1;
        private INIConfigHelper configReader;
        //是否开启声音
        public int isVolume = 0;
        private string[] Okextend = { ".mp4", ".mkv", ".rmvb", ".flv", ".ts", ".avi", ".wmv", ".mov"};
        public Form1()
        {
            
            InitializeComponent();
            this.KeyPreview = true;
            form1 = this;
            //Panel panel = new Panel();
            //this.Controls.Add(panel);
            //panel.Name = "cover_layer";
            //panel.Dock = DockStyle.Fill;
            //panel.Location = new Point(0, 0);
            //panel.BackColor = Color.FromArgb(80, Color.White);
            //panel.Size = new System.Drawing.Size(800, 450);
            openFileDialog1.Filter = "视频文件(*.mp4,*.mkv,*.rmvb,*.flv,*.ts,*.avi,*.wmv,*.mov)|*.mp4;*.mkv;*.rmvb;*.flv;*.ts;*.avi;*.wmv;*.mov";


        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            

            //检测是否选择了关闭声音
            if (this.checkBox1.Checked)
            {
                this.volumeChangeCotroll.Visible = false;
                this.label1.Visible = false;
                this.voiceadjust.Visible = false;
            }
            else
            {
                this.volumeChangeCotroll.Visible = true;
                this.label1.Visible = true;
                this.voiceadjust.Visible = true;
            }
            this.Text = this.Text + About.version;
            //将config文件中的东西赋值
            //隐藏托盘
            notifyIcon1.Visible = false;
            configReader = new INIConfigHelper(string.Concat(AppDomain.CurrentDomain.BaseDirectory, "config.ini"));
            try
            {
                //注册热键
                string closeProgramBossKey = configReader.IniReadValue("config", "closeProgramBossKey");
                string screenshowBossKey = configReader.IniReadValue("config", "screenshowBossKey");
                string volumeBossKey = configReader.IniReadValue("config", "volumeBossKey");
                string pptmodeBossKey = configReader.IniReadValue("config", "pptmodeBossKey");
                if (!string.IsNullOrEmpty(screenshowBossKey))
                {
                    Form1.form1.RegisterHot("关闭/开启壁纸", screenshowBossKey, About.baseNumber + 1);

                }
                if (!string.IsNullOrEmpty(volumeBossKey))
                {
                    Form1.form1.RegisterHot("关闭/开启声音", volumeBossKey, About.baseNumber + 2);

                }
                if (!string.IsNullOrEmpty(pptmodeBossKey))
                {
                    Form1.form1.RegisterHot("伪装静态图集", pptmodeBossKey, About.baseNumber + 3);

                }
                if (!string.IsNullOrEmpty(closeProgramBossKey))
                {
                    Form1.form1.RegisterHot("关闭程序", closeProgramBossKey, About.baseNumber + 0);

                }
            }
            catch { }
            string imagepath = configReader.IniReadValue("config", "imagepath");
            //读出用户上次的视频地址
            filepath.Text =  configReader.IniReadValue("config", "videopath");
            try
            {
                this.BackgroundImage = Image.FromFile(imagepath);
            }
            catch
            {
                MessageBox.Show("自定义壁纸出现问题，请重新设置", "壁纸默认模式启动提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


            
          

            Control[] array = this.Controls.Find("Olayer", false);
            if (array.Length > 0)
            {
                Panel panel = (Panel)array[0];
                panel.BackColor = Color.FromArgb(80, Color.White);

            }

        }

        private void Olayer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          
            filepath.Text = openFileDialog1.FileName;
        }
        private void closeVideo()
        {
            VideoForm.videoForm.Close();
            
        }
        private void setBackground()
        {
            
            if (isOpen == 1)
            {
                //判断是否已经输入了视频地址
                if (string.IsNullOrEmpty(filepath.Text))
                {
                    form1.Visible = true;
                    MessageBox.Show("请输入或者选择视频", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //判断文件是否存在
                if (System.IO.File.Exists(filepath.Text) == false)
                {
                    form1.Visible = true;
                    MessageBox.Show("文件不存在,请重新选择", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //文件格式判断
                if (!Okextend.Contains(Path.GetExtension(filepath.Text)))
                {
                    form1.Visible = true;
                    MessageBox.Show("文件格式不支持\r\n我们目前支持:视频文件(*.mp4,*.mkv,*.rmvb,*.flv,*.ts,*avi,*wmv)的格式", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                configReader.IniWriteValue("config", "videopath", filepath.Text);
                isOpen = 0;
                if (checkBox1.Checked)
                {
                    isVolume = 0;
                }
                else
                {
                    //获取到value值
                    isVolume = (int)this.volumeChangeCotroll.Value;
                }

                var videoform = new VideoForm(filepath.Text, isVolume);
                videoform.Show();
                IntPtr videoPtr = videoform.getHandle();
                var background = new Util();
                background.SetAnimeBackground(videoPtr);
                button1.Text = "停用动态壁纸";

            }
            else
            {

                isOpen = 1;
                button1.Text = "启用动态壁纸";
                VideoForm.videoForm.Close();
                
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            setBackground();
            



            //MessageBox.Show(videoPtr.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            


        }

        private void filepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void Olayer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (setting == null)
            {
                setting = new SettingForm();
                setting.Show();
            }
            

        }

        private void 关闭程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //设置最小化
        private void mini()
        {
            this.Visible = false;
            notifyIcon1.Visible = true;
            MessageBox.Show("程序已经隐藏到托盘");
            notifyIcon1.ShowBalloonTip(2000, "程序已经隐藏到托盘", "程序已经隐藏到托盘", ToolTipIcon.Info);
        }
        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mini();
        }
        //显示程序窗口，恢复显示
        private void Reopen(object sender, EventArgs e)
        {
            


        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (setting == null)
            {
                setting = new SettingForm();
                setting.Show();

            }

        }

        //托盘显示菜单
        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            
            


        }
        //点击托盘菜单和单击程序显示
        private void Notify_click(object sender, MouseEventArgs e)
        {
            //判断壁纸是否已经启动
            if (e.Button == MouseButtons.Right)
            {
                
                if (VideoForm.videoForm == null)
                {
                    Notify_list.Items[3].Visible = true;
                    Notify_list.Items[2].Visible = false;
                }
                else
                {
                    Notify_list.Items[2].Visible = true;
                    Notify_list.Items[3].Visible = false;

                }

                //Notify_list.Show(notifyIcon1,e.Location);
            }
            else
            {
                notifyIcon1.Visible = false;
                this.Visible = true;
            }

        }

        private void 显示主程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示主窗口
            this.Visible = true;
            //隐藏托盘
            notifyIcon1.Visible = false;
        }

        private void 关闭主程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //关闭应用程序
            Application.Exit();
        }

        private void 设置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(setting == null)
            {
                setting = new SettingForm();
                setting.Show();
            }
        }

        private void Notify_list_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 关闭动态壁纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置isopen
            isOpen = 1;
            VideoForm.videoForm.Close();
        }

        private void 开启动态壁纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBackground();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mini();
        }

        private void 强制关闭动态壁纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void 关闭动态壁纸后桌面黑屏解决ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Util.IsAdmin())
            {
                if (VideoForm.videoForm == null)
                {
                    Process[] proc = Process.GetProcessesByName("dwm");
                    if (proc.Count() == 1)
                    {
                        proc[0].Kill();
                    }
                }
                else
                {
                    MessageBox.Show("检测到动态壁纸正在运行，不允许执行本操作");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("请以管理员模式打开本程序!");
                return;
            }
           

        }

        private void VolumeChange(object sender, EventArgs e)
        {
            this.label1.Text =  this.volumeChangeCotroll.Value.ToString()+"%";
            if (VideoForm.videoForm != null)
            {
                VideoForm.changeVolume((int)this.volumeChangeCotroll.Value);
            }
        }

      
        //当是否开启音量的控件被改变执行
        private void ChooseVolumeChange(object sender, EventArgs e)
        {
            
            if (this.checkBox1.Checked)
            {
                if (VideoForm.videoForm != null)
                {
                    VideoForm.changeVolume(0);
                }
                this.volumeChangeCotroll.Visible = false;
                this.label1.Visible = false;
                this.voiceadjust.Visible = false;
            }
            else
            {
                if (VideoForm.videoForm != null)
                {
                    VideoForm.changeVolume((int)this.volumeChangeCotroll.Value);
                }
                this.volumeChangeCotroll.Visible = true;
                this.label1.Visible = true;
                this.voiceadjust.Visible = true;
            }
        }



        //快捷键自定义
     


       
        protected override void WndProc(ref Message m)
        {
            //固定消息名称
            const int HotKeyConst = 0x0312;
            const int OurValue = 33564;
            
            switch (m.Msg)
            {
                
                case HotKeyConst:
                    //不同的快捷键处理 
                    if (setting != null)
                    {

                        if (SettingForm.settingForm.isChangeThing())
                        {
                            break;
                        }
                    }
                   
                    
                    

                    break;
            }
            base.WndProc(ref m);
        }
        public void RunPPtmode()
        {
            int pptnum = 10;
            int pptdelay = 10;


            try
            {
                pptnum = int.Parse(configReader.IniReadValue("config", "PPTmodeNum"));
                pptdelay = int.Parse(configReader.IniReadValue("config", "PPTmodeDelay"));
            }
            catch
            {


            }
            Controller.PPTView(pptnum, pptdelay);
        }
        private void keyup(object sender, KeyEventArgs e)
        {
            //Application.Exit();
        }


        //按键注册
        public void RegisterHot(string Keyname,string Keyvalue, int Keyid)
        {
            var temp = "";
            if (Keyvalue.IndexOf("Alt") != -1)
            {
                temp += "1";
            }
            else
            {
                temp += "0";
            }
            temp += "||";
            if (Keyvalue.IndexOf("Ctrl") != -1)
            {
                temp += "1";
            }
            else
            {
                temp += "0";
            }
            temp += "||";
            if (Keyvalue.IndexOf("Shift") != -1)
            {
                temp += "1";
            }
            else
            {
                temp += "0";
            }
            temp += "||";
            temp+= Keyvalue.Replace("Alt", "").Replace("Ctrl", "").Replace("Shift", "").Replace(" ", "").Replace("+", "");
            var final_key = temp.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
            if (final_key.Length == 4)
            {
                try
                {
                    HotKey.RegisterHotKey(Handle, Keyid, (final_key[0] == "1" ? HotKey.KeyModifiers.Alt : HotKey.KeyModifiers.None) | (final_key[1] == "1" ? HotKey.KeyModifiers.Ctrl : HotKey.KeyModifiers.None) | (final_key[2] == "1" ? HotKey.KeyModifiers.Shift : HotKey.KeyModifiers.None), (Keys)Enum.Parse(typeof(Keys), final_key[3]));

                }
                catch
                {
                    MessageBox.Show("热键定义失败");
                }
            }
        }
        
        public void UnRegisterHot(int baseid)
        {
            try
            {
                HotKey.UnregisterHotKey(Handle, baseid);
            }
            catch
            {
                MessageBox.Show("注销快捷键出错");
            }
        }

        private void 图集模式ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1.form1.RunPPtmode();
        }

        private void 图集模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.form1.RunPPtmode();
        }

        private void 将本程序设置桌面快捷方式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ProgramName = About.ProgramName;
            string ProgramPath = System.Windows.Forms.Application.StartupPath;
            string destopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(destopPath+"/test.lnk");
            shortcut.TargetPath = ProgramPath+"/动态壁纸.exe";
            shortcut.WorkingDirectory = ProgramPath;
            shortcut.WindowStyle = 1;
            shortcut.Description = "运行程序";
            shortcut.IconLocation = ProgramPath;
            shortcut.Save();

        }
    }
}
