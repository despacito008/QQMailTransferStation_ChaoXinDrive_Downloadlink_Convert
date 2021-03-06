﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace QQMaiLlinkConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (TopcheckBox.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
        private void convert_Click(object sender, EventArgs e)
        {

            string Share1 = "https://pan-yz.chaoxing.com/external/m/file/";
            string Share2 = "http://mail.qq.com/cgi-bin/ftnExs_download?k=";
            string Share3 = "&t=exs_ftn_download&code=";
            string originallink = "null";
            string sharelink;

            //获取剪切版数据
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(DataFormats.Text))
                originallink = data.GetData(DataFormats.Text).ToString();

            if (originallink.Contains("fileName"))
            {
                string[] chaoxin = originallink.Split(new char[1] { '_' });
                sharelink = Share1 + chaoxin[2];
                Clipboard.SetDataObject(sharelink);
            }
            if (originallink.Contains("https://mail.qq.com/"))
            {
                string[] QQmail = originallink.Split(new string[] { "code=", "&k=" }, StringSplitOptions.RemoveEmptyEntries);
                sharelink = Share2 + QQmail[2] + Share3 + QQmail[1];
                Clipboard.SetDataObject(sharelink);
            }
            MessageBox.Show("链接转换成功并已复制到剪贴板", "复制成功");
        }

        public void somethingToRunInThread()
        {
            string sharelink;
            string Share1 = "https://pan-yz.chaoxing.com/external/m/file/";

            string originallink = Clipboard.GetText();
            //根据特定字符："node_name_"和"\" style"分割字符串，（\"是转义字符）
            string[] chaoxin = originallink.Split(new string[] { "node_name_", "\" style" }, StringSplitOptions.RemoveEmptyEntries);
            // string[] chaoxin = originallink.Split(new char[2] { '_', '"' });
            // 如果用上面那行办法，如果文件名中含"_"将会导致获取链接错误
            sharelink = Share1 + chaoxin[1];
            Clipboard.SetText(sharelink);
            notifyIcon1.ShowBalloonTip(200, "链接转换成功并已复制到剪贴板", sharelink, ToolTipIcon.None);

        }

        public void GetClipboard()
        {
            Thread myThread = new Thread(somethingToRunInThread);
            //注意，一般启动一个线程的时候没有这句话，但是要操作剪切板的话这句话是必需要加上的，因为剪切板只能在单线
            //程单元中访问，这里的STA就是指单线程单元
            myThread.SetApartmentState(ApartmentState.STA);
            myThread.Start();
        }

        //模拟键盘事件
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        public const int KEYEVENTF_KEYUP = 2;

        //模拟鼠标事件
        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        //移动鼠标 
        const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        //导入dll文件
        [DllImport("user32.dll")]
        //函数声明
        public static extern int GetAsyncKeyState(int vKey);
        //时钟监控事件 Interval =100
        private void timer1_Tick(object sender, EventArgs e)
        {
            //需要监控什么按键就写某个按键的ascii码
            if (GetAsyncKeyState(17) != 0 & GetAsyncKeyState(81) != 0)
            {
                Clipboard.Clear();
                //模拟鼠标右键
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                System.Threading.Thread.Sleep(300);
                //模拟Ctrl+Shift+I
                keybd_event(Keys.N, 0, 0, 0);
                keybd_event(Keys.N, 0, KEYEVENTF_KEYUP, 0);
                //延时1S
                System.Threading.Thread.Sleep(1200);
                //模拟F2
                keybd_event(Keys.F2, 0, 0, 0);
                keybd_event(Keys.F2, 0, KEYEVENTF_KEYUP, 0);
                System.Threading.Thread.Sleep(300);
                //模拟Ctrl+A
                keybd_event(Keys.ControlKey, 0, 0, 0);
                keybd_event(Keys.A, 0, 0, 0);
                keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
                keybd_event(Keys.A, 0, KEYEVENTF_KEYUP, 0);
                System.Threading.Thread.Sleep(300);
                //模拟Ctrl+C
                keybd_event(Keys.ControlKey, 0, 0, 0);
                keybd_event(Keys.C, 0, 0, 0);
                keybd_event(Keys.ControlKey, 0, KEYEVENTF_KEYUP, 0);
                keybd_event(Keys.C, 0, KEYEVENTF_KEYUP, 0);
                System.Threading.Thread.Sleep(500);

                GetClipboard();
            }

            }

    }

        }
    














