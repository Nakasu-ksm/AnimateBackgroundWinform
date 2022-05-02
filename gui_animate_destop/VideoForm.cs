using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using LibVLCSharp.Shared;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_animate_destop
{
    public partial class VideoForm : Form
    {
        public static VideoForm videoForm;
        private string url;
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public static void changeVolume(int num)
        {
            videoForm._mp.Volume = num;
        }

        public VideoForm(string lurl,int volume)
        {
            videoForm = this;
            //videoForm.ShowInTaskbar = false;
            url = lurl;
            InitializeComponent();
            _libVLC = new LibVLC("--input-repeat=999999999999999");
            _mp = new MediaPlayer(_libVLC);
            _mp.Volume = volume;
            videoView1.MediaPlayer = _mp;
            
                      
            Load += Form1_Load;
            FormClosed += Form1_FormClosed;
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoForm = null;
            _mp.Stop();
            _mp.Dispose();
            _libVLC.Dispose();
            

        }
        public IntPtr getHandle()
        {
            return this.Handle;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            var media = new Media(_libVLC, string.Format(@"{0}",url));
            _mp.Play(media);
           
            this.Hide();
            media.Dispose();
        }

        private void Fix_resize(object sender, EventArgs e)
        {

            
            Win32.SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, Win32.GetSystemMetrics(0), Win32.GetSystemMetrics(1), 0);

        }

        
    }
}
