using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_animate_destop
{

    public partial class SettingForm : Form
    {
        public static SettingForm settingForm;
        private INIConfigHelper configReader;
        public SettingForm()
        {
            
            InitializeComponent();
            settingForm = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            configReader =   new INIConfigHelper(string.Concat(AppDomain.CurrentDomain.BaseDirectory, "config.ini"));
            string test = configReader.IniReadValue("config", "imagepath");
            
            try
            {
                this.photoDelay.Value = int.Parse(configReader.IniReadValue("config", "PPTmodeDelay"));
                this.photoNum.Value = int.Parse(configReader.IniReadValue("config", "PPTmodeNum"));
                this.textBox1.Text = configReader.IniReadValue("config", "closeProgramBossKey");
                this.textBox2.Text = configReader.IniReadValue("config", "screenshowBossKey");
                this.textBox3.Text = configReader.IniReadValue("config", "volumeBossKey");
                this.textBox4.Text = configReader.IniReadValue("config", "pptmodeBossKey");
                this.pictureBox1.BackgroundImage = Image.FromFile(test);
                

            }
            catch
            {
               
            }


    }

        private void chooseBackground(object sender, CancelEventArgs e)
        {
            string filename =  this.openFileDialog1.FileName;
            try
            {
                this.pictureBox1.BackgroundImage = Image.FromFile(this.openFileDialog1.FileName);
                

            }
            catch
            {
                filename = "";
                MessageBox.Show("图片不合法请重新选择!!");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (pictureBox1.Image != null)
                {
                    Form1.form1.BackgroundImage = Image.FromFile(this.openFileDialog1.FileName);
                    configReader.IniWriteValue("config", "imagepath", this.openFileDialog1.FileName);

                }
                string[] Temparr = new string[4];
                //比较
                ISet<string> set = new HashSet<string>();
                
                //MessageBox.Show(openFileDialog1.FileName);
                //if(textBox1.Text == textBox2.Text)
                //{
                //    MessageBox.Show("快捷键不能相同");
                //    return;
                //}

                if (!string.IsNullOrEmpty(this.textBox1.Text))
                {
                    //MessageBox.Show(this.textBox1.Text);
                    Form1.form1.UnRegisterHot(About.baseNumber + 0);
                    Form1.form1.RegisterHot("关闭程序", this.textBox1.Text, About.baseNumber + 0);
                }
                else
                {
                    Form1.form1.UnRegisterHot(About.baseNumber + 0);

                }
                //关闭/开启壁纸的快捷键
                if (!string.IsNullOrEmpty(this.textBox2.Text))
                {
                    Form1.form1.UnRegisterHot(About.baseNumber + 1);
                    Form1.form1.RegisterHot("关闭/开启壁纸", this.textBox2.Text, About.baseNumber + 1);
                }
                else
                {
                    Form1.form1.UnRegisterHot(About.baseNumber + 1);

                }
                //声音设置
                if (!string.IsNullOrEmpty(this.textBox3.Text))
                {
                    Form1.form1.UnRegisterHot(About.baseNumber + 2);
                    Form1.form1.RegisterHot("关闭/开启声音", this.textBox3.Text, About.baseNumber + 2);
                }
                else
                {
                    Form1.form1.UnRegisterHot(About.baseNumber + 2);

                }

                //伪装静态图集注册快捷键
                if (!string.IsNullOrEmpty(this.textBox4.Text))
                {
                    Form1.form1.UnRegisterHot(About.baseNumber + 3);
                    Form1.form1.RegisterHot("伪装静态图集", this.textBox4.Text, About.baseNumber + 3);
                }
                else
                {
                    Form1.form1.UnRegisterHot(About.baseNumber + 3);

                }
                
                configReader.IniWriteValue("config", "PPTmodeDelay", this.photoDelay.Value.ToString());
                configReader.IniWriteValue("config", "PPTmodeNum", this.photoNum.Value.ToString());
                configReader.IniWriteValue("config", "closeProgramBossKey", this.textBox1.Text);
                configReader.IniWriteValue("config", "screenshowBossKey", this.textBox2.Text);
                configReader.IniWriteValue("config", "volumeBossKey", this.textBox3.Text);
                configReader.IniWriteValue("config", "pptmodeBossKey", this.textBox4.Text);
                MessageBox.Show("保存成功！", "设置保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("图片设置出现错误！", "图片设置出现错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //设置热键
            //判断是不是空
            
            //保存设置




        }

        private void SettingClose(object sender, FormClosedEventArgs e)
        {
            Form1.setting = null;
            SettingForm.settingForm = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }
        //判断是否正在编辑快捷键(目前有4个)
        public bool isChangeThing()
        {
            if(textBox1.Focused || textBox2.Focused || textBox3.Focused || textBox4.Focused)
            {
                return true;
            }
            return false;

        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            
        }

        private void StartOrStopInput(object sender, KeyEventArgs e)
        {
            var obj = (TextBox)sender;
            
            obj.Text = "";
            if (Keys.Space == e.KeyCode)
            {
                return;
           
            }
            if (e.Control)
            {
                obj.Text += "Ctrl";
            }
            if (e.Shift)
            {
                if (obj.Text != "")
                {
                    obj.Text += " + ";
                }
               
                obj.Text += "Shift";
            }
            if (e.Alt)
            {
                if (obj.Text != "")
                {
                    obj.Text += " + ";
                }
                obj.Text += "Alt";
            }
            if (e.KeyCode != Keys.Menu && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.ShiftKey)
            {
                if (obj.Text != "")
                {
                    obj.Text += " + ";
                }
                obj.Text += e.KeyCode;
            }
        }
        //获取定义快捷键输入框的东西
        private string getHotKey(int num)
        {
            switch (num)
            {
                case 1:
                    return textBox1.Text;
                case 2:
                    return textBox2.Text;
                case 3:
                    return textBox3.Text;
                case 4:
                    return textBox4.Text;
            }
            return null;
        }
        //检测快捷键是否被占用
        private void CheckHotKeyEmpty(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
