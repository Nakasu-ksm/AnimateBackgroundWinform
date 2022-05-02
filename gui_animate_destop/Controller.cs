using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace gui_animate_destop
{
    internal class Controller
    {
        static Task task;
        public static int PPTmode = 0;
        //记录临时音量
        public static int tempVolume = 0;
        //记录临时位置
        public static long tempPostion = 0;
        //图集模式的video length
        public static long VideoLength = 0;
        //图集模式图片切换延时
        public static int PPTmodeDelay = 10;
        //图集模式图片数
        public static int PPTmodeNum=10;
        public static void CloseAPP()
        {
            Application.Exit();
        }
        public static void VideoPause()
        {
            if (VideoForm.videoForm != null)
                VideoForm.videoForm._mp.Pause();

        }

        //关闭/开启声音
        public static void VoiceController()
        {
            if (VideoForm.videoForm != null)
            {
                if (VideoForm.videoForm._mp.Volume!=0)
                {
                    //非静音情况处理
                    tempVolume = VideoForm.videoForm._mp.Volume;
                    VideoForm.videoForm._mp.Volume = 0;
                    
                }
                else
                {
                    //静音情况处理
                    VideoForm.videoForm._mp.Volume = tempVolume;
                }
            }
        }
        //伪装图集模式

        public static void PPTView(int num, int delay)
        {
          
            if(VideoForm.videoForm == null)
            {
                MessageBox.Show("您并没有开启任意一个视频，无法进入图集模式");
                return;
               
            }
            else
            {
                if (PPTmode == 0)
                {
                    
                  
                    
                    VideoForm.videoForm._mp.Pause();
                    VideoLength = VideoForm.videoForm._mp.Length;
                    PPTmode = 1;
                 
                   
                    if (VideoLength == -1)
                    {
                        MessageBox.Show("视频未加载");
                        return;
                    }
                    tempVolume = VideoForm.videoForm._mp.Volume;
                    tempPostion = VideoForm.videoForm._mp.Time;
                    task = new Task(async () =>
                    {
                        int different_count = 0;
                        //限制10张图片
                        long[] vs = new long[num];
                        var r = new Random();
                        for (int i = 0; i < vs.Length; i++)
                        {
                            vs[i] = Common.NextLong(r, 1, VideoLength);
                            
                        }
                        Console.WriteLine(Common.NextLong(r, 1, VideoLength));
                        while (true)
                        {
                            if (PPTmode != 0)
                            {
                                VideoForm.videoForm._mp.Time = vs[r.Next(0, vs.Length-1)];
                                await Task.Delay(delay*1000);
                            }
                            else
                            {
                                return;
                            }
                            //返回随机的0,9里面的一张


                        }

                    });
                    task.Start();
                }
                else
                {

                    PPTmode = 0;
                    VideoForm.videoForm._mp.Time = tempPostion;
                    VideoForm.videoForm._mp.Play();

                }
            }

        }
    }
}
