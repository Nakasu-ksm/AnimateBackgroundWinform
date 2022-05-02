using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;
namespace gui_animate_destop
{
   
    internal class Util
    {
        //public static Util util;
        //public Util()
        //{
        //    util = this;
        //}
        private static IntPtr progmanPtr;
        //返回值为0错误
        private static IntPtr sendMessageBack;
        //第二个workw
        private static IntPtr workWPtr;
        public static bool IsAdmin()
        {
            WindowsIdentity current = WindowsIdentity.GetCurrent();
            WindowsPrincipal checkUser = new WindowsPrincipal(current);
            return checkUser.IsInRole(WindowsBuiltInRole.Administrator);
        }
        public void SetAnimeBackground(IntPtr videoPtr)
        {
            //判断系统！！
            double windows_version = Environment.OSVersion.Version.Major;
            progmanPtr = Win32.FindWindow("Progman", null);
            if (progmanPtr == IntPtr.Zero)
            {
                MessageBox.Show("当前系统可能不支持运行本程序或者卡死");
                return;
            }
            else
            {
                Win32.SendMessageTimeout(
                    progmanPtr, 0x52c, IntPtr.Zero, IntPtr.Zero, 0, 0x3e8, sendMessageBack);
                //if(sendMessageBack == IntPtr.Zero)
                //{
                //    MessageBox.Show("意外发生!请重试!");
                //    return;
                //}

                Win32.EnumWindows((hwnd, param) =>
                {
                    if (Win32.FindWindowEx(hwnd, IntPtr.Zero,
                        "SHELLDLL_DefView", null) != IntPtr.Zero)
                    {
                        workWPtr =  Win32.FindWindowEx(IntPtr.Zero, hwnd,
                            "WorkerW", null);
                        if (windows_version < 6.2)
                        {
                            Win32.ShowWindow(workWPtr, 0);
                        }

                    }
                    return true;
                },0);
                //win7适配
                if(windows_version < 6.2)
                {
                    Win32.SetParent(videoPtr, progmanPtr);
                }
                else
                {
                    
                    Win32.SetParent(videoPtr, workWPtr);
                }
              
                
                Thread.Sleep(500);
                Win32.SetWindowPos(videoPtr, IntPtr.Zero, 0, 0, Win32.GetSystemMetrics(0), Win32.GetSystemMetrics(1), 0);
                Thread.Sleep(100);
                VideoForm.videoForm.Show();
            }


        }
    }
}
