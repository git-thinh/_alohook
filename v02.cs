using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace zalohook
{ 
    class v02
    {
        #region

        private static void SetPosition(int a, int b)
        {
            SetCursorPos(a, b);
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);


        //Initialization
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool EnableWindow(IntPtr hwnd, bool enable);
        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr handle, int x, int y, int width,
        int height, bool redraw);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool BringWindowToTop(IntPtr hWnd);

        static int SW_SHOW = 5;





        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;


        static void mouse_click(int X, int Y)
        {
            SetPosition(X, Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)X, (uint)Y, 0, 0);
            Thread.Sleep(3000);
        }

        #endregion

        [STAThread]
        public static void Run()
        {
            Process[] processes = Process.GetProcesses();

            if (File.Exists("pid.txt"))
            {
                string spid = File.ReadAllText("pid.txt");
                if (!string.IsNullOrEmpty(spid))
                {
                    int id = 0;
                    if (int.TryParse(spid.Trim(), out id))
                    {
                        if (id > 0)
                        {
                            try
                            {
                                foreach (Process p in processes)
                                {
                                    if (p.Id == id)
                                    {
                                        p.Kill();
                                        break;
                                    }
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }

            Thread.Sleep(5000);
            Clipboard.SetText("903209655");

            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle) && p.MainWindowTitle.ToLower().Contains("zalo"))
                {
                    //SetPosition(10, 10);
                    //App app = new App(p);
                    //app.Show();

                    IntPtr HWND = p.MainWindowHandle;
                    ShowWindow(HWND, SW_SHOW);
                    EnableWindow(HWND, true);
                    MoveWindow(HWND, 0, 50, 640, 480, true);

                    BringWindowToTop(HWND);

                    mouse_click(99, 15); //zalo taskbar: 1055 14

                    mouse_click(123, 93); //zalo select contact

                    mouse_click(98, 216); //zalo select add friend

                    //mouse_click(274, 381); //zalo enter phone number

                    SendKeys.SendWait("^v");
                    //SendKeys.SendWait("{CTRL}v");
                    //SendKeys.SendWait("^(v)");
                    //SendKeys.SendWait("{CTRL}v");
                    Thread.Sleep(1000);

                    mouse_click(719, 376); //zalo click button search
                    mouse_click(636, 544); //zalo send message

                    Clipboard.SetText(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss fff"));
                    SendKeys.SendWait("^v");
                    Thread.Sleep(1000);
                    SendKeys.SendWait("{ENTER}");

                    break;
                }
            }

            int pid = Process.GetCurrentProcess().Id;
            File.WriteAllText("pid.txt", pid.ToString());

            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            Process proc = new Process();
            proc.StartInfo.FileName = path;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        } //end


    }
}
