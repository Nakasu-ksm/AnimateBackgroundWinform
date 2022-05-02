using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace gui_animate_destop
{
    public class INIConfigHelper
    {
        public string Path;     //INI文件名
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        //声明读写INI文件的API函数     
        public INIConfigHelper(string iniPath)
        {
            Path = iniPath;
        }

        //类的构造函数，传递INI文件名
        public void IniWriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.Path);
        }

        //读INI文件         
        public string IniReadValue(string section, string key)
        {
            var temp = new StringBuilder(256);
            int i = GetPrivateProfileString(section, key, "", temp, 256, this.Path);
            return temp.ToString();
        }
    }
}
